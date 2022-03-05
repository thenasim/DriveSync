using System.Text.Json;
using DriveSync.ApiInterfaces;
using DriveSync.Models;
using DriveSync.Utils;
using Refit;

namespace DriveSync;

public partial class Settings : Form
{
    private readonly List<TextBoxCombobox> _textBoxComboboxes = new();

    public Settings(Action? showSyncFolderTextAction = null)
    {
        InitializeComponent();
        ShowSyncFolderTextAction = showSyncFolderTextAction;
    }

    private Action? ShowSyncFolderTextAction { get; }
    private List<string> RemoteNames { get; set; } = new();

    private async void Settings_Load(object sender, EventArgs e)
    {
        if (Data.AppConfig == null) return;

        RCloneConfigTxt.Text = Data.AppConfig.RCloneExePath;
        RepeatSyncTxt.Text = Data.AppConfig.RepeatSync.ToString();

        if (Data.AppConfig.FolderToSyncList == null) return;

        foreach (var folderToSync in Data.AppConfig.FolderToSyncList)
            LoadInputs(folderToSync.FolderPath, folderToSync.RemoteName);

        // Set remote names to combobox
        var configData = RestService.For<IConfigData>("http://localhost:5572");

        try
        {
            var remoteLists = await configData.GetRemotes();
            RemoteNames = remoteLists.Remotes;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Settings_FormClosed(object sender, FormClosedEventArgs e)
    {
        Hide();
    }

    private void SelectRCloneButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK) RCloneConfigTxt.Text = openFileDialog.FileName;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var remoteNameSet = new HashSet<string>();
        var folderSyncList = _textBoxComboboxes.Select(x =>
        {
            remoteNameSet.Add(x.ComboBox.Text);

            return new FolderToSync
            {
                FolderPath = x.TextBox.Text,
                RemoteName = x.ComboBox.Text
            };
        }).ToList();

        var isSaved = ConfigUtil.Save(new AppConfig
        {
            FolderToSyncList = folderSyncList,
            RCloneExePath = RCloneConfigTxt.Text,
            RepeatSync = Convert.ToInt32(RepeatSyncTxt.Text),
            RemoteNames = remoteNameSet.ToList()
        });

        if (!isSaved) return;

        Data.AppConfig = ConfigUtil.Load();

        ShowSyncFolderTextAction?.Invoke();
        Hide();
    }

    private void RepeatSyncTxt_TextChanged(object sender, EventArgs e)
    {
    }

    private void AddMoreButton_Click(object sender, EventArgs e)
    {
        LoadInputs();
    }

    private void LoadInputs(string? selectedFolderPath = null, string? selectedRemoteName = null)
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
        label.Top += 10;

        TextBox textBox = new()
        {
            Multiline = RCloneConfigTxt.Multiline,
            Font = RCloneConfigTxt.Font,
            Size = RCloneConfigTxt.Size,
            ReadOnly = RCloneConfigTxt.ReadOnly,
            Margin = RCloneConfigTxt.Margin
        };

        textBox.Text = selectedFolderPath;

        Button button = new()
        {
            Size = SelectRCloneButton.Size,
            Text = "Select"
        };

        button.Click += (_, _) =>
        {
            if (newFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBox.Text = newFolderBrowserDialog.SelectedPath;
        };

        ComboBox combobox = new()
        {
            Font = TestCmbx.Font,
            Margin = TestCmbx.Margin,
            Size = TestCmbx.Size
        };

        foreach (var remoteName in RemoteNames) combobox.Items.Add(remoteName);

        combobox.Text = selectedRemoteName;

        flowPanel.Controls.Add(label);
        flowPanel.Controls.Add(textBox);
        flowPanel.Controls.Add(button);
        flowPanel.Controls.Add(combobox);

        _textBoxComboboxes.Add(new TextBoxCombobox
        {
            TextBox = textBox,
            ComboBox = combobox
        });
        FlowLayoutPanel.Controls.Add(flowPanel);
    }

    private void AddNewEmailButton_Click(object sender, EventArgs e)
    {
        new AddNewEmail().Show();
    }
}

public class TextBoxCombobox
{
    public TextBox TextBox { get; set; }
    public ComboBox ComboBox { get; set; }
}