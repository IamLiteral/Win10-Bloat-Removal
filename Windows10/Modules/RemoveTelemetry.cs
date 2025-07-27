using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class RemoveTelemetry
    {
        public static void Execute()
        {
            Logger.Log("▶ Starting telemetry removal process...");

            // Disable telemetry tasks
            string disableTasks = @"
Get-ScheduledTask | Where-Object {$_.TaskName -like '*Telemetry*'} | Disable-ScheduledTask
";
            Logger.Log("📅 Disabling telemetry-related scheduled tasks...");
            Logger.Log(ExecutionHelper.RunPowerShell(disableTasks));

            // Stop and disable tracking service
            string diagTrackService = @"
Get-Service DiagTrack | Stop-Service -Force
Set-Service DiagTrack -StartupType Disabled
";
            Logger.Log("🛑 Stopping and disabling 'DiagTrack' service...");
            Logger.Log(ExecutionHelper.RunPowerShell(diagTrackService));

            // Registry tweak to block telemetry
            string telemetryReg = @"
reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\DataCollection"" /v AllowTelemetry /t REG_DWORD /d 0 /f
";
            Logger.Log("🧠 Setting registry key to block telemetry data collection...");
            Logger.Log(ExecutionHelper.RunPowerShell(telemetryReg));

            // Disable more services commonly linked to telemetry
            string extraServices = @"
Stop-Service dmwappushservice -Force
Set-Service dmwappushservice -StartupType Disabled
";
            Logger.Log("🛰 Disabling 'dmwappushservice' (used for pushing telemetry)...");
            Logger.Log(ExecutionHelper.RunPowerShell(extraServices));

            Logger.Log("✅ Telemetry removal complete.\n");
        }
    }
}
