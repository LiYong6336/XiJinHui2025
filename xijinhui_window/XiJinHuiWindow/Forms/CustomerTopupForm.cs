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
    public partial class CustomerTopupForm : Telerik.WinControls.UI.RadForm
    {
        CustomersForm customersForm;
        Customer customer;
        public CustomerTopupForm(CustomersForm customersForm, Customer customer)
        {
            InitializeComponent();
            this.customersForm = customersForm;
            this.customer = customer;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            this.Text = AppLocalization.Translate(this.Text);
            lblAmount.Text = AppLocalization.Translate("amount") + ":";
            btnLogin.Text = AppLocalization.Translate(btnLogin.Text);
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            double topupAmount = double.TryParse(txtAmount.Text, out double amt) ? amt : 0;
            if (topupAmount <= 0)
            {
                MessageBox.Show("Amount must be greater then zero");
                return;
            }
            try
            {
                Response<CustomerTopup> res = await HttpClientHelper.PostAsync<CustomerTopup>("customers/" + customer.Id+"/topup", new { amount = topupAmount });
                this.Dispose();
            }
            catch (Exception ex) { }
        }
    }
}
