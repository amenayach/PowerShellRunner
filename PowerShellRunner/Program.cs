using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace PowerShellRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentFilename = Process.GetCurrentProcess().MainModule.FileName;
            var psFile = currentFilename.Substring(0, currentFilename.Length - 4) + ".ps1";

            var fileInfo = new FileInfo(psFile);

            var argsText = args.Length > 0 ? (" " + args.Select(m => "" + m + "").Aggregate((m1, m2) => m1 + " " + m2)) : string.Empty;

            if (File.Exists(psFile))
            {
                Process.Start("powershell.exe", $@"-ExecutionPolicy Bypass -File {psFile}{argsText}");
            }
            else
            {
                Console.WriteLine($"{fileInfo.Name} not found");
            }
        }
    }
}
