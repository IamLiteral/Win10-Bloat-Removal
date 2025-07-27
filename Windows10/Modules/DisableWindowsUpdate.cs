using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableWindowsUpdate
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting Windows Update Disable...");

            string script = @"
Stop-Service wuauserv -Force
Set-Service wuauserv -StartupType Disabled
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU"" /v NoAutoUpdate /t REG_DWORD /d 1 /f
";

            Logger.Log("🧰 Executing PowerShell to:");
            Logger.Log(" • Stop Windows Update service");
            Logger.Log(" • Disable it from startup");
            Logger.Log(" • Set NoAutoUpdate = 1 in registry");

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("✅ Windows Update successfully disabled.");
                Logger.Log(result);
            }
            else
            {
                Logger.Log("⚠️ No output returned. Ensure administrative privileges are granted.");
            }

            Logger.Log("✓ Finished Windows Update Disable.\n");
        }
    }
}
