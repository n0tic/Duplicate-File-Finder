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
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.BufferSizeLabel = new System.Windows.Forms.Label();
            this.PositiveDuplicateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileFullPathLabel = new System.Windows.Forms.Label();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SaveSpaceLabel = new System.Windows.Forms.Label();
            this.AutoOptimizeButton = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FolderBrowserButton = new System.Windows.Forms.PictureBox();
            this.GetFilesButton = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBrowserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetFilesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(799, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(724, 20);
            this.textBox1.TabIndex = 4;
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.AutoSize = true;
            this.TotalFilesLabel.Location = new System.Drawing.Point(8, 57);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(55, 13);
            this.TotalFilesLabel.TabIndex = 7;
            this.TotalFilesLabel.Text = "Total files:";
            this.toolTip1.SetToolTip(this.TotalFilesLabel, "Total files found");
            // 
            // PossibleDuplicatesLabel
            // 
            this.PossibleDuplicatesLabel.AutoSize = true;
            this.PossibleDuplicatesLabel.Location = new System.Drawing.Point(8, 71);
            this.PossibleDuplicatesLabel.Name = "PossibleDuplicatesLabel";
            this.PossibleDuplicatesLabel.Size = new System.Drawing.Size(102, 13);
            this.PossibleDuplicatesLabel.TabIndex = 8;
            this.PossibleDuplicatesLabel.Text = "Possible Duplicates:";
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
            this.treeView1.Location = new System.Drawing.Point(11, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(468, 296);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(11, 39);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProgress.Size = new System.Drawing.Size(724, 12);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "Progress";
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.Location = new System.Drawing.Point(698, 70);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(89, 23);
            this.OptimizeButton.TabIndex = 12;
            this.OptimizeButton.Text = "Optimize";
            this.toolTip1.SetToolTip(this.OptimizeButton, "This tests the current path for the optimal buffer size to optimize the process");
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeScan_Click);
            // 
            // BufferSizeLabel
            // 
            this.BufferSizeLabel.Location = new System.Drawing.Point(567, 79);
            this.BufferSizeLabel.Name = "BufferSizeLabel";
            this.BufferSizeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BufferSizeLabel.Size = new System.Drawing.Size(129, 12);
            this.BufferSizeLabel.TabIndex = 13;
            this.BufferSizeLabel.Text = "Buffersize: 1289375MB";
            this.toolTip1.SetToolTip(this.BufferSizeLabel, "Displays the current buffer size");
            // 
            // PositiveDuplicateLabel
            // 
            this.PositiveDuplicateLabel.AutoSize = true;
            this.PositiveDuplicateLabel.Location = new System.Drawing.Point(8, 84);
            this.PositiveDuplicateLabel.Name = "PositiveDuplicateLabel";
            this.PositiveDuplicateLabel.Size = new System.Drawing.Size(100, 13);
            this.PositiveDuplicateLabel.TabIndex = 14;
            this.PositiveDuplicateLabel.Text = "Positive Duplicates:";
            this.toolTip1.SetToolTip(this.PositiveDuplicateLabel, "Total positive duplicate files found");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileFullPathLabel);
            this.groupBox1.Controls.Add(this.FileTypeLabel);
            this.groupBox1.Controls.Add(this.FileSizeLabel);
            this.groupBox1.Controls.Add(this.FileNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(485, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 303);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected File Info";
            // 
            // FileFullPathLabel
            // 
            this.FileFullPathLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FileFullPathLabel.Location = new System.Drawing.Point(6, 55);
            this.FileFullPathLabel.Name = "FileFullPathLabel";
            this.FileFullPathLabel.Size = new System.Drawing.Size(290, 240);
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
            // AutoOptimizeButton
            // 
            this.AutoOptimizeButton.AutoSize = true;
            this.AutoOptimizeButton.Checked = true;
            this.AutoOptimizeButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoOptimizeButton.Location = new System.Drawing.Point(699, 54);
            this.AutoOptimizeButton.Name = "AutoOptimizeButton";
            this.AutoOptimizeButton.Size = new System.Drawing.Size(91, 17);
            this.AutoOptimizeButton.TabIndex = 19;
            this.AutoOptimizeButton.Text = "Auto Optimize";
            this.toolTip1.SetToolTip(this.AutoOptimizeButton, "This will automatically start the process of testing the path for the optimal buf" +
        "fer size");
            this.AutoOptimizeButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
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
            this.SettingsButton.Location = new System.Drawing.Point(673, 3);
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
            this.VersionLabel.Location = new System.Drawing.Point(204, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(129, 15);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Duplicate File Finder";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Image = global::Duplicate_Finder.Properties.Resources._044_menu;
            this.MinimizeButton.Location = new System.Drawing.Point(750, 3);
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
            this.MaximizeButton.Location = new System.Drawing.Point(776, 3);
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
            this.panel3.Controls.Add(this.TotalFilesLabel);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.SaveSpaceLabel);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.AutoOptimizeButton);
            this.panel3.Controls.Add(this.FolderBrowserButton);
            this.panel3.Controls.Add(this.GetFilesButton);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.PossibleDuplicatesLabel);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.ActionSelectButton);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Controls.Add(this.PositiveDuplicateLabel);
            this.panel3.Controls.Add(this.lblProgress);
            this.panel3.Controls.Add(this.BufferSizeLabel);
            this.panel3.Controls.Add(this.OptimizeButton);
            this.panel3.Location = new System.Drawing.Point(1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 426);
            this.panel3.TabIndex = 23;
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
            ((System.ComponentModel.ISupportInitialize)(this.FolderBrowserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetFilesButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox FolderBrowserButton;
        private System.Windows.Forms.PictureBox GetFilesButton;
        private System.Windows.Forms.Label TotalFilesLabel;
        private System.Windows.Forms.Label PossibleDuplicatesLabel;
        private System.Windows.Forms.Button ActionSelectButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.Label BufferSizeLabel;
        private System.Windows.Forms.Label PositiveDuplicateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileFullPathLabel;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label SaveSpaceLabel;
        private System.Windows.Forms.CheckBox AutoOptimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox MaximizeButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}