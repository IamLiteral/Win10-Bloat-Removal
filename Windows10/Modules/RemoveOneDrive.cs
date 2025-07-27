namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveOneDrive
    {
        public static void Execute()
        {
            string script = @"
taskkill /f /im OneDrive.exe
Start-Sleep -s 1
Remove-Item -Path ""$env:SystemRoot\SysWOW64\OneDriveSetup.exe"" -Force
";
            
            var result = Wrappers.ExecutionHelper.RunPowerShell(script);  
            Console.WriteLine("OneDrive removed:\n" + result);
        }
    }
}
