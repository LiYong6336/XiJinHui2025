using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiJinHuiWindow.Utils
{
    internal class RoundClass
    {
        #region Round Form
        private Form frm;
        private Control[] ctr = new Control[20];
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn
        (
         int nLeftRect, // x-coordinate of upper-left corner
         int nTopRect, // y-coordinate of upper-left corner
         int nRightRect, // x-coordinate of lower-right corner
         int nBottomRect, // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);

        public RoundClass(Form _form)
        {
            frm = _form;
            _form.Paint += new PaintEventHandler(form_Paint);
        }
        public RoundClass(params Control[] _ctr)
        {
            for (int i = 0; i < _ctr.Length; i++)
            {
                ctr[i] = _ctr[i];
                ctr[i].Paint += new PaintEventHandler(_ctr_Paint);

            }

        }
        public void Round(params Control[] _ctr)
        {
            for (int i = 0; i < _ctr.Length; i++)
            {
                ctr[i] = _ctr[i];
                ctr[i].Paint += new PaintEventHandler(_ctr_Paint);

            }

        }

        //========= Event Control Round ==================
        private void form_Paint(object sender, PaintEventArgs e)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, frm.Width, frm.Height, 5, 5); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            frm.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);

        }
        private void _ctr_Paint(object sender, PaintEventArgs e)
        {
            Control c = (Control)sender;
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, c.Width, c.Height, 20, 20); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            c.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }
        //========= End Event Control Round ===============
        #endregion

        enum states
        {
            normal,
            focused,
            disabled,
        }
        Rectangle MainRect;
        Pen BorderPen;
        states state = states.normal;
        private void TekenRondeRechthoek(Graphics g, Pen pen, Rectangle rectangle, float radius)
        {
            float size = (radius * 2);
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90);
            gp.AddArc((rectangle.X
                            + (rectangle.Width - size)), rectangle.Y, size, size, 270, 90);
            gp.AddArc((rectangle.X
                            + (rectangle.Width - size)), (rectangle.Y
                            + (rectangle.Height - size)), size, size, 0, 90);
            gp.AddArc(rectangle.X, (rectangle.Y
                            + (rectangle.Height - size)), size, size, 90, 90);
            gp.CloseFigure();
            g.DrawPath(pen, gp);
            gp.Dispose();
        }

        public void DrawBorder(Graphics g, TextBox txt)
        {
            MainRect = new Rectangle(0, 0, (txt.Width - 1), (txt.Height - 1));
            switch (state)
            {
                case states.focused:
                    BorderPen = new Pen(Color.Blue);
                    break;
                case states.disabled:
                    BorderPen = new Pen(Color.DarkGray);
                    break;
                case states.normal:
                    BorderPen = new Pen(Color.DimGray);
                    break;
                default:
                    return;
            }
            TekenRondeRechthoek(g, BorderPen, MainRect, 1);
        }
    }
}
