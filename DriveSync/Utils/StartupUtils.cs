using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DriveSync.Utils
{
    internal static class StartupUtils
    {
        private const string ApplicationName = "DriveSyncDesktop";
        private const string Run = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

        static bool Add()
        {
            var rk = Registry.CurrentUser.OpenSubKey(Run, true);

            if (rk == null) return false;

            rk.SetValue(ApplicationName, Application.ExecutablePath);
            return true;

        }

        static bool Remove()
        {
            var rk = Registry.CurrentUser.OpenSubKey(Run, true);

            if (rk == null) return false;

            rk.DeleteValue(ApplicationName, false);
            return true;
        }
    }
}
