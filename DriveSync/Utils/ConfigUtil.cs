using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DriveSync.Models;

namespace DriveSync.Utils
{
    internal static class ConfigUtil
    {
        internal static void Save(AppConfig appConfig)
        {
            try
            {
                File.WriteAllText(Config.ConfigFilePath, JsonSerializer.Serialize(appConfig));

                if (File.Exists(Config.ConfigFilePath))
                {
                    MessageBox.Show("Settings saved successfully.", "Success");
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

        internal static AppConfig? Load()
        {
            try
            {
                var content = File.ReadAllText(Config.ConfigFilePath);
                return JsonSerializer.Deserialize<AppConfig>(content);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
