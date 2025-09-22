using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace XiJinHuiWindow
{
    public static class ColorExtensions
    {
        public static Color Darken(this Color color, float factor)
        {
            // Clamp the factor to be between 0 and 1
            factor = Math.Max(0, Math.Min(1, factor));

            // Calculate the darkened color
            int r = (int)(color.R * (1 - factor));
            int g = (int)(color.G * (1 - factor));
            int b = (int)(color.B * (1 - factor));

            return Color.FromArgb(color.A, r, g, b);
        }
        public static Color Lighten(this Color color, float factor)
        {
            // Clamp the factor to be between 0 and 1
            factor = Math.Max(0, Math.Min(1, factor));

            // Calculate the lightened color
            int r = (int)(color.R + (255 - color.R) * factor);
            int g = (int)(color.G + (255 - color.G) * factor);
            int b = (int)(color.B + (255 - color.B) * factor);

            // Ensure the values are within the 0-255 range
            r = Math.Min(255, r);
            g = Math.Min(255, g);
            b = Math.Min(255, b);

            return Color.FromArgb(color.A, r, g, b);
        }
    }
}
