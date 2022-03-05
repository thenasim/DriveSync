using System.Text.Json.Serialization;

namespace DriveSync.Models;

public class CopyModel
{
    [JsonPropertyName("srcFs")] public string? Source { get; set; }
    [JsonPropertyName("dstFs")] public string? Destination { get; set; }
}