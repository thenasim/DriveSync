using DriveSync.ApiModels;
using DriveSync.Models;
using Refit;

namespace DriveSync.ApiInterfaces;

public interface IConfigData
{
    [Post("/config/listremotes")]
    Task<RemoteLists> GetRemotes();

    [Post("/config/create")]
    Task CreateRemote([Body(BodySerializationMethod.Serialized)] CreateConfigModel model);

    [Post("/sync/copy")]
    Task CopyToRemote([Body(BodySerializationMethod.Serialized)] CopyModel model);
}