using System.Windows.Forms;

namespace Windows_Debloat_Project
{
    public static class Logger
    {
        public static TextBox LogBox;

        public static void Log(string message)
        {
            if (LogBox != null)
            {
                if (LogBox.Text == "Activity log will appear here.")
                {
                    LogBox.Clear();
                }

                LogBox.AppendText(message);
                LogBox.SelectionStart = LogBox.Text.Length;
                LogBox.ScrollToCaret();
            }
        }
    }
}
