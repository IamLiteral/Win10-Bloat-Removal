using Windows_Debloat_Project.Windows10.Wrappers;


namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableAdvertisingID
    {
        public static void Execute()
        {
            Logger.Log("Disabling Advertising ID...");

            string script = @"
Set-ItemProperty -Path HKCU:\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo -Name Enabled -Value 0
";

            string result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("PowerShell Response:");
                Logger.Log(result.Trim());
            }
            else
            {
                Logger.Log("Advertising ID disabled successfully.");
            }
        }
    }
}
