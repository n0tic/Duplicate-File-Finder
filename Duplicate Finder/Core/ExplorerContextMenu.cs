using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Duplicate_Finder.Core
{
    public static class ExplorerContextMenu
    {
        private const string RegistryKeyPath = @"Directory\shell\DuplicateFileFinderN";

        public static void RegisterContextMenu()
        {
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0168 // Variable is declared but never used
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
                MessageBox.Show("Error: An unexpected exception occurred while registering the context menu.");

            }
#pragma warning restore CS0168 // Variable is declared but never used
#pragma warning restore CS0168 // Variable is declared but never used
        }

        public static void UnregisterContextMenu()
        {
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0168 // Variable is declared but never used
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
                MessageBox.Show("Error: An unexpected exception occurred while unregistering the context menu.");

            }
#pragma warning restore CS0168 // Variable is declared but never used
#pragma warning restore CS0168 // Variable is declared but never used
        }

        public static bool IsContextMenuRegistered()
        {
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Default))
            using (var subKey = baseKey.OpenSubKey(RegistryKeyPath))
            {
                return subKey != null; // If subKey is not null, the registry key exists
            }
        }
    }
}