using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public static class DisableTailoredExperiences
    {
        public static void Execute()
        {
            Logger.Log("🎯 Disabling tailored experiences and consumer features...");

            string script = @"
New-Item -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\CloudContent' -Force | Out-Null
Set-ItemProperty -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\CloudContent' -Name 'DisableTailoredExperiencesWithDiagnosticData' -Type DWord -Value 1
Set-ItemProperty -Path 'HKCU:\\Software\\Policies\\Microsoft\\Windows\\CloudContent' -Name 'DisableSoftLanding' -Type DWord -Value 1
Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent' -Name 'DisableWindowsConsumerFeatures' -Type DWord -Value 1
";

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log(result);
            }

            Logger.Log("✅ Tailored experiences disabled.\n");
        }
    }
}
