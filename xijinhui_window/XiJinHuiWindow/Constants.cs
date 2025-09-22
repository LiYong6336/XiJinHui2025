using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiJinHuiWindow
{
    public static class Constants
    {

        //public static Color SidebarBackgroundColor = Color.White;
        //public static Color SidebarForegroundColor = Color.Black.Lighten(.4f);
        //public static Color HeaderBackgroundColor = Color.White ;
        //public static Color HeaderForegroundColor = Color.Black.Lighten(.4f);

        public static Color SidebarBackgroundColor = Color.FromArgb(0, 0, 40);
        public static Color SidebarForegroundColor = Color.DarkGray;
        public static Color SidebarMenuActiveColor = Color.FromArgb(0, 102, 204);
        public static Color HeaderBackgroundColor = Color.FromArgb(0, 102, 204);
        public static Color HeaderForegroundColor = Color.WhiteSmoke;

        public static string ApiUrl = "http://127.0.0.1:8000";
        //public static string ApiUrl = "http://192.168.1.250:8085";
    }
}
