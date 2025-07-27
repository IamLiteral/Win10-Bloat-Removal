namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveSuggestedApps
    {
        public static void Execute()
        {
            string script = @"
Get-AppxPackage | Where-Object { $_.IsFramework -eq $false -and $_.NonRemovable -eq $false } | Remove-AppxPackage
reg add ""HKCU\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"" /v SilentInstalledAppsEnabled /t REG_DWORD /d 0 /f
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Suggested apps and preloads removed:\n" + result);
        }
    }
}
