using Windows_Debloat_Project.Windows10.Wrappers;


namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableCortana
    {
        public static void Execute()
        {
            Logger.Log("Disabling Cortana...");

            string script = @"
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\Windows Search"" /v AllowCortana /t REG_DWORD /d 0 /f
";

            string result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("PowerShell Response:");
                Logger.Log(result.Trim());
            }
            else
            {
                Logger.Log("Cortana disabled successfully.");
            }
        }
    }
}
