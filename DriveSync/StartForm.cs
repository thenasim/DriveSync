using System.Text.Json;
using DriveSync.ApiInterfaces;
using DriveSync.Models;
using DriveSync.Utils;
using Microsoft.Extensions.Logging;

namespace DriveSync;

public partial class StartForm : Form
{
    private readonly IConfigData _configData;
    private readonly ILogger<StartForm> _logger;
    private bool _cancelSync;

    public StartForm(ILogger<StartForm> logger, IConfigData configData)
    {
        _logger = logger;
        _configData = configData;
        InitializeComponent();
        _logger.LogInformation("App Started");
    }

    internal void ShowSettingsInfo()
    {
        RepeatSyncLabel.Text = $"{Data.AppConfig?.RepeatSync.ToString()}ms";
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

    private void SetLastSynced()
    {
        LastSyncedLabel.Text = DateTime.Now.ToLongTimeString();
    }

    private void SetNextSynced(double timeDelay)
    {
        NextSyncLabel.Text = DateTime.Now.AddMilliseconds(timeDelay).ToLongTimeString();
    }

    private async void SyncButton_Click(object sender, EventArgs e)
    {
        _cancelSync = false;

        if (Data.AppConfig == null) return;
        if (Data.AppConfig?.FolderToSyncList == null) return;

        var timeDelay = Data.AppConfig.RepeatSync ?? 5000;
        var rClone = new RCloneService(Data.AppConfig.RCloneExePath);
        var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(timeDelay));

        do
        {
            var folderSyncList = Data.AppConfig.FolderToSyncList;
            var errorFolders = new List<FolderToSync>();

            // Sync Button show syncing
            SyncButton.Text = "Syncing";
            SyncButton.Enabled = false;
            CancelButton.Visible = false;

            foreach (var toSync in folderSyncList)
            {
                CurrentlySyncingLabel.Text = toSync.FolderPath;
                CurrentRemoteLabel.Text = toSync.RemoteName;

                var isCopied = rClone.Copy(toSync.FolderPath, toSync.RemoteName, out _);

                if (isCopied == false) errorFolders.Add(toSync);

                SetLastSynced();
                SetNextSynced(timeDelay);
            }

            // Sync Button text reset
            SyncButton.Text = "Sync";
            SyncButton.Enabled = true;
            CancelButton.Visible = true;

            // Show message is notification
            var message = errorFolders.Count == 0
                ? "Successfully synced all the folders."
                : "Error occurred while syncing.";
            MessageBox.Show(message);

            // Show errors is message box
            foreach (var errorFolder in errorFolders)
                MessageBox.Show($"Failed to sync '{errorFolder.FolderPath}'", "Error occurred while syncing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            errorFolders.Clear();
        } while (await timer.WaitForNextTickAsync() && _cancelSync == false);
    }

    private async void CancelButton_Click(object sender, EventArgs e)
    {
        try
        {
            var data = await _configData.GetRemotes();

            MessageBox.Show(JsonSerializer.Serialize(data.Remotes));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        return;
        _cancelSync = !_cancelSync;
        CancelButton.Text = _cancelSync ? "Cancelled" : "Cancel";
    }
}