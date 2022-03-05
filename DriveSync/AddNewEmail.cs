using System.Text.Json;
using DriveSync.ApiInterfaces;
using DriveSync.Models;
using DriveSync.Service;
using DriveSync.Utils;
using Refit;

namespace DriveSync;

public partial class AddNewEmail : Form
{
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

/*            MessageBox.Show(JsonSerializer.Serialize(inputs));
            await configData.CreateRemote(inputs);
*/
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
}