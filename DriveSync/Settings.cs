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
using Mapster;
using static System.Int32;

namespace DriveSync
{
    public partial class Settings : Form
    {
        private Action? ShowSyncFolderTextAction { get; set; }
        //private HashSet<string>

        public Settings(Action? showSyncFolderTextAction = null)
        {
            InitializeComponent();
            ShowSyncFolderTextAction = showSyncFolderTextAction;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Data.AppConfig == null) return;

            //SelectFolderTxt.Text = Data.AppConfig.FolderToSync;
            RCloneConfigTxt.Text = Data.AppConfig.RCloneExePath;
            RepeatSyncTxt.Text = Data.AppConfig.RepeatSync.ToString();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void SelectRCloneButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RCloneConfigTxt.Text = openFileDialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
            var isSaved = ConfigUtil.Save(new AppConfig
            {
                //FolderToSync = SelectFolderTxt.Text,
                RCloneExePath = RCloneConfigTxt.Text,
                RepeatSync = Convert.ToInt32(RepeatSyncTxt.Text),
            });

            if (!isSaved) return;

            Data.AppConfig = ConfigUtil.Load();
            
            ShowSyncFolderTextAction?.Invoke();
            Hide();
            */
        }

        private void RepeatSyncTxt_TextChanged(object sender, EventArgs e)
        {
            // TODO: Validate later
            //ValidateRepeatSync();
        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowPanel = new()
            {
                Width = 1080,
                Height = 52
            };

            var newFolderBrowserDialog = new FolderBrowserDialog();

            Label label = new()
            {
                Text = "Sync Folder"
            };

            TextBox textBox = new()
            {
                Multiline = RCloneConfigTxt.Multiline,
                Font = RCloneConfigTxt.Font,
                Size = RCloneConfigTxt.Size,
                ReadOnly = RCloneConfigTxt.ReadOnly,
                Margin = RCloneConfigTxt.Margin
            };

            Button button = new()
            {
                Size = SelectRCloneButton.Size,
                Text = "Select"
            };

            button.Click += (_, _) =>
            {
                if (newFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = newFolderBrowserDialog.SelectedPath;
                }
            };

            ComboBox combobox = new()
            {
                Font = TestCmbx.Font,
                Margin = TestCmbx.Margin,
                Size = TestCmbx.Size
            };

            flowPanel.Controls.Add(label);
            flowPanel.Controls.Add(textBox);
            flowPanel.Controls.Add(button);
            flowPanel.Controls.Add(combobox);

            FlowLayoutPanel.Controls.Add(flowPanel);
        }

        // Validation
        /*
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
        */
    }
}
