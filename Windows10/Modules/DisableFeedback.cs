using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableFeedback
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting Feedback Prompt Disable...");

            string script = @"
reg add ""HKCU\Software\Microsoft\Siuf\Rules"" /v NumberOfSIUFInPeriod /t REG_DWORD /d 0 /f
reg add ""HKCU\Software\Microsoft\Siuf\Rules"" /v PeriodInDays /t REG_DWORD /d 0 /f
";

            Logger.Log("🧰 Modifying registry to suppress feedback prompts:");
            Logger.Log(" • NumberOfSIUFInPeriod = 0");
            Logger.Log(" • PeriodInDays = 0");

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("✅ Feedback prompts successfully disabled.");
                Logger.Log(result);
            }
            else
            {
                Logger.Log("⚠️ No output returned. Ensure registry access is allowed for current user.");
            }

            Logger.Log("✓ Finished Feedback Prompt Disable.\n");
        }
    }
}
