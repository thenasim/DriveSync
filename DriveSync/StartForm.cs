using DriveSync.Utils;

namespace DriveSync
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog.SelectedPath);
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            }
        }
    }
}