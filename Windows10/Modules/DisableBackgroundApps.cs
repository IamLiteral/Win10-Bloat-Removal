using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class DisableBackgroundApps
    {
        public static void Execute()
        {
            Logger.Log("🌙 Disabling background apps from running automatically...");

            string script = @"
New-Item -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications' -Name 'GlobalUserDisabled' -Type DWord -Value 1
New-Item -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\AppPrivacy' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\AppPrivacy' -Name 'LetAppsRunInBackground' -Type DWord -Value 2
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Background apps disabled for the current user.\n");
        }
    }
}
