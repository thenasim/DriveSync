using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveSync.Models;
using DriveSync.Utils;
using static System.Int32;

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
            var appConfig = ConfigUtil.Load();

            if (appConfig == null) return;
            SelectFolderTxt.Text = appConfig.FolderToSync;
            RCloneConfigTxt.Text = appConfig.RCloneConfig;
            RepeatSyncTxt.Text = appConfig.RepeatSync.ToString();
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
            ConfigUtil.Save(new AppConfig
            {
                FolderToSync = SelectFolderTxt.Text,
                RCloneConfig = RCloneConfigTxt.Text,
                RepeatSync = Convert.ToInt32(RepeatSyncTxt.Text),
            });
        }

        private void RepeatSyncTxt_TextChanged(object sender, EventArgs e)
        {
            //ValidateRepeatSync();
        }

        // Validation
        private void ValidateRepeatSync()
        {
            if (string.IsNullOrEmpty(RepeatSyncTxt.Text))
            {
                RepeatSyncTxt.Text = "550";
                return;
            }

            var input = RepeatSyncTxt.Text.Trim();

            if (TryParse(input, out var inputNumber) == false)
            {
                RepeatSyncTxt.Text = Regex.Replace(RepeatSyncTxt.Text, @"[^\d]", string.Empty);
                return;
            }

            RepeatSyncTxt.Text = inputNumber switch
            {
                < 500 => "550",
                _ => RepeatSyncTxt.Text
            };
        }
    }
}
