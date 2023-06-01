using Duplicate_Finder.Core;
using Duplicate_Finder.Data;
using Duplicate_Finder.Forms;
using Duplicate_Finder.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Duplicate_Finder
{
    public partial class MainForm : Form
    {
        public SettingsData settings;

        
        ButtonSimulator buttonSimulator = new ButtonSimulator();
        CancellationTokenSource cancellationTokenSource;
        List<DuplicateGroup> duplicateGroups;
        public int bufferSize = 1024;

        public int totalTime = 0;

        string filePath = "";

        public MainForm(string path)
        {
            InitializeComponent();

            textBox1.Text = path;

            duplicateGroups = new List<DuplicateGroup>();

            SaveSpaceLabel.Text = "";
            lblProgress.Text = "";
            TotalTimeLabel.Text = $"";

            NameLabel.Text = Core.Core.ApplicationName;
            VersionLabel.Text = Core.Core.Version;

            progressBar1.Visible = false;

            settings = SettingsData.LoadSettings();
            if(settings == null) settings = new SettingsData();

            treeView1.Select();
            treeView1.Focus();

            ProgressBox.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                btnScan_Click(null, EventArgs.Empty);
            }
            else
            {
                textBox1.Text = "Waiting for a directory path...";
            }
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            string folderPath = textBox1.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Invalid folder path.");
                return;
            }

            ProgressBox.Visible = true;
            progressBar1.Visible = true;

            if (settings.Search_AutoOptimize) OptimizeScan_Click(null, EventArgs.Empty);

            buttonSimulator.DisableButton(GetFilesButton, true);
            buttonSimulator.EnableButton(CancelButton);
            buttonSimulator.DisableButton(FolderBrowserButton);

            buttonSimulator.DisableButton(SettingsButton);
            ActionSelectButton.Enabled = false;

            ResetTreeView();
            SaveSpaceLabel.Text = "";
            lblProgress.Text = "Scanning for duplicates...";
            TotalTimeLabel.Text = $"";

            totalTime = 0;

            cancellationTokenSource = new CancellationTokenSource();
            duplicateGroups.Clear();

            try
            {
                await Task.Run(() => ScanForDuplicates(folderPath, cancellationTokenSource.Token));

                // Display the duplicate groups in the TreeView
                DisplayDuplicateGroups(duplicateGroups);
                lblProgress.Text = "Process Finished";
            }
            catch (OperationCanceledException)
            {
                // The scanning process was cancelled
                lblProgress.Text = "Process Cancelled";
            }
            finally
            {
                ProgressBox.Visible = false;

                buttonSimulator.DisableButton(CancelButton);
                buttonSimulator.EnableButton(GetFilesButton);
                buttonSimulator.EnableButton(FolderBrowserButton);

                buttonSimulator.EnableButton(SettingsButton);
                ActionSelectButton.Enabled = true;

                progressBar1.Visible = false;

                treeView1.ExpandAll();

                if(treeView1.Nodes.Count < 1)
                {
                    treeView1.Nodes.Add(new TreeNode("No duplicates found!"));
                }

                if(totalTime > 0) TotalTimeLabel.Text = $"Total Time: {totalTime} seconds";

                MessageBox.Show("The process of finding duplicates has finished.", "Process Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetTreeView()
        {
            treeView1.Nodes.Clear();

            FileNameLabel.Text = "";
            FileSizeLabel.Text = "";
            FileTypeLabel.Text = "";
            FileFullPathLabel.Text = "";
            FileFullPathLabel.Cursor = Cursors.Default;
            filePath = "";
        }

        private bool AreFilesIdentical(string filePath1, string filePath2, CancellationToken cancellationToken)
        {
            try
            {
                var fileInfo1 = new FileInfo(filePath1);
                var fileInfo2 = new FileInfo(filePath2);

                if (fileInfo1.Length != fileInfo2.Length)
                {
                    return false;
                }

                using (var md5 = MD5.Create())
                using (var stream1 = System.IO.File.OpenRead(filePath1))
                using (var stream2 = System.IO.File.OpenRead(filePath2))
                {
                    byte[] buffer1 = new byte[bufferSize];
                    byte[] buffer2 = new byte[bufferSize];

                    int bytesRead1;
                    int bytesRead2;
                    long totalBytesRead = 0;
                    double progressPercentage = 0;
                    TimeSpan elapsedTime = TimeSpan.Zero;

                    Stopwatch stopwatch = Stopwatch.StartNew();

                    do
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // The scanning process was cancelled
                            return false;
                        }


                        bytesRead1 = stream1.Read(buffer1, 0, bufferSize);
                        bytesRead2 = stream2.Read(buffer2, 0, bufferSize);

                        totalBytesRead += bytesRead1;

                        if (bytesRead1 != bytesRead2 || !buffer1.Take(bytesRead1).SequenceEqual(buffer2.Take(bytesRead2)))
                        {
                            return false;
                        }

                        progressPercentage = (double)totalBytesRead / fileInfo1.Length * 100;

                        //Console.WriteLine(progressPercentage);

                        progressx.Invoke((MethodInvoker)(() => {
                            progressx.Maximum = 100;
                            progressx.Value = (int)progressPercentage;
                        }));

                        // Calculate estimated remaining time
                        if (totalBytesRead > 0)
                        {
                            TimeSpan remainingTime = TimeSpan.Zero;
                            elapsedTime = stopwatch.Elapsed;

                            double bytesPerMillisecond = totalBytesRead / elapsedTime.TotalMilliseconds;
                            long remainingBytes = fileInfo1.Length - totalBytesRead;
                            double remainingMilliseconds = remainingBytes / bytesPerMillisecond;

                            remainingTime = TimeSpan.FromMilliseconds(remainingMilliseconds);

                            double remainingSeconds = (int)remainingTime.TotalSeconds;

                            RemainingTimeLabel.Invoke((MethodInvoker)(() => {
                                RemainingTimeLabel.Text = "Remaining time: " + remainingSeconds + " seconds";
                            }));
                        }

                    } while (bytesRead1 > 0);

                    stopwatch.Stop();
                    TimeSpan time = stopwatch.Elapsed;
                    totalTime += (int)time.TotalSeconds;

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                Console.WriteLine($"Error comparing files: {ex.Message}");
                throw; // Rethrow the exception to aid in debugging
            }
        }

        private void ScanForDuplicates(string folderPath, CancellationToken cancellationToken)
        {
            List<string> fileList = GetAllFiles(folderPath, cancellationToken);
            List<FileInfo> files = fileList.Select(f => new FileInfo(f)).ToList();

            progressBar1.Invoke((MethodInvoker)(() => {
                TotalFilesLabel.Text = $"Total Files Found:{Environment.NewLine}{files.Count}";
                RemainingTimeLabel.Text = "Please wait. This will only take a moment...";
            }));

            GetPotentialDuplicates(files, cancellationToken);

            // Compare files within the duplicate groups using more accurate methods (e.g., hash comparison)
            if(settings.Search_Content)
            {
                CompareDuplicateGroups(cancellationToken);
            }
        }

        private void GetPotentialDuplicates(List<FileInfo> files, CancellationToken cancellationToken)
        {
            List<DuplicateGroup> potentialDuplicates = new List<DuplicateGroup>();

            foreach (FileInfo fileInfo in files)
            {

                if(CheckFilters_continue(fileInfo)) { continue; }

                if (cancellationToken.IsCancellationRequested)
                {
                    // The scanning process was cancelled
                    return;
                }

                long fileSize = fileInfo.Length;

                DuplicateGroup group = potentialDuplicates.FirstOrDefault(g => g.FileSize == fileSize);

                if (group != null)
                {
                    // Compare the file with potential duplicates within the same size group
                    foreach (string filePath in group.FilePaths)
                    {
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // The scanning process was cancelled
                            return;
                        }

                        if(fileInfo.Length == new FileInfo(filePath).Length)
                        {
                            group.FilePaths.Add(fileInfo.FullName);
                            break;
                        }
                    }
                }
                else
                {
                    // Create a new potential duplicate group for the file size
                    group = new DuplicateGroup(fileSize);
                    group.FilePaths.Add(fileInfo.FullName);
                    potentialDuplicates.Add(group);
                }

                progressBar1.Invoke((MethodInvoker)(() => {
                    lblProgress.Text = $"File: {fileInfo.Name}";
                }));
            }

            // Filter out the duplicate groups containing more than one file
            duplicateGroups = potentialDuplicates.Where(g => g.FilePaths.Count > 1).ToList();

            int totalDuplicates = duplicateGroups.Sum(g => g.FilePaths.Count - 1);

            progressBar1.Invoke((MethodInvoker)(() => {
                PossibleDuplicatesLabel.Text = $"Possible Duplicates:{Environment.NewLine}{totalDuplicates}";
            }));

            PositiveDuplicateLabel.Invoke((MethodInvoker)(() =>
            {
                PositiveDuplicateLabel.Text = $"Positive Duplicates:{Environment.NewLine}0";
            }));
        }

        private bool CheckFilters_continue(FileInfo fileInfo)
        {
            if (settings.Search_Ignore_FileSizeUnder)
            {
                if (fileInfo.Length < 1048576 * settings.Search_Ignore_FileSizeUnderMB)
                {
                    return true;
                }
            }

            if (settings.Search_Ignore_ZeroByteFile)
            {
                if (fileInfo.Length < 1)
                {
                    return true;
                }
            }

            if (settings.Search_Ignore_HiddenFiles)
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    return true;
                }
            }

            if (settings.Search_Ignore_SystemFiles)
            {
                if (fileInfo.FullName.StartsWith(settings.windowsDirectory, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void CompareDuplicateGroups(CancellationToken cancellationToken)
        {
            int totalPossibleDuplicates = 0;
            int totalPositiveDuplicates = 0;

            foreach (DuplicateGroup group in duplicateGroups)
            {
                // Update the possible duplicates label
                totalPossibleDuplicates += group.FilePaths.Count;

                // Compare files within the group using hash comparison
                List<string> positiveDuplicates = new List<string>();

                for (int i = 0; i < group.FilePaths.Count - 1; i++)
                {
                    string filePath1 = group.FilePaths[i];
                    bool isPositiveDuplicate = false;

                    for (int j = i + 1; j < group.FilePaths.Count; j++)
                    {
                        string filePath2 = group.FilePaths[j];

                        if (AreFilesIdentical(filePath1, filePath2, cancellationToken))
                        {
                            isPositiveDuplicate = true;
                            break;
                        }
                    }

                    if (isPositiveDuplicate)
                    {
                        positiveDuplicates.Add(filePath1);
                    }
                }

                // Update the positive duplicates label
                totalPositiveDuplicates += positiveDuplicates.Count;
            }

            PossibleDuplicatesLabel.Invoke((MethodInvoker)(() =>
            {
                PossibleDuplicatesLabel.Text = $"Possible Duplicates:{Environment.NewLine}{totalPossibleDuplicates}";
            }));

            PositiveDuplicateLabel.Invoke((MethodInvoker)(() =>
            {
                PositiveDuplicateLabel.Text = $"Positive Duplicates:{Environment.NewLine}{totalPositiveDuplicates}";
            }));
        }

        private List<string> GetAllFiles(string folderPath, CancellationToken cancellationToken)
        {
            List<string> fileList = new List<string>();

            Queue<string> folderQueue = new Queue<string>();
            folderQueue.Enqueue(folderPath);

            while (folderQueue.Count > 0)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    // The scanning process was cancelled
                    return fileList;
                }

                string currentFolder = folderQueue.Dequeue();

                try
                {
                    string[] files = Directory.GetFiles(currentFolder);
                    string[] subfolders = Directory.GetDirectories(currentFolder);

                    fileList.AddRange(files);

                    foreach (string subfolder in subfolders)
                    {
                        folderQueue.Enqueue(subfolder);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during folder scanning
                    MessageBox.Show($"Error scanning folder: {ex.Message}");
                }
            }

            return fileList;
        }

        private void DisplayDuplicateGroups(List<DuplicateGroup> duplicateGroups)
        {
            ResetTreeView();

            int groupNumber = 1;

            foreach (DuplicateGroup group in duplicateGroups)
            {
                string groupName = $"Group {groupNumber}";

                TreeNode groupNode = new TreeNode(groupName);

                foreach (string filePath in group.FilePaths)
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    TreeNode fileNode = new TreeNode(fileInfo.Name);
                    fileNode.Tag = filePath;
                    groupNode.Nodes.Add(fileNode);
                }

                treeView1.Nodes.Add(groupNode);

                groupNumber++;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is string file)
            {
                FileInfo fileInfo = new FileInfo(file);
                FileNameLabel.Text = "Filename: " + fileInfo.Name;
                FileSizeLabel.Text = "Filesize: " + FormatFileSize(fileInfo.Length);
                FileTypeLabel.Text = "Extension: " + fileInfo.Extension;
                FileFullPathLabel.Text = "Full path:" + fileInfo.FullName;
                FileFullPathLabel.Cursor = Cursors.Hand;
                filePath = fileInfo.FullName;
            }
            else
            {
                FileNameLabel.Text = "";
                FileSizeLabel.Text = "";
                FileTypeLabel.Text = "";
                FileFullPathLabel.Text = "";
                FileFullPathLabel.Cursor = Cursors.Default;
                filePath = "";
            }
        }

        public static string FormatFileSize(long fileSize)
        {
            string[] sizeSuffixes = { "B", "KB", "MB", "GB", "TB" };
            const int baseUnit = 1024;
            if (fileSize == 0)
            {
                return "0 " + sizeSuffixes[0];
            }

            int sizeIndex = (int)Math.Floor(Math.Log(fileSize, baseUnit));
            double formattedSize = fileSize / Math.Pow(baseUnit, sizeIndex);

            return $"{formattedSize:F2} {sizeSuffixes[sizeIndex]}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private void FolderBrowserButton_Click(object sender, EventArgs e)
        {
            buttonSimulator.DisableButton(GetFilesButton);
            buttonSimulator.DisableButton(FolderBrowserButton);

            buttonSimulator.DisableButton(SettingsButton);
            ActionSelectButton.Enabled = false;

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = textBox1.Text;

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = folderDialog.SelectedPath;
                }
            }

            buttonSimulator.EnableButton(GetFilesButton);
            buttonSimulator.EnableButton(FolderBrowserButton);

            buttonSimulator.EnableButton(SettingsButton);
            ActionSelectButton.Enabled = true;
        }

        private void OptimizeScan_Click(object sender, EventArgs e)
        {
            var tmpBuffer = BufferSizeTest.DOBufferSizeTest(textBox1.Text);

            if(tmpBuffer > 0)
            {
                bufferSize = tmpBuffer;
                settings.Search_Buffer = tmpBuffer;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { radioButton1.Checked = false; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { radioButton2.Checked = false; }
        }

        private List<FileInfo> GetCheckedFiles()
        {
            List<FileInfo> checkedFiles = new List<FileInfo>();

            foreach (TreeNode groupNode in treeView1.Nodes)
            {
                foreach (TreeNode fileNode in groupNode.Nodes)
                {
                    if (fileNode.Checked && fileNode.Tag is string filePath)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        checkedFiles.Add(fileInfo);
                    }
                }
            }

            return checkedFiles;
        }

        private long CalculateTotalSize(List<FileInfo> files)
        {
            long totalSize = 0;

            foreach (FileInfo file in files)
            {
                totalSize += file.Length;
            }

            return totalSize;
        }

        private void UpdateTotalSizeLabel()
        {
            List<FileInfo> checkedFiles = GetCheckedFiles();
            long totalSize = CalculateTotalSize(checkedFiles);
            string formattedSize = FormatFileSize(totalSize);

            SaveSpaceLabel.Text = $"Total Size to save: {formattedSize}";
        }

        private void ActionSelectButton_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count < 1) { return; }

            buttonSimulator.DisableButton(CancelButton);
            buttonSimulator.DisableButton(GetFilesButton);
            buttonSimulator.DisableButton(FolderBrowserButton);

            buttonSimulator.DisableButton(SettingsButton);
            ActionSelectButton.Enabled = false;

            List<FileInfo> checkedFiles = GetCheckedFiles();

            if (radioButton1.Checked)
            {
                // Delete action
                if (MessageBox.Show("This will DELETE the selected files to the folder you select.\n\rAre you sure about this?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Perform delete action on checked files
                    foreach (FileInfo file in checkedFiles)
                    {
                        // Delete the file
                        file.Delete();
                    }

                    ResetTreeView();
                    SaveSpaceLabel.Text = "";
                }
            }
            else
            {
                // Move action
                if (MessageBox.Show("This will MOVE the selected files to the folder you select.\n\rAre you sure about this?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var folderDialog = new FolderBrowserDialog())
                    {
                        DialogResult result = folderDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string destinationFolder = folderDialog.SelectedPath;

                            // Move the checked files to the destination folder
                            foreach (FileInfo file in checkedFiles)
                            {
                                string destinationPath = Path.Combine(destinationFolder, file.Name);
                                file.MoveTo(destinationPath);
                            }

                            ResetTreeView();
                            SaveSpaceLabel.Text = "";
                        }
                    }
                }
            }

            buttonSimulator.EnableButton(GetFilesButton);
            buttonSimulator.EnableButton(FolderBrowserButton);

            buttonSimulator.EnableButton(SettingsButton);
            ActionSelectButton.Enabled = true;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            UpdateTotalSizeLabel();
        }

        private void FileFullPathLabel_Click(object sender, EventArgs e)
        {
            if (filePath == "") return;

            try
            {
                // Start the explorer.exe process with the /select argument
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e) => Application.Exit();

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void label1_MouseDown(object sender, MouseEventArgs e) => Core.Core.MoveWindow(this, e);

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using(SettingsForm form = new SettingsForm(this))
            {
                form.ShowDialog();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Waiting for a directory path...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Waiting for a directory path...";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            lblProgress.Text = "Cancellation awaiting confirmation... Please wait...";
            buttonSimulator.DisableButton(CancelButton);
        }
    }

    public class DuplicateGroup
    {
        public long FileSize { get; set; }
        public List<string> FilePaths { get; set; }

        public DuplicateGroup(long fileSize)
        {
            FileSize = fileSize;
            FilePaths = new List<string>();
        }
    }
}

// TODO: Fix the exclude of system files. Using settings windows path.
