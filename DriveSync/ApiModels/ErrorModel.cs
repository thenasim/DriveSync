namespace DriveSync.ApiModels;

public class ErrorModel
{
    public string Error { get; set; } = string.Empty;
    public object Input { get; set; } = new { };
    public string Path { get; set; } = string.Empty;
    public int Status { get; set; }
}