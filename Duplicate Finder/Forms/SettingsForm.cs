using Duplicate_Finder.Module;
using System;
using System.Windows.Forms;

namespace Duplicate_Finder.Forms
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ContextMenuButton_Click(object sender, EventArgs e)
        {
            if (!ExplorerContextMenu.IsContextMenuRegistered())
            {
                if (MessageBox.Show("Add the option to quickly scan for duplicates using the explorer context menu.\n\r\n\rSelect YES if you want to add the functionality.", "Explorer Context Menu Feature", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExplorerContextMenu.RegisterContextMenu();
                }
            }
            else
            {
                if (MessageBox.Show("Remove the option to quickly scan for duplicates using the explorer context menu.\n\r\n\rSelect YES if you want to remove the functionality.", "Explorer Context Menu Feature", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExplorerContextMenu.UnregisterContextMenu();
                }
            }
        }

        private void NameLabel_MouseDown(object sender, MouseEventArgs e) => Core.Core.MoveWindow(this, e);

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ContentCheckbox.Checked = mainForm.settings.Search_Content;

            ZeroByteFileCheckbox.Checked = mainForm.settings.Search_Ignore_ZeroByteFile;
            SystemFilesCheckbox.Checked = mainForm.settings.Search_Ignore_SystemFiles;
            ReadOnlyFilesCheckbox.Checked = mainForm.settings.Search_Ignore_ReadOnlyFiles;
            HiddenFilesCheckbox.Checked = mainForm.settings.Search_Ignore_HiddenFiles;
            FileSizeUnderCheckbox.Checked = mainForm.settings.Search_Ignore_FileSizeUnder;
            MBNumber.Value = mainForm.settings.Search_Ignore_FileSizeUnderMB;

            BufferSizeNumber.Value = mainForm.settings.Search_Buffer;

            AutoOptimizeCheckbox.Checked = mainForm.settings.Search_AutoOptimize;
        }

        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            var tmpBuffer = BufferSizeTest.DOBufferSizeTest(mainForm.textBox1.Text, true);

            if (tmpBuffer > 0)
            {
                mainForm.bufferSize = tmpBuffer;
                mainForm.settings.Search_Buffer = tmpBuffer;

                BufferSizeNumber.Value = tmpBuffer;

                MessageBox.Show($"Optimization has finished and the new buffersize ({tmpBuffer}) has been set in the program.", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            mainForm.settings.Search_AutoOptimize = AutoOptimizeCheckbox.Checked;

            mainForm.settings.Search_Buffer = (int)BufferSizeNumber.Value;

            mainForm.settings.Search_Ignore_FileSizeUnderMB = (int)MBNumber.Value;
            mainForm.settings.Search_Ignore_FileSizeUnder = FileSizeUnderCheckbox.Checked;
            mainForm.settings.Search_Ignore_HiddenFiles = HiddenFilesCheckbox.Checked;
            mainForm.settings.Search_Ignore_ReadOnlyFiles = ReadOnlyFilesCheckbox.Checked;
            mainForm.settings.Search_Ignore_SystemFiles = SystemFilesCheckbox.Checked;
            mainForm.settings.Search_Ignore_ZeroByteFile = ZeroByteFileCheckbox.Checked;

            mainForm.settings.Search_Content = ContentCheckbox.Checked;

            mainForm.settings.SaveSettings();

            Close();
        }
    }
}
