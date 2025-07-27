using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveOneDrive
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting OneDrive removal...");

            string script = @"
taskkill /f /im OneDrive.exe
Start-Sleep -s 1
Remove-Item -Path ""$env:SystemRoot\SysWOW64\OneDriveSetup.exe"" -Force
";

            Logger.Log("🧰 Executing PowerShell to:");
            Logger.Log(" • Kill OneDrive process");
            Logger.Log(" • Wait briefly (1 second)");
            Logger.Log(" • Delete OneDriveSetup.exe from SysWOW64");

            var result = ExecutionHelper.RunPowerShell(script);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Logger.Log("✅ OneDrive removal completed.");
                Logger.Log(result);
            }
            else
            {
                Logger.Log("⚠️ No output returned. File may already be deleted or permission denied.");
            }

            Logger.Log("✓ Finished OneDrive removal.\n");
        }
    }
}
