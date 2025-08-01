﻿using System;
using System.IO;
using Windows_Debloat_Project.Windows10.Wrappers;

namespace Windows_Debloat_Project.Windows10.Modules
{
    public class BlockMicrosoftIPs
    {
        public static void Execute()
        {
            Logger.Log("🧱 Blocking Microsoft Telemetry IPs and Domains...\r\n");

            string[] telemetryDomains = {
                "vortex.data.microsoft.com",
                "telemetry.microsoft.com",
                "watson.telemetry.microsoft.com",
                "settings-win.data.microsoft.com"
            };

            string hosts = "C:\\Windows\\System32\\drivers\\etc\\hosts";

            try
            {
                foreach (var domain in telemetryDomains)
                {
                    string entry = $"0.0.0.0 {domain}";
                    if (!File.ReadAllText(hosts).Contains(entry))
                    {
                        File.AppendAllText(hosts, entry + Environment.NewLine);
                        Logger.Log($"✅ Added to hosts: {entry}\r\n");
                    }
                    else
                    {
                        Logger.Log($"⚠️ Already exists in hosts: {entry}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"❌ Error modifying hosts file: {ex.Message}\r\n");
            }

            string script = @"
New-NetFirewallRule -DisplayName 'Block Microsoft Telemetry' -Direction Outbound -RemoteAddress 13.107.4.50,13.107.5.88 -Action Block
";

            Logger.Log("🚀 Executing PowerShell firewall block...\r\n");

            try
            {
                var result = Windows_Debloat_Project.Windows10.Wrappers.ExecutionHelper.RunPowerShell(script);
                Logger.Log("📜 PowerShell Output:\r\n" + result + "\r\n");
                Logger.Log("✅ Firewall rule applied successfully.\r\n");
            }
            catch (Exception ex)
            {
                Logger.Log($"❌ PowerShell execution failed: {ex.Message}\r\n");
            }

            Logger.Log("🏁 Done blocking Microsoft telemetry.\r\n\r\n");
        }
    }
}
