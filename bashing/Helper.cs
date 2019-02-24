using System.Diagnostics;

namespace bashing
{
    public static class Helper
    {
        public static string Bashing(this string command)
        {
            //var espchars = command.Replace("\"", "\\\"");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "curl", Arguments = $"/-X \"POST\" \"{command}\"", RedirectStandardOutput = true,
                    UseShellExecute = false, CreateNoWindow = true
                }
            };
            process.Start();
            var result = process.StandardOutput.ReadToEnd();
            return result;
        }
    }
}