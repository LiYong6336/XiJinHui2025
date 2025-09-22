using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiJinHuiWindow.Toolboxes
{
    public class ShadowButton : Button
    {
        // Properties for shadow settings
        public int ShadowOffsetX { get; set; } = 0;  // Horizontal offset of the shadow
        public int ShadowOffsetY { get; set; } = 0;  // Vertical offset of the shadow
        public Color ShadowColor { get; set; } = Color.FromArgb(10, 0, 0, 0);  // Semi-transparent shadow color
        public int ShadowStrokeWidth { get; set; } = 8;  // Stroke width for larger shadow

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Graphics settings for smooth drawing
            Graphics g = pevent.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Set up fonts and brushes for drawing
            Font font = this.Font;
            Brush textBrush = new SolidBrush(this.ForeColor);
            Brush shadowBrush = new SolidBrush(ShadowColor);

            // Get the text alignment and size
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Calculate the text position and rectangle
            Rectangle rect = this.ClientRectangle;

            // Draw a bigger shadow stroke by rendering the shadow multiple times in different directions
            //for (int i = -ShadowStrokeWidth; i <= ShadowStrokeWidth; i++)
            //{
            //    for (int j = -ShadowStrokeWidth; j <= ShadowStrokeWidth; j++)
            //    {
            //        // Skip drawing in the middle (the actual text position)
            //        if (i == 0 && j == 0) continue;

            //        // Draw the shadow text with various offsets to create the larger shadow effect
            //        g.DrawString(this.Text, font, shadowBrush,
            //            new RectangleF(rect.X + ShadowOffsetX + i, rect.Y + ShadowOffsetY + j, rect.Width, rect.Height), stringFormat);
            //    }
            //}

            // Draw the actual text on top
            g.DrawString(this.Text, font, textBrush, rect, stringFormat);
        }
    }
}
