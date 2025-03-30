using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI.Resources
{
    internal class GradientPanel : Panel  
    {
        public Color TopColor { get; set; } = Color.White;
        public Color BottomColor { get; set; } = Color.Blue;
        public float Angle { get; set; } = 90f; 

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
