using System.IO;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class BlockMicrosoftIPs
    {
        public static void Execute()
        {
            string[] telemetryDomains = {
                "vortex.data.microsoft.com",
                "telemetry.microsoft.com",
                "watson.telemetry.microsoft.com",
                "settings-win.data.microsoft.com"
            };

            var hosts = "C:\\Windows\\System32\\drivers\\etc\\hosts";
            foreach (var domain in telemetryDomains)
            {
                File.AppendAllText(hosts, $"0.0.0.0 {domain}\n");
            }

            string script = @"
New-NetFirewallRule -DisplayName 'Block Microsoft Telemetry' -Direction Outbound -RemoteAddress 13.107.4.50,13.107.5.88 -Action Block
";
            var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
            Console.WriteLine("Telemetry IPs/domains blocked:\n" + result);
        }
    }
}
