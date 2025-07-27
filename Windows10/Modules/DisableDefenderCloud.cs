using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableDefenderCloud
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting Defender Cloud Disable...");

            string script = @"
Set-MpPreference -MAPSReporting 0
Set-MpPreference -SubmitSamplesConsent 2
";

            Logger.Log("🛡️ Executing PowerShell commands:");
            Logger.Log(" • Set-MpPreference -MAPSReporting 0");
            Logger.Log(" • Set-MpPreference -SubmitSamplesConsent 2");

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("✅ Defender cloud features disabled successfully.");
                Logger.Log(result);
            }
            else
            {
                Logger.Log("⚠️ No output returned. Check if Defender is installed or if execution policy blocked it.");
            }

            Logger.Log("✓ Finished Defender Cloud Disable.\n");
        }
    }
}
