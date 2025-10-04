using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class DisableActivityHistory
    {
        public static void Execute()
        {
            Logger.Log("📝 Disabling activity history syncing and uploads...");

            string script = @"
New-Item -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System' -Force | Out-Null
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System' -Name 'EnableActivityFeed' -Type DWord -Value 0
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System' -Name 'PublishUserActivities' -Type DWord -Value 0
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System' -Name 'UploadUserActivities' -Type DWord -Value 0
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Activity history collection disabled.\n");
        }
    }
}
