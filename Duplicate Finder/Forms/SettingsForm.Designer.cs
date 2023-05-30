namespace Duplicate_Finder.Forms
{
    partial class SettingsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContextMenuButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BufferSizeNumber = new System.Windows.Forms.NumericUpDown();
            this.AutoOptimizeCheckbox = new System.Windows.Forms.CheckBox();
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MBNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HiddenFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.FileSizeUnderCheckbox = new System.Windows.Forms.CheckBox();
            this.ZeroByteFileCheckbox = new System.Windows.Forms.CheckBox();
            this.ReadOnlyFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.SystemFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameCheckbox = new System.Windows.Forms.CheckBox();
            this.ContentCheckbox = new System.Windows.Forms.CheckBox();
            this.ModifiedDateCheckbox = new System.Windows.Forms.CheckBox();
            this.SizeCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SaveSettingsButton);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(1, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 302);
            this.panel3.TabIndex = 25;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.SaveSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(203)))), ((int)(((byte)(233)))));
            this.SaveSettingsButton.FlatAppearance.BorderSize = 2;
            this.SaveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveSettingsButton.Location = new System.Drawing.Point(242, 273);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(103, 25);
            this.SaveSettingsButton.TabIndex = 21;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = false;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.ContextMenuButton);
            this.groupBox5.Location = new System.Drawing.Point(3, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 54);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Explorer Context Menu";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Add Explorer context menu option to quickly scan for duplicates for right clickin" +
    "g on folders.";
            // 
            // ContextMenuButton
            // 
            this.ContextMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.ContextMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.ContextMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContextMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextMenuButton.Location = new System.Drawing.Point(9, 19);
            this.ContextMenuButton.Name = "ContextMenuButton";
            this.ContextMenuButton.Size = new System.Drawing.Size(89, 23);
            this.ContextMenuButton.TabIndex = 12;
            this.ContextMenuButton.Text = "Add Feature";
            this.ContextMenuButton.UseVisualStyleBackColor = false;
            this.ContextMenuButton.Click += new System.EventHandler(this.ContextMenuButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.AutoOptimizeCheckbox);
            this.groupBox3.Controls.Add(this.OptimizeButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 73);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Checksum Content Scan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BufferSizeNumber);
            this.groupBox4.Location = new System.Drawing.Point(106, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 46);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buffersize";
            // 
            // BufferSizeNumber
            // 
            this.BufferSizeNumber.Location = new System.Drawing.Point(6, 19);
            this.BufferSizeNumber.Maximum = new decimal(new int[] {
            131072,
            0,
            0,
            0});
            this.BufferSizeNumber.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.BufferSizeNumber.Name = "BufferSizeNumber";
            this.BufferSizeNumber.Size = new System.Drawing.Size(99, 20);
            this.BufferSizeNumber.TabIndex = 31;
            this.BufferSizeNumber.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // AutoOptimizeCheckbox
            // 
            this.AutoOptimizeCheckbox.AutoSize = true;
            this.AutoOptimizeCheckbox.Location = new System.Drawing.Point(9, 19);
            this.AutoOptimizeCheckbox.Name = "AutoOptimizeCheckbox";
            this.AutoOptimizeCheckbox.Size = new System.Drawing.Size(91, 17);
            this.AutoOptimizeCheckbox.TabIndex = 19;
            this.AutoOptimizeCheckbox.Text = "Auto Optimize";
            this.toolTip1.SetToolTip(this.AutoOptimizeCheckbox, "This automizes the optimization feature before starting the Content scan. It does" +
        " a system test before initiating the file scan.");
            this.AutoOptimizeCheckbox.UseVisualStyleBackColor = true;
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.OptimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.OptimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OptimizeButton.Location = new System.Drawing.Point(8, 42);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(89, 23);
            this.OptimizeButton.TabIndex = 12;
            this.OptimizeButton.Text = "Optimize";
            this.OptimizeButton.UseVisualStyleBackColor = false;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MBNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HiddenFilesCheckbox);
            this.groupBox2.Controls.Add(this.FileSizeUnderCheckbox);
            this.groupBox2.Controls.Add(this.ZeroByteFileCheckbox);
            this.groupBox2.Controls.Add(this.ReadOnlyFilesCheckbox);
            this.groupBox2.Controls.Add(this.SystemFilesCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 73);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ignore";
            // 
            // MBNumber
            // 
            this.MBNumber.Location = new System.Drawing.Point(217, 40);
            this.MBNumber.Name = "MBNumber";
            this.MBNumber.Size = new System.Drawing.Size(70, 20);
            this.MBNumber.TabIndex = 27;
            this.MBNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "MB";
            // 
            // HiddenFilesCheckbox
            // 
            this.HiddenFilesCheckbox.AutoSize = true;
            this.HiddenFilesCheckbox.Location = new System.Drawing.Point(8, 42);
            this.HiddenFilesCheckbox.Name = "HiddenFilesCheckbox";
            this.HiddenFilesCheckbox.Size = new System.Drawing.Size(81, 17);
            this.HiddenFilesCheckbox.TabIndex = 24;
            this.HiddenFilesCheckbox.Text = "Hidden files";
            this.HiddenFilesCheckbox.UseVisualStyleBackColor = true;
            // 
            // FileSizeUnderCheckbox
            // 
            this.FileSizeUnderCheckbox.AutoSize = true;
            this.FileSizeUnderCheckbox.Location = new System.Drawing.Point(120, 42);
            this.FileSizeUnderCheckbox.Name = "FileSizeUnderCheckbox";
            this.FileSizeUnderCheckbox.Size = new System.Drawing.Size(90, 17);
            this.FileSizeUnderCheckbox.TabIndex = 26;
            this.FileSizeUnderCheckbox.Text = "Filesize under";
            this.FileSizeUnderCheckbox.UseVisualStyleBackColor = true;
            // 
            // ZeroByteFileCheckbox
            // 
            this.ZeroByteFileCheckbox.AutoSize = true;
            this.ZeroByteFileCheckbox.Location = new System.Drawing.Point(8, 19);
            this.ZeroByteFileCheckbox.Name = "ZeroByteFileCheckbox";
            this.ZeroByteFileCheckbox.Size = new System.Drawing.Size(92, 17);
            this.ZeroByteFileCheckbox.TabIndex = 20;
            this.ZeroByteFileCheckbox.Text = "Zero byte files";
            this.ZeroByteFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // ReadOnlyFilesCheckbox
            // 
            this.ReadOnlyFilesCheckbox.AutoSize = true;
            this.ReadOnlyFilesCheckbox.Location = new System.Drawing.Point(214, 18);
            this.ReadOnlyFilesCheckbox.Name = "ReadOnlyFilesCheckbox";
            this.ReadOnlyFilesCheckbox.Size = new System.Drawing.Size(95, 17);
            this.ReadOnlyFilesCheckbox.TabIndex = 23;
            this.ReadOnlyFilesCheckbox.Text = "Read only files";
            this.ReadOnlyFilesCheckbox.UseVisualStyleBackColor = true;
            // 
            // SystemFilesCheckbox
            // 
            this.SystemFilesCheckbox.AutoSize = true;
            this.SystemFilesCheckbox.Location = new System.Drawing.Point(120, 19);
            this.SystemFilesCheckbox.Name = "SystemFilesCheckbox";
            this.SystemFilesCheckbox.Size = new System.Drawing.Size(81, 17);
            this.SystemFilesCheckbox.TabIndex = 22;
            this.SystemFilesCheckbox.Text = "System files";
            this.SystemFilesCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameCheckbox);
            this.groupBox1.Controls.Add(this.ContentCheckbox);
            this.groupBox1.Controls.Add(this.ModifiedDateCheckbox);
            this.groupBox1.Controls.Add(this.SizeCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 48);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match by";
            // 
            // NameCheckbox
            // 
            this.NameCheckbox.AutoSize = true;
            this.NameCheckbox.Location = new System.Drawing.Point(8, 19);
            this.NameCheckbox.Name = "NameCheckbox";
            this.NameCheckbox.Size = new System.Drawing.Size(54, 17);
            this.NameCheckbox.TabIndex = 20;
            this.NameCheckbox.Text = "Name";
            this.NameCheckbox.UseVisualStyleBackColor = true;
            // 
            // ContentCheckbox
            // 
            this.ContentCheckbox.AutoSize = true;
            this.ContentCheckbox.Location = new System.Drawing.Point(214, 18);
            this.ContentCheckbox.Name = "ContentCheckbox";
            this.ContentCheckbox.Size = new System.Drawing.Size(126, 17);
            this.ContentCheckbox.TabIndex = 23;
            this.ContentCheckbox.Text = "Content (Hash, Slow)";
            this.ContentCheckbox.UseVisualStyleBackColor = true;
            // 
            // ModifiedDateCheckbox
            // 
            this.ModifiedDateCheckbox.AutoSize = true;
            this.ModifiedDateCheckbox.Location = new System.Drawing.Point(120, 19);
            this.ModifiedDateCheckbox.Name = "ModifiedDateCheckbox";
            this.ModifiedDateCheckbox.Size = new System.Drawing.Size(90, 17);
            this.ModifiedDateCheckbox.TabIndex = 22;
            this.ModifiedDateCheckbox.Text = "Modified date";
            this.ModifiedDateCheckbox.UseVisualStyleBackColor = true;
            // 
            // SizeCheckbox
            // 
            this.SizeCheckbox.AutoSize = true;
            this.SizeCheckbox.Location = new System.Drawing.Point(68, 19);
            this.SizeCheckbox.Name = "SizeCheckbox";
            this.SizeCheckbox.Size = new System.Drawing.Size(46, 17);
            this.SizeCheckbox.TabIndex = 21;
            this.SizeCheckbox.Text = "Size";
            this.SizeCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 24);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::Duplicate_Finder.Properties.Resources._078_remove;
            this.ExitButton.Location = new System.Drawing.Point(326, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(73, 21);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Settings";
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseDown);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 327);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ContentCheckbox;
        private System.Windows.Forms.CheckBox ModifiedDateCheckbox;
        private System.Windows.Forms.CheckBox SizeCheckbox;
        private System.Windows.Forms.CheckBox NameCheckbox;
        private System.Windows.Forms.CheckBox AutoOptimizeCheckbox;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MBNumber;
        private System.Windows.Forms.CheckBox HiddenFilesCheckbox;
        private System.Windows.Forms.CheckBox FileSizeUnderCheckbox;
        private System.Windows.Forms.CheckBox ZeroByteFileCheckbox;
        private System.Windows.Forms.CheckBox ReadOnlyFilesCheckbox;
        private System.Windows.Forms.CheckBox SystemFilesCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ContextMenuButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.NumericUpDown BufferSizeNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}