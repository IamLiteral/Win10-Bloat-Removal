namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableWindowsUpdate
    {
        public static void Execute()
        {
            string script = @"
Stop-Service wuauserv -Force
Set-Service wuauserv -StartupType Disabled
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU"" /v NoAutoUpdate /t REG_DWORD /d 1 /f
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Windows Update disabled:\n" + result);
        }
    }
}
