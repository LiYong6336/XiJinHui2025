using System;
using System.Diagnostics;
using System.Drawing;
using XiJinHuiWindow.Models;

namespace XiJinHuiWindow.Utils
{
    public class PublicVariable
    {
        public static string BaseUrl = "http://localhost:8000/api/v1/";
        public static string AcessToken { get; set; }
        public static User User { get; set; }
        public static string UserPassword { get; set; }
        public static string UserLoginType = "0";
        public static string UserLoginPayment = "0";
        public static string UserLoginMenu = "0";

        public static string LanguageField()
        {
            switch ((string)User.UserLocale)
            {
                case "en":
                    return "EnglishName";
                case "zh":
                    return "ChineseName";
                default:
                    return "KhmerName";
            }
        }

        public static Font fontStyleByLanguage(float fontSize = 12F)
        {
            switch ((string)User?.UserLocale)
            {
                case "en":
                    return new System.Drawing.Font("HarmonyOS Sans", fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                case "zh":
                    return new System.Drawing.Font("HarmonyOS Sans SC Light", fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                default:
                    return new System.Drawing.Font("Battambang", fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

       
    }
}
