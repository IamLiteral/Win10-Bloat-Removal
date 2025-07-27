namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableFeedback
    {
        public static void Execute()
        {
            string script = @"
reg add ""HKCU\Software\Microsoft\Siuf\Rules"" /v NumberOfSIUFInPeriod /t REG_DWORD /d 0 /f
reg add ""HKCU\Software\Microsoft\Siuf\Rules"" /v PeriodInDays /t REG_DWORD /d 0 /f
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Feedback prompts disabled:\n" + result);
        }
    }
}
