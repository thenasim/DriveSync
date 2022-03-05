using DriveSync.ApiModels;
using Refit;

namespace DriveSync.ApiInterfaces;

public interface IConfigData
{
    [Post("/config/listremotes")]
    Task<RemoteLists> GetRemotes();
}