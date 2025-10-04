using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class HardenSearchExperience
    {
        public static void Execute()
        {
            Logger.Log("🔍 Removing Bing integration from Start menu search...");

            string script = @"
New-Item -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\Explorer' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\Explorer' -Name 'DisableSearchBoxSuggestions' -Type DWord -Value 1
New-Item -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Search' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Search' -Name 'BingSearchEnabled' -Type DWord -Value 0
Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Search' -Name 'CortanaConsent' -Type DWord -Value 0
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Start menu search now uses local results only.\n");
        }
    }
}
