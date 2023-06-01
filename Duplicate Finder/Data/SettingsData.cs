using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Duplicate_Finder.Data
{
    [Serializable]
    public class SettingsData
    {
        public string windowsDirectory = Path.GetDirectoryName(Environment.SystemDirectory);

        public bool Search_Content { get; set; } = true;

        public bool Search_Ignore_ZeroByteFile { get; set; } = true;
        public bool Search_Ignore_SystemFiles { get; set; } = true;
        public bool Search_Ignore_ReadOnlyFiles { get; set; } = true;
        public bool Search_Ignore_HiddenFiles { get; set; } = true;
        public bool Search_Ignore_FileSizeUnder { get; set; } = true;
        public int Search_Ignore_FileSizeUnderMB { get; set; } = 1;

        public int Search_Buffer { get; set; } = 1024;

        public bool Search_AutoOptimize { get; set; } = true;

        public void SaveSettings()
        {
            try
            {
                using (FileStream stream = new FileStream("settings.bin", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: An unexpected exception occurred while saving the settings.\n\r\n\r" + ex.Message);
            }
        }

        public static SettingsData LoadSettings()
        {
            try
            {
                using (FileStream stream = new FileStream("settings.bin", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (SettingsData)formatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                return new SettingsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: An unexpected exception occurred while loading the settings.\n\r\n\r" + ex.Message);
            }

            return null;
        }
    }
}