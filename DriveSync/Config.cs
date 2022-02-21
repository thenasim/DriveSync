using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSync
{
    internal static class Config
    {
        public const string FolderName = "DriveSync";
        public const string ConfigFileName = "config.json";
        public static string LocalAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string ConfigFilePath = Path.Combine(LocalAppDataFolder, FolderName, ConfigFileName);
    }
}
