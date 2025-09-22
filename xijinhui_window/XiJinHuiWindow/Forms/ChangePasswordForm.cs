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
    public partial class ChangePasswordForm : Telerik.WinControls.UI.RadForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> { lblNewPassword, lblCurrentPassword, lblConfirmNewPassword });
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton> { btnSave });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Response<ChangePasswordResponse> res = await HttpClientHelper.PostAsync<ChangePasswordResponse>("change_password", new
                {
                    current_password = txtCurrentPassword.Text,
                    new_password = txtNewPassword.Text,
                    confirm_new_password = txtConfirmNewPassword.Text,
                });
                MessageBox.Show("Your password have been changed.");
                this.Dispose();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            //this.Dispose();
        }

    }

}
