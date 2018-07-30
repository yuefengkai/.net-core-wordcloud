using System.Diagnostics;
using System.IO;

public class RunCmd {
    /// <summary>
    /// 执行cmd命令
    /// </summary>
    /// <param name="cmd">命令</param>
    /// <param name="args">参数</param>
    /// <returns></returns>
    public string Run (string cmd, string args) {
        ProcessStartInfo start = new ProcessStartInfo ();
        start.FileName = "python";
        start.Arguments = string.Format ("\"{0}\" \"{1}\"", cmd, args);
        start.UseShellExecute = false;
        start.CreateNoWindow = true;
        start.RedirectStandardOutput = true;
        start.RedirectStandardError = true;
        using (Process process = Process.Start (start)) {
            using (StreamReader reader = process.StandardOutput) {
                string stderr = process.StandardError.ReadToEnd ();
                string result = reader.ReadToEnd ();
                return result;
            }
        }
    }
}