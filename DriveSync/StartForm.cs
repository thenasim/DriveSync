using DriveSync.Models;
using DriveSync.Service;
using DriveSync.Utils;

namespace DriveSync
{
    public partial class StartForm : Form
    {
        private bool _cancelSync = false;

        public StartForm()
        {
            InitializeComponent();
        }

        internal void ShowSettingsInfo()
        {
            RepeatSyncLabel.Text = Data.AppConfig?.RepeatSync.ToString() ?? "Not specified";
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new Settings(ShowSettingsInfo).Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            Data.AppConfig = ConfigUtil.Load();
            ShowSettingsInfo();
        }

        private async void SyncButton_Click(object sender, EventArgs e)
        {
            /*
            if (Data.AppConfig == null) return;
            var rClone = new RClone(Data.AppConfig.RCloneExePath);

            SyncButton.Text = "Syncing";
            SyncButton.Enabled = false;

            var isCopied = rClone.Copy(Data.AppConfig.FolderToSyncList, "demo:", out _);

            SyncButton.Text = "Sync";
            SyncButton.Enabled = true;

            var message = (isCopied ? "Successfully synced the data." : "Error occurred when syncing.");

            if (WindowState == FormWindowState.Minimized)
            {
                NotificationUtil.Show(message);
            }
            else
            {
                MessageBox.Show(message);
            }
            */

            if (Data.AppConfig == null) return;
            if (Data.AppConfig?.FolderToSyncList == null) return;

            var rClone = new RClone(Data.AppConfig.RCloneExePath);
            var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(Data.AppConfig.RepeatSync ?? 5000));

            do
            {
                var folderSyncList = Data.AppConfig.FolderToSyncList;
                var errorFolders = new List<FolderToSync>();

                // Sync Button show syncing
                SyncButton.Text = "Syncing";
                SyncButton.Enabled = false;

                foreach (var toSync in folderSyncList)
                {
                    CurrentlySyncingLabel.Text = toSync.FolderPath;
                    CurrentRemoteLabel.Text = toSync.RemoteName;

                    var isCopied = rClone.Copy(toSync.FolderPath, toSync.RemoteName, out _);

                    if (isCopied == false) errorFolders.Add(toSync);
                }

                // Sync Button text reset
                SyncButton.Text = "Sync";
                SyncButton.Enabled = true;

                // Show message is notification
                var message = (errorFolders.Count == 0 ? "Successfully synced all the folders." : "Error occurred while syncing.");
                //NotificationUtil.Show(message);
                MessageBox.Show(message);

                // Show errors is message box
                foreach (var errorFolder in errorFolders)
                {
                    MessageBox.Show($"Failed to sync '{errorFolder.FolderPath}'", "Error occurred while syncing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                errorFolders.Clear();
            } while (await timer.WaitForNextTickAsync() && _cancelSync == false);
        }

        public void RunSync()
        {
            MessageBox.Show("Yes");
            return;

            if (Data.AppConfig?.FolderToSyncList == null) return;

            foreach (var folderToSync in Data.AppConfig.FolderToSyncList)
            {
                var rClone = new RClone(Data.AppConfig.RCloneExePath);

                CurrentlySyncingLabel.Text = folderToSync.FolderPath;
                CurrentRemoteLabel.Text = folderToSync.RemoteName;

                var isCopied = rClone.Copy(folderToSync.FolderPath, folderToSync.RemoteName, out _);

                var message = (isCopied ? "Successfully synced the data." : "Error occurred when syncing.");
                NotificationUtil.Show(message);
            }
        }

        private async void CancelSyncButton_Click(object sender, EventArgs e)
        {
            _cancelSync = true;
        }
    }
}