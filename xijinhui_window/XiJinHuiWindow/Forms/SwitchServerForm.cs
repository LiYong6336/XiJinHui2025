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

namespace XiJinHuiWindow.Forms
{
    public partial class SwitchServerForm : Telerik.WinControls.UI.RadForm
    {
        string usingServer = "OnlineServer";
        public SwitchServerForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
            BindData();
        }

        private void BindData()
        {
            var setting = Settings.Default;
            txtOnlineServer.Text = setting.OnlineServer;
            txtLocalServer.Text = setting.LocalServer;
            if (setting.UsingServer != null && setting.UsingServer != "")
            {
                usingServer = setting.UsingServer;
            }
            CheckCorrectServer();
        }

        private void CheckCorrectServer()
        {
            if (usingServer == "OnlineServer")
            {
                rbOnlineServer.CheckState = CheckState.Checked;
                rbLocalServer.CheckState = CheckState.Unchecked;
            }
            else
            {
                rbLocalServer.CheckState = CheckState.Checked;
                rbOnlineServer.CheckState = CheckState.Unchecked;
            }
        }

        private void ApplyTranslation()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> { lblLocalServer, lblOnlineServer });
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton> { btnSave });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string onlineServer = txtOnlineServer.Text;
            string localServer = txtLocalServer.Text;

            Settings.Default.OnlineServer = onlineServer;
            Settings.Default.LocalServer = localServer;
            Settings.Default.UsingServer = usingServer;
            Settings.Default.Save();

            HttpClientHelper.Initialize(usingServer == "OnlineServer"? onlineServer: localServer);

            //this.Dispose();
            Application.Restart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbOnlineServer_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            usingServer = "OnlineServer";
            //CheckCorrectServer();
        }

        private void rbLocalServer_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            usingServer = "LocalServer";
            //CheckCorrectServer();
        }
    }
}
