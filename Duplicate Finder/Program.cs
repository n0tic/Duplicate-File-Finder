using System;
using System.Windows.Forms;

namespace Duplicate_Finder
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] paths)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm(CombineArguments(paths)));
        }

        static string CombineArguments(string[] args)
        {
            return string.Join(" ", args);
        }
    }
}
