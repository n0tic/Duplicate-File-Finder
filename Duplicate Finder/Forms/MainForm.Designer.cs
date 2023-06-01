namespace Duplicate_Finder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalFilesLabel = new System.Windows.Forms.Label();
            this.PossibleDuplicatesLabel = new System.Windows.Forms.Label();
            this.ActionSelectButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblProgress = new System.Windows.Forms.Label();
            this.PositiveDuplicateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileFullPathLabel = new System.Windows.Forms.Label();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SaveSpaceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProgressBox = new System.Windows.Forms.GroupBox();
            this.progressx = new System.Windows.Forms.ProgressBar();
            this.LoadingIndicator = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FolderBrowserButton = new System.Windows.Forms.PictureBox();
            this.GetFilesButton = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.ProgressBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBrowserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetFilesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(799, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(724, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Waiting for a directory path...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFilesLabel.ForeColor = System.Drawing.Color.White;
            this.TotalFilesLabel.Location = new System.Drawing.Point(0, 0);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(127, 56);
            this.TotalFilesLabel.TabIndex = 7;
            this.TotalFilesLabel.Text = "Total Files Found:\r\n0";
            this.TotalFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.TotalFilesLabel, "Total files found");
            // 
            // PossibleDuplicatesLabel
            // 
            this.PossibleDuplicatesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PossibleDuplicatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PossibleDuplicatesLabel.ForeColor = System.Drawing.Color.White;
            this.PossibleDuplicatesLabel.Location = new System.Drawing.Point(0, 0);
            this.PossibleDuplicatesLabel.Name = "PossibleDuplicatesLabel";
            this.PossibleDuplicatesLabel.Size = new System.Drawing.Size(127, 56);
            this.PossibleDuplicatesLabel.TabIndex = 8;
            this.PossibleDuplicatesLabel.Text = "Possible Duplicates:\r\n0";
            this.PossibleDuplicatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.PossibleDuplicatesLabel, "Total possible duplicate files found");
            // 
            // ActionSelectButton
            // 
            this.ActionSelectButton.Location = new System.Drawing.Point(706, 398);
            this.ActionSelectButton.Name = "ActionSelectButton";
            this.ActionSelectButton.Size = new System.Drawing.Size(82, 22);
            this.ActionSelectButton.TabIndex = 9;
            this.ActionSelectButton.Text = "Process Files";
            this.toolTip1.SetToolTip(this.ActionSelectButton, "This will run the selected option of either deleting or moving the selected files" +
        "");
            this.ActionSelectButton.UseVisualStyleBackColor = true;
            this.ActionSelectButton.Click += new System.EventHandler(this.ActionSelectButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(11, 107);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(468, 289);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(3, 46);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(328, 12);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "Processing file:";
            this.toolTip1.SetToolTip(this.lblProgress, "Current file being processed");
            // 
            // PositiveDuplicateLabel
            // 
            this.PositiveDuplicateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositiveDuplicateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositiveDuplicateLabel.ForeColor = System.Drawing.Color.White;
            this.PositiveDuplicateLabel.Location = new System.Drawing.Point(0, 0);
            this.PositiveDuplicateLabel.Name = "PositiveDuplicateLabel";
            this.PositiveDuplicateLabel.Size = new System.Drawing.Size(127, 56);
            this.PositiveDuplicateLabel.TabIndex = 14;
            this.PositiveDuplicateLabel.Text = "Positive Duplicates:\r\n0";
            this.PositiveDuplicateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.PositiveDuplicateLabel, "Total positive duplicate files found. This is only produced with Content filter a" +
        "s it is most accurate.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileFullPathLabel);
            this.groupBox1.Controls.Add(this.FileTypeLabel);
            this.groupBox1.Controls.Add(this.FileSizeLabel);
            this.groupBox1.Controls.Add(this.FileNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(485, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 296);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected File Info";
            // 
            // FileFullPathLabel
            // 
            this.FileFullPathLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FileFullPathLabel.Location = new System.Drawing.Point(6, 55);
            this.FileFullPathLabel.Name = "FileFullPathLabel";
            this.FileFullPathLabel.Size = new System.Drawing.Size(290, 238);
            this.FileFullPathLabel.TabIndex = 3;
            this.FileFullPathLabel.Click += new System.EventHandler(this.FileFullPathLabel_Click);
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.Location = new System.Drawing.Point(6, 42);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(290, 13);
            this.FileTypeLabel.TabIndex = 2;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.Location = new System.Drawing.Point(6, 29);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(290, 13);
            this.FileSizeLabel.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Location = new System.Drawing.Point(6, 16);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(290, 13);
            this.FileNameLabel.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(599, 402);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Delete Selected";
            this.toolTip1.SetToolTip(this.radioButton1, "Select this option to get an option to delete the files from the drive");
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(494, 401);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Move Selected";
            this.toolTip1.SetToolTip(this.radioButton2, "Select this option to get an option to move the files to a specific folder");
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SaveSpaceLabel
            // 
            this.SaveSpaceLabel.AutoSize = true;
            this.SaveSpaceLabel.Location = new System.Drawing.Point(8, 398);
            this.SaveSpaceLabel.Name = "SaveSpaceLabel";
            this.SaveSpaceLabel.Size = new System.Drawing.Size(63, 13);
            this.SaveSpaceLabel.TabIndex = 18;
            this.SaveSpaceLabel.Text = "SaveSpace";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.VersionLabel);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 24);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = global::Duplicate_Finder.Properties.Resources._003_cogwheel;
            this.SettingsButton.Location = new System.Drawing.Point(724, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(20, 20);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SettingsButton, "Open the settings window");
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(204, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(129, 15);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Duplicate File Finder";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Image = global::Duplicate_Finder.Properties.Resources._044_menu;
            this.MinimizeButton.Location = new System.Drawing.Point(750, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizeButton, "Minimize");
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeButton.Image = global::Duplicate_Finder.Properties.Resources._078_remove;
            this.MaximizeButton.Location = new System.Drawing.Point(776, 2);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(20, 20);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.MaximizeButton, "Close application");
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(37, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(171, 21);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Duplicate File Finder";
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Duplicate_Finder.Properties.Resources.File_Explorer_23583;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.SaveSpaceLabel);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.FolderBrowserButton);
            this.panel3.Controls.Add(this.GetFilesButton);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.ActionSelectButton);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Controls.Add(this.CancelButton);
            this.panel3.Controls.Add(this.ProgressBox);
            this.panel3.Controls.Add(this.TotalTimeLabel);
            this.panel3.Location = new System.Drawing.Point(1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 426);
            this.panel3.TabIndex = 23;
            // 
            // ProgressBox
            // 
            this.ProgressBox.Controls.Add(this.RemainingTimeLabel);
            this.ProgressBox.Controls.Add(this.progressx);
            this.ProgressBox.Controls.Add(this.LoadingIndicator);
            this.ProgressBox.Controls.Add(this.lblProgress);
            this.ProgressBox.Location = new System.Drawing.Point(410, 38);
            this.ProgressBox.Name = "ProgressBox";
            this.ProgressBox.Size = new System.Drawing.Size(377, 62);
            this.ProgressBox.TabIndex = 25;
            this.ProgressBox.TabStop = false;
            this.ProgressBox.Text = "Progress:";
            // 
            // progressx
            // 
            this.progressx.Location = new System.Drawing.Point(6, 30);
            this.progressx.Name = "progressx";
            this.progressx.Size = new System.Drawing.Size(325, 14);
            this.progressx.TabIndex = 24;
            this.toolTip1.SetToolTip(this.progressx, "Current file progress");
            // 
            // LoadingIndicator
            // 
            this.LoadingIndicator.Image = global::Duplicate_Finder.Properties.Resources.Dual_Ring_0_4s_204px;
            this.LoadingIndicator.Location = new System.Drawing.Point(337, 21);
            this.LoadingIndicator.Name = "LoadingIndicator";
            this.LoadingIndicator.Size = new System.Drawing.Size(31, 31);
            this.LoadingIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingIndicator.TabIndex = 22;
            this.LoadingIndicator.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.panel5.Controls.Add(this.PositiveDuplicateLabel);
            this.panel5.Location = new System.Drawing.Point(277, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 56);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.panel4.Controls.Add(this.PossibleDuplicatesLabel);
            this.panel4.Location = new System.Drawing.Point(144, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 56);
            this.panel4.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.TotalFilesLabel);
            this.panel2.Location = new System.Drawing.Point(11, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 56);
            this.panel2.TabIndex = 19;
            // 
            // FolderBrowserButton
            // 
            this.FolderBrowserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FolderBrowserButton.Image = global::Duplicate_Finder.Properties.Resources._010_folder_30;
            this.FolderBrowserButton.Location = new System.Drawing.Point(741, 17);
            this.FolderBrowserButton.Name = "FolderBrowserButton";
            this.FolderBrowserButton.Size = new System.Drawing.Size(20, 20);
            this.FolderBrowserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FolderBrowserButton.TabIndex = 5;
            this.FolderBrowserButton.TabStop = false;
            this.toolTip1.SetToolTip(this.FolderBrowserButton, "Select a folder to scan");
            this.FolderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // GetFilesButton
            // 
            this.GetFilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetFilesButton.Image = global::Duplicate_Finder.Properties.Resources.play_button;
            this.GetFilesButton.Location = new System.Drawing.Point(767, 17);
            this.GetFilesButton.Name = "GetFilesButton";
            this.GetFilesButton.Size = new System.Drawing.Size(20, 20);
            this.GetFilesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GetFilesButton.TabIndex = 6;
            this.GetFilesButton.TabStop = false;
            this.toolTip1.SetToolTip(this.GetFilesButton, "Start scan process");
            this.GetFilesButton.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Image = global::Duplicate_Finder.Properties.Resources.stop;
            this.CancelButton.Location = new System.Drawing.Point(767, 17);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(20, 20);
            this.CancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CancelButton.TabIndex = 23;
            this.CancelButton.TabStop = false;
            this.toolTip1.SetToolTip(this.CancelButton, "Start scan process");
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.Location = new System.Drawing.Point(3, 16);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(325, 12);
            this.RemainingTimeLabel.TabIndex = 25;
            this.RemainingTimeLabel.Text = "Getting files...";
            this.toolTip1.SetToolTip(this.RemainingTimeLabel, "Status and Time remaining");
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.Location = new System.Drawing.Point(485, 80);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(301, 18);
            this.TotalTimeLabel.TabIndex = 26;
            this.TotalTimeLabel.Text = "Total Time: ";
            this.TotalTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(801, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ProgressBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderBrowserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetFilesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox FolderBrowserButton;
        private System.Windows.Forms.PictureBox GetFilesButton;
        private System.Windows.Forms.Label TotalFilesLabel;
        private System.Windows.Forms.Label PossibleDuplicatesLabel;
        private System.Windows.Forms.Button ActionSelectButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label PositiveDuplicateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileFullPathLabel;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label SaveSpaceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox MaximizeButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox LoadingIndicator;
        private System.Windows.Forms.PictureBox CancelButton;
        private System.Windows.Forms.ProgressBar progressx;
        private System.Windows.Forms.GroupBox ProgressBox;
        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
    }
}