namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableCortana
    {
        public static void Execute()
        {
            string script = @"
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\Windows Search"" /v AllowCortana /t REG_DWORD /d 0 /f
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Cortana disabled:\n" + result);
        }
    }
}
