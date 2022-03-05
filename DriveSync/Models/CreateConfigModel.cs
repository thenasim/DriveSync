using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DriveSync.Models
{
    public class CreateConfigModel
    {
        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
        [JsonPropertyName("type")] public string Type => "drive";

        [JsonPropertyName("parameters")] public Parameter? Parameter { get; set; }
    }

    public class Parameter
    {
        [JsonPropertyName("root_folder_id")] public string RootFolderId { get; set; } = string.Empty;
        [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
    }
}
