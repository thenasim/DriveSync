using System.Text.Json;
using DriveSync.ApiInterfaces;
using DriveSync.Models;
using DriveSync.Service;
using DriveSync.Utils;
using Refit;

namespace DriveSync;

public partial class AddNewEmail : Form
{
    private readonly List<LabelButton> _labelButtons = new();

    public AddNewEmail()
    {
        InitializeComponent();
    }

    private async void SaveButton_Click(object sender, EventArgs e)
    {
        var configData = RestService.For<IConfigData>("http://localhost:5572");

        var inputs = new CreateConfigModel
        {
            Name = EmailAddressTxt.Text,
            Parameter = new Parameter { RootFolderId = RootFolderIdTxt.Text, Email = EmailAddressTxt.Text }
        };

        try
        {
            if (Data.AppConfig == null) return;
            if (Data.AppConfig?.FolderToSyncList == null) return;

            var rClone = new RCloneService(Data.AppConfig.RCloneExePath);
            var str = "";

            rClone.CreateConfig(JsonSerializer.Serialize(inputs), "config/create", out str);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            MessageBox.Show(JsonSerializer.Serialize(ex.Data));
        }
    }

    private async void AddNewEmail_Load(object sender, EventArgs e)
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        var configData = RestService.For<IConfigData>("http://localhost:5572");

        try
        {
            var remoteLists = await configData.GetRemotes();

            foreach (var remote in remoteLists.Remotes)
            {
                AddFlow(remote);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void AddFlow(string remoteName)
    {
        FlowLayoutPanel flowPanel = new()
        {
            Width = 550,
            Height = 52
        };

        var label = new Label()
        {
            Text = remoteName
        };
        label.Top += 20;

        Button button = new()
        {
            Size = SaveButton.Size,
            Text = "Delete",
        };

        button.Click += (_, _) =>
        {
            if (Data.AppConfig == null) return;

            var rClone = new RCloneService(Data.AppConfig.RCloneExePath);
            var str = "";

            try
            {
                rClone.DeleteConfig(remoteName, out str);

                _labelButtons.Remove(_labelButtons.Single(x => x.Label.Text == remoteName));

                MessageBox.Show("Deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        };

        _labelButtons.Add(new LabelButton()
        {
            Button = button,
            Label = label
        });

        flowPanel.Controls.Add(label);
        flowPanel.Controls.Add(button);

        flowLayoutPanel.Controls.Add(flowPanel);
    }
}

public class LabelButton
{
    public Label Label { get; set; }
    public Button Button { get; set; }
}