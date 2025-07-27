using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveSuggestedApps
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting removal of suggested apps and common bloatware...");

            // Remove silent installed suggestions
            string disableSilentApps = @"
reg add ""HKCU\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"" /v SilentInstalledAppsEnabled /t REG_DWORD /d 0 /f
";
            Logger.Log("🧰 Disabling silent app suggestions...");
            Logger.Log(ExecutionHelper.RunPowerShell(disableSilentApps));

            // Remove general removable bloat apps
            string removeGeneralApps = @"
Get-AppxPackage | Where-Object { $_.IsFramework -eq $false -and $_.NonRemovable -eq $false } | Remove-AppxPackage
";
            Logger.Log("🧹 Removing general suggested apps...");
            Logger.Log(ExecutionHelper.RunPowerShell(removeGeneralApps));

            // Targeted list of common known bloatware packages
            string[] knownBloat = new string[]
            {
                "*Microsoft.YourPhone*",
                "*Microsoft.MicrosoftOfficeHub*",
                "*Microsoft.SkypeApp*",
                "*Microsoft.GetHelp*",
                "*Microsoft.Getstarted*",
                "*Microsoft.Microsoft3DViewer*",
                "*Microsoft.ZuneMusic*",     // Groove
                "*Microsoft.ZuneVideo*",     // Movies & TV
                "*Microsoft.People*",
                "*Microsoft.BingWeather*",
                "*Microsoft.MicrosoftSolitaireCollection*",
                "*Microsoft.MixedReality.Portal*"

            };

            foreach (var package in knownBloat)
            {
                string script = $"Get-AppxPackage {package} | Remove-AppxPackage";
                Logger.Log($"🗑 Removing package: {package}");
                string result = ExecutionHelper.RunPowerShell(script);
                Logger.Log(result);
            }

            Logger.Log("✅ Finished removing suggested apps and known bloatware.\n");
        }
    }
}
