using DriveSync.ApiModels;
using DriveSync.Models;
using Refit;

namespace DriveSync.ApiInterfaces;

public interface IConfigData
{
    [Post("/config/listremotes")]
    Task<RemoteLists> GetRemotes();

    [Post("/config/create")]
    Task CreateRemote([Body] CreateConfigModel model);
}