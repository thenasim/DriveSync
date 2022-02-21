using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSync.Models
{
    public class AppConfig
    {
        public string FolderToSync { get; set; } = string.Empty;
        public string RCloneConfig { get; set; } = string.Empty;
    }
}
