using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DriveSync.Models;

namespace DriveSync.Utils
{
    internal static class SaveConfig
    {
        private const string FolderName = "DriveSync";
        private const string ConfigFileName = "config.json";

        internal static void Save(AppConfig appConfig)
        {
            try
            {
                var localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var path = Path.Combine(localPath, FolderName, ConfigFileName);

                File.WriteAllText(path, JsonSerializer.Serialize(appConfig));

                if (File.Exists(path))
                {
                    MessageBox.Show("Successfully saved config file", "Success");
                    return;
                }

                MessageBox.Show("Can't found config file.", "Error occurred", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error occurred", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
