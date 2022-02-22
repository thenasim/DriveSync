using DriveSync.Utils;

namespace DriveSync
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        internal void ShowSyncFolderText()
        {
            SyncFolderLabel.Text = Data.AppConfig?.FolderToSync ?? "Not selected";
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new Settings(ShowSyncFolderText).Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            Data.AppConfig = ConfigUtil.Load();
            ShowSyncFolderText();
        }
    }
}