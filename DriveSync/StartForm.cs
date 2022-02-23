using DriveSync.Utils;

namespace DriveSync
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        internal void ShowSettingsInfo()
        {
            //SyncFolderLabel.Text = Data.AppConfig?.FolderToSync ?? "Not specified";
            RepeatTimeLabel.Text = Data.AppConfig?.RepeatSync.ToString() ?? "Not specified";
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

        private void SyncButton_Click(object sender, EventArgs e)
        {
            /*
            if (Data.AppConfig == null) return;
            var rClone = new RClone(Data.AppConfig.RCloneExePath);

            SyncButton.Text = "Syncing";
            SyncButton.Enabled = false;

            var isCopied = rClone.Copy(Data.AppConfig.FolderToSync, "demo:", out _);

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
        }
    }
}