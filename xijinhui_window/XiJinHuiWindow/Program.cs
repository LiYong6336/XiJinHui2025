using XiJinHuiWindow.Forms;
using XiJinHuiWindow.Properties;
using XiJinHuiWindow.Utils;
using System;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Forms.Cashier;

namespace XiJinHuiWindow
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
   
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm());

            // Initialize HttpClientHelper with the base URL
            //HttpClientHelper.Initialize(Constants.ApiUrl);
            if (!string.IsNullOrEmpty(Settings.Default.UsingServer))
            {
                HttpClientHelper.Initialize(Settings.Default.UsingServer == "OnlineServer" ? Settings.Default.OnlineServer : Settings.Default.LocalServer);
            }
            else
            {
                HttpClientHelper.Initialize(Constants.ApiUrl);
            }

            // Optionally, set a token if it is already available
            if (!string.IsNullOrEmpty(Settings.Default.Token))
            {
                HttpClientHelper.Token = Settings.Default.Token;
            }
            if (!string.IsNullOrEmpty(Settings.Default.User))
            {
                PublicVariable.User = JsonSerializer.Deserialize<User>(Settings.Default.User);
                AppLocalization.Load(PublicVariable.User?.UserLocale??"en");
            }

            //Application.Run(new TableForm());
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            return;

            if (!IsUserLoggedIn())
            {
                Application.Run(new LoginForm());
            }
            else
            {
               Application.Run(new MainForm());
            }

            //Application.Run(new LoginForm());
        }

        private static bool IsUserLoggedIn()
{
    return !string.IsNullOrEmpty(Settings.Default.Token);
}

    }
}