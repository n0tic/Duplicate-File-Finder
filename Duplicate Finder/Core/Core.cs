using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicate_Finder.Core
{
    public static class Core
    {

        public static string ApplicationName = "Duplicate File Finder";
        public static string Version = "v0.0.1a";

        #region Move Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MoveWindow(Form main, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(main.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion Move Window
    }
}
