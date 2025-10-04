using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Debloat_Project.Windows10.Wrappers
{
    public class DebloatButton : Button
    {
        public DebloatButton(string text, EventHandler handler)
        {
            InitializeBase(text, handler);
        }

        public DebloatButton(string text, int x, int y, EventHandler handler)
        {
            InitializeBase(text, handler);
            Location = new Point(x, y);
        }

        private void InitializeBase(string text, EventHandler handler)
        {
            Text = text;
            Size = new Size(220, 44);
            MinimumSize = new Size(220, 44);
            BackColor = Color.FromArgb(52, 58, 64);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(80, 120, 200);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 110, 160);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(8, 8, 8, 12);
            Padding = new Padding(14, 0, 14, 0);
            TextAlign = ContentAlignment.MiddleLeft;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
            Click += handler;
        }
    }
}
