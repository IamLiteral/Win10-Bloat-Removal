using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class DisableLocationTracking
    {
        public static void Execute()
        {
            Logger.Log("📍 Turning off OS-level location tracking...");

            string script = @"
New-Item -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors' -Force | Out-Null
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors' -Name 'DisableLocation' -Type DWord -Value 1
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors' -Name 'DisableWindowsLocationProvider' -Type DWord -Value 1
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors' -Name 'DisableLocationScripting' -Type DWord -Value 1
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Location tracking disabled.\n");
        }
    }
}
