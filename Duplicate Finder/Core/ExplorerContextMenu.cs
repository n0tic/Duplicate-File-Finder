using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicate_Finder.Core
{
    public static class ExplorerContextMenu
    {
        private const string RegistryKeyPath = @"Directory\shell\DuplicateFileFinderN";

        public static void RegisterContextMenu()
        {
            try
            {
                // Get the path of the application executable
                string appPath = Process.GetCurrentProcess().MainModule.FileName;

                // Set the command with the application path and "%1" placeholder
                string command = $"\"{appPath}\" \"%1\"";

                // Create the registry key for the menu option
                using (var key = Registry.ClassesRoot.CreateSubKey(RegistryKeyPath))
                {
                    // Set the menu option text
                    key.SetValue(null, "Find Duplicates");

                    // Create the command subkey and set the command value
                    using (var commandKey = key.CreateSubKey("command"))
                    {
                        commandKey.SetValue(null, command);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle the unauthorized access exception
                MessageBox.Show("The application was unauthorized to perform this action.\n\r\n\rPlease restart the application as administrator and try again.", "Unauthorized!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                //Console.WriteLine("Error: An unexpected exception occurred while registering the context menu.");
                
            }
        }

        public static void UnregisterContextMenu()
        {
            try
            {
                // Delete the registry key for the menu option
                Registry.ClassesRoot.DeleteSubKeyTree(RegistryKeyPath, false);
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle the unauthorized access exception
                MessageBox.Show("The application was unauthorized to perform this action.\n\r\n\rPlease restart the application as administrator and try again.", "Unauthorized!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                //Console.WriteLine("Error: An unexpected exception occurred while unregistering the context menu.");
                
            }
        }
    }
}