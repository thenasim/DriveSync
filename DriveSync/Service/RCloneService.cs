using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;

namespace DriveSync.Service;

internal class RCloneService
{
    private readonly string _path;

    public RCloneService(string path)
    {
        _path = path;
    }

    private int RunCommand(string arguments, out string output)
    {
        var process = new Process();
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        process.StartInfo.FileName = _path;
        process.StartInfo.Arguments = arguments;

        process.Start();

        output = process.StandardOutput.ReadToEnd();

        process.Kill();

        return process.ExitCode;
    }

    internal bool IsValidRClone(out string output)
    {
        var exitCode = RunCommand("version", out output);

        return exitCode == 0;
    }

    internal bool Check(string sourceCommand, string destCommand, out string output)
    {
        var exitCode = RunCommand($"check {sourceCommand} {destCommand}: --one-way", out output);

        return exitCode == 0;
    }

    internal bool CreateConfig(string jsonString, string command, out string output)
    {
        jsonString = jsonString.Replace("\"", "\\\"");

        var exitCode = RunCommand($"rc --json {jsonString} {command}", out output);

        return exitCode == 0;
    }

    internal bool DeleteConfig(string remoteName, out string output)
    {
        var exitCode = RunCommand($"config delete {remoteName}", out output);

        return exitCode == 0;
    }

    internal bool Copy(string sourceCommand, string destCommand, out string output)
    {
        var exitCode = RunCommand($"copy {sourceCommand} {destCommand}:", out output);

        return exitCode == 0;
    }
}