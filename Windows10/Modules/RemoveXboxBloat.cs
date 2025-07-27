using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveXboxBloat
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting Xbox bloatware removal...");

            string script = @"
$XboxPackages = @(
    '*xboxapp*',
    '*Microsoft.XboxGameOverlay*',
    '*Microsoft.XboxGamingOverlay*',
    '*Microsoft.XboxIdentityProvider*',
    '*Microsoft.XboxSpeechToTextOverlay*',
    '*Microsoft.GamingApp*',
    '*Microsoft.Xbox.TCUI*',
    '*Microsoft.XboxGameCallableUI*',
    '*Microsoft.Xbox.*'
)

foreach ($pkg in $XboxPackages) {
    Get-AppxPackage -Name $pkg | Remove-AppxPackage -ErrorAction SilentlyContinue
    Get-AppxProvisionedPackage -Online | Where-Object { $_.DisplayName -like $pkg } | Remove-AppxProvisionedPackage -Online -ErrorAction SilentlyContinue
}
";

            Logger.Log("🎮 Removing all Xbox-related packages and provisioned packages...");
            var result = ExecutionHelper.RunPowerShell(script);
            Logger.Log(result);

            Logger.Log("✅ Xbox bloatware removal completed.\n");
        }
    }
}
