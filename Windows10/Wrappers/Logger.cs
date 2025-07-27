using System;
using System.Windows.Forms;

namespace Windows_Debloat_Project.Windows10.Wrappers
{
    public static class Logger
    {
        public static TextBox LogBox { get; set; }

        public static void Log(string message)
        {
            if (LogBox == null) return;

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            LogBox.Invoke((MethodInvoker)(() =>
            {
                LogBox.AppendText($"[{timestamp}] {message}{Environment.NewLine}");
            }));
        }
    }
}
