using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class ConfigureWindowsUpdate
    {
        public static void Execute()
        {
            Logger.Log("▶ Applying safer Windows Update configuration...");

            string script = @"
New-Item -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate' -Force | Out-Null
New-Item -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU' -Force | Out-Null
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU' -Name 'NoAutoUpdate' -Type DWord -Value 0
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU' -Name 'AUOptions' -Type DWord -Value 2
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate' -Name 'DoNotConnectToWindowsUpdateInternetLocations' -Type DWord -Value 0
Set-Service -Name wuauserv -StartupType Automatic
if ((Get-Service -Name wuauserv).Status -ne 'Running') { Start-Service -Name wuauserv }
";

            Logger.Log("🛠 Setting Windows Update to notify before downloading and ensuring the service stays available...");
            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Windows Update is now configured to notify before downloading.\n");
        }
    }
}
