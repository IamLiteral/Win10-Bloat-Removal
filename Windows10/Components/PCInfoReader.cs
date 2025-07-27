using System;
using System.Management;
using System.Text;

namespace Windows_Debloat_Project.Windows10.Components
{
    public static class PCInfoReader
    {
        public static string GetFullPCInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("📊 PC Check Report\n");

            sb.AppendLine($"🧠 CPU: {GetWMI("Win32_Processor", "Name")}");
            sb.AppendLine($"🎮 GPU: {GetWMI("Win32_VideoController", "Name")}");
            sb.AppendLine($"🏠 Motherboard: {GetWMI("Win32_BaseBoard", "Product")}");
            sb.AppendLine($"🏷️ Manufacturer: {GetWMI("Win32_ComputerSystem", "Manufacturer")}");
            sb.AppendLine($"📌 Model: {GetWMI("Win32_ComputerSystem", "Model")}");
            sb.AppendLine($"💾 RAM: {Math.Round(GetPhysicalRAM(), 1)} GB");
            sb.AppendLine($"💽 OS: {GetWMI("Win32_OperatingSystem", "Caption")}");

            return sb.ToString();
        }

        private static string GetWMI(string className, string property)
        {
            try
            {
                using var searcher = new ManagementObjectSearcher($"SELECT {property} FROM {className}");
                foreach (var o in searcher.Get())
                {
                    return o[property]?.ToString() ?? "Unknown";
                }
            }
            catch { }
            return "Unknown";
        }

        private static double GetPhysicalRAM()
        {
            double total = 0;
            using var searcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
            foreach (var o in searcher.Get())
            {
                double cap = Convert.ToDouble(o["Capacity"]);
                total += cap;
            }
            return total / (1024 * 1024 * 1024);
        }
    }
}
