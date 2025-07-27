namespace Windows_Debloat_Project.Windows10.Wrappers;


public static class ExecutionHelper

{
    public static string RunPowerShell(string script)
    {
        using var process = new System.Diagnostics.Process();
        process.StartInfo.FileName = "powershell.exe";
        process.StartInfo.Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"";
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
        return process.StandardOutput.ReadToEnd();
    }
}
