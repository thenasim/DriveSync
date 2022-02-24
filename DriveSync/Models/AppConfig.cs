using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSync.Models
{
    public class AppConfig
    {
        public List<FolderToSync>? FolderToSyncList { get; set; } = null;
        public string RCloneExePath { get; set; } = string.Empty;
        public int? RepeatSync { get; set; } = null; // save in the config by milliseconds
        public List<string> RemoteNames { get; set; } = new();
    }

    public record FolderToSync
    {
        public string? FolderPath { get; set; } = string.Empty;
        public string? RemoteName { get; set; } = string.Empty;
    }
}
