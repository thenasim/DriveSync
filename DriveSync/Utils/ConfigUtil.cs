using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DriveSync.Models;

namespace DriveSync.Utils
{
    internal static class ConfigUtil
    {
        internal static bool Save(AppConfig appConfig)
        {
            try
            {
                JsonSerializerOptions options = new()
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                File.WriteAllText(Config.ConfigFilePath, JsonSerializer.Serialize(appConfig, options));

                if (File.Exists(Config.ConfigFilePath))
                {
                    MessageBox.Show("Settings saved successfully.", "Success");
                    return true;
                }

                MessageBox.Show("Can't found config file.", "Error occurred", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error occurred", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        internal static AppConfig? Load(Action? myFunc = null)
        {
            try
            {
                var content = File.ReadAllText(Config.ConfigFilePath);
                var result = JsonSerializer.Deserialize<AppConfig>(content);

                myFunc?.Invoke();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
