namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveTelemetry
    {
        public static void Execute()
        {
            string script = @"
Get-ScheduledTask | Where-Object {$_.TaskName -like '*Telemetry*'} | Disable-ScheduledTask
Get-Service DiagTrack | Stop-Service -Force
Set-Service DiagTrack -StartupType Disabled
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\DataCollection"" /v AllowTelemetry /t REG_DWORD /d 0 /f
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Telemetry removed:\n" + result);
        }
    }
}
