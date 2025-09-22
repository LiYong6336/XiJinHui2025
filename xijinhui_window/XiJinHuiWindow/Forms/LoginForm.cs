using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Text.Json;
using System.Text.Json.Serialization;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using XiJinHuiWindow.Forms.Cashier;
using Telerik.WinControls.UI;
using System.Deployment.Application;
using System.Reflection;

namespace XiJinHuiWindow.Forms
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
            lblVersion.Text = VersionLabel();
        }

        private string VersionLabel()
        {

            return ApplicationDeployment.IsNetworkDeployed
             ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
             : Assembly.GetExecutingAssembly().GetName().Version.ToString();


        }


        private void ApplyTranslation()
        {
            lblUsername.Text = AppLocalization.Translate("username") + ":";
            lblPassword.Text = AppLocalization.Translate("password") + ":";
            lblIsAdmin.Text = AppLocalization.Translate("Login Admin");
            btnLogin.Text = AppLocalization.Translate(btnLogin.Text);
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string token = await AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(token))
            {

                if (switchAdmin.Value)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    TableForm tableForm = new TableForm();
                    tableForm.Show();
                    this.Hide();
                }
            }
            else
            {
                txtUsername.Focus();
            }
        }

        private async Task<string> AuthenticateUser(string username, string password)
        {
            int currentYear = DateTime.Now.Year;
            if(switchAdmin.Value && currentYear>2025 )
            {
                MessageBox.Show("Login fail please contact to administrator");
                return null;
            }
            var loginData = new { username = username, password = password };
            try
            {
                Response<LoginResponseData> loginResponse = await HttpClientHelper.PostAsync<LoginResponseData>(switchAdmin.Value ? "login_backend" : "login", loginData);
                HttpClientHelper.Token = loginResponse?.Data?.Token;
                Settings.Default.Token = loginResponse?.Data?.Token;
                Settings.Default.Menus = JsonSerializer.Serialize(loginResponse.Data.SettingMenu);
                Settings.Default.User = JsonSerializer.Serialize(loginResponse.Data.User);
                Settings.Default.Save();
                PublicVariable.User = loginResponse?.Data?.User;
                PublicVariable.AcessToken = loginResponse?.Data?.Token;

                Debug.WriteLine("=-=====================================");
                Debug.WriteLine(PublicVariable.User?.UserLocale);
                AppLocalization.Load(PublicVariable.User?.UserLocale??"en");
                return loginResponse?.Data?.Token;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.ToString());
                return null;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SwitchServerForm switchServerForm = new SwitchServerForm();
            switchServerForm.ShowDialog();
        }
    }


    public class LoginResponseData
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("setting_menu")]
        public List<SettingMenu> SettingMenu { get; set; }
    }
}
