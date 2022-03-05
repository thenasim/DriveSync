using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSync.Utils
{
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

        internal bool Copy(string sourceCommand, string destCommand, out string output)
        {
            var exitCode = RunCommand($"copy {sourceCommand} {destCommand}:", out output);

            return exitCode == 0;
        }
    }
}
