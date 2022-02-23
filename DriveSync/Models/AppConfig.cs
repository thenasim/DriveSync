using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSync.Models
{
    public class AppConfig
    {
        public FolderToSync[]? FolderToSync { get; set; } = null;
        public string RCloneExePath { get; set; } = string.Empty;
        public int? RepeatSync { get; set; } = null; // save in the config by milliseconds
        public string[]? RemoteNames { get; set; } = null;
    }

    public record FolderToSync
    {
        public string? FolderPath { get; set; } = string.Empty;
        public string? RemoteName { get; set; } = string.Empty;
    }
}
