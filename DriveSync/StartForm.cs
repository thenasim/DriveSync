using DriveSync.Utils;

namespace DriveSync
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}