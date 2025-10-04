using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class DisableTypingPersonalization
    {
        public static void Execute()
        {
            Logger.Log("⌨️ Disabling typing and inking personalization features...");

            string script = @"
New-Item -Path 'HKCU:\\SOFTWARE\\Microsoft\\InputPersonalization' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\SOFTWARE\\Microsoft\\InputPersonalization' -Name 'RestrictImplicitTextCollection' -Type DWord -Value 1
Set-ItemProperty -Path 'HKCU:\\SOFTWARE\\Microsoft\\InputPersonalization' -Name 'RestrictImplicitInkCollection' -Type DWord -Value 1
New-Item -Path 'HKCU:\\SOFTWARE\\Microsoft\\InputPersonalization\\TrainedDataStore' -Force | Out-Null
Remove-Item -Path 'HKCU:\\SOFTWARE\\Microsoft\\InputPersonalization\\TrainedDataStore' -Recurse -Force -ErrorAction SilentlyContinue
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Typing personalization disabled and learned data cleared.\n");
        }
    }
}
