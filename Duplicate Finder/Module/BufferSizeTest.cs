using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Duplicate_Finder.Module
{
    public static class BufferSizeTest
    {
        public static int DOBufferSizeTest(string path, bool settings = false)
        {

            if (!Directory.Exists(path))
            {
                if(settings)
                {
                    using (var folderDialog = new FolderBrowserDialog())
                    {
                        folderDialog.Description = "You need to specify directory on the drive you are most likely to do the scan on to get an accurate result.";
                        folderDialog.SelectedPath = path;

                        DialogResult result = folderDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("You are about to initiate a performance-intensive disk test. This process may temporarily freeze the program. Please wait while the test is being conducted...", "Demanding Task Ahead", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            path = folderDialog.SelectedPath;
                        }
                        else return -1;
                    }
                }
                else
                {
                    MessageBox.Show("You need to specify a directory in order to run the program.", "Invalid directory path!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                
            }

            string testFilePath = Path.Combine(path, "testfile.txt");

            int[] bufferSizes = { 4 * 1024, 8 * 1024, 16 * 1024, 32 * 1024, 64 * 1024, 128 * 1024 };
            long bestElapsedTime = long.MaxValue;
            int bestBufferSize = -1;

            foreach (int bufferSize in bufferSizes)
            {
                Stopwatch stopwatch = new Stopwatch();

                try
                {
                    bool createTestFile = !File.Exists(testFilePath);

                    if (createTestFile)
                    {
                        // Create a new temporary test file
                        using (FileStream fileStream = new FileStream(testFilePath, FileMode.Create, FileAccess.Write))
                        {
                            // Write some data to the test file if needed
                        }
                    }

                    using (FileStream fileStream = new FileStream(testFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                    {
                        byte[] buffer = new byte[bufferSize];

                        stopwatch.Start();

                        int bytesRead;
                        while ((bytesRead = fileStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            // Perform any additional processing here if needed
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Handle IOException, such as file access errors
                    MessageBox.Show($"Error accessing file: {ex.Message}");
                    return -1;
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions here
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return -1;
                }
                finally
                {
                    stopwatch.Stop();

                    long elapsedTime = stopwatch.ElapsedMilliseconds;

                    if (elapsedTime < bestElapsedTime)
                    {
                        bestElapsedTime = elapsedTime;
                        bestBufferSize = bufferSize;
                    }

                    if (File.Exists(testFilePath))
                        File.Delete(testFilePath);
                }
            }

            return bestBufferSize;
        }
    }
}
