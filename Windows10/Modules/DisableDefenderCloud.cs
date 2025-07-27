namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableDefenderCloud
    {
        public static void Execute()
        {
            string script = @"
Set-MpPreference -MAPSReporting 0
Set-MpPreference -SubmitSamplesConsent 2
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Defender cloud features disabled:\n" + result);
        }
    }
}
