using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace DriveSync.Utils
{
    internal static class NotificationUtil
    {
        private static readonly ToastContentBuilder Builder = new();

        internal static void Show(string title, string description = "")
        {
            Builder
            .AddText(title)
            .AddText(description)
            .Show();
        }
    }
}
