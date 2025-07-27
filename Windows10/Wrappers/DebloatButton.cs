using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Debloat_Project.Windows10.Wrappers
{
    public class DebloatButton : Button
    {
        public DebloatButton(string text, int x, int y, EventHandler handler)
        {
            this.Text = text;
            this.Location = new Point(x, y);
            this.Size = new Size(260, 32);
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Click += handler;
        }
    }
}
