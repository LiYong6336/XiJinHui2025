using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiJinHuiWindow.Toolboxes
{
    public class DoubleBufferedPanel : Panel
    {
        //public DoubleBufferedPanel()
        //{
        //    // Enable double buffering to reduce flickering
        //    this.DoubleBuffered = true;
        //    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        //    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        //    this.SetStyle(ControlStyles.UserPaint, true);
        //    this.UpdateStyles();
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;  // WS_EX_COMPOSITED to reduce flickering
        //        return cp;
        //    }
        //}
    }
}
