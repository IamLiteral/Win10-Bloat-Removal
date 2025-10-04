using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Windows_Debloat_Project.Windows10.Components
{
    public class GradientPanel : Panel
    {
        private Color startColor = Color.FromArgb(36, 53, 112);
        private Color endColor = Color.FromArgb(21, 26, 48);
        private float angle = 90f;

        [Category("Appearance")]
        public Color StartColor
        {
            get => startColor;
            set
            {
                startColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color EndColor
        {
            get => endColor;
            set
            {
                endColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public float Angle
        {
            get => angle;
            set
            {
                angle = value;
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Width == 0 || Height == 0)
            {
                base.OnPaintBackground(e);
                return;
            }

            using LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, startColor, endColor, angle);
            e.Graphics.FillRectangle(brush, ClientRectangle);
        }
    }
}
