using Duplicate_Finder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Application.Exit();
        }
    }
}
