using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveSync.Models;
using DriveSync.Utils;

namespace DriveSync
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            /*
            SelectFolderTxt.AutoSize = false;
            SelectFolderTxt.Size = new Size(500, 40);
            */
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SelectFolderTxt.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SelectRCloneButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                RCloneConfigTxt.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveConfig.Save(new AppConfig
            {
                FolderToSync = SelectFolderTxt.Text,
                RCloneConfig = RCloneConfigTxt.Text
            });
        }
    }
}
