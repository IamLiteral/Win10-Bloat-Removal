namespace Windows_Debloat_Project.Windows10.Modules
{
    public class DisableAdvertisingID
    {
        public static void Execute()
        {
            string script = @"
Set-ItemProperty -Path HKCU:\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo -Name Enabled -Value 0
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Advertising ID disabled:\n" + result);
        }
    }
}
