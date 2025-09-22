using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class GenerateDeletionCodeForm : Telerik.WinControls.UI.RadForm
    {

        private UpdateSaleDetailForm updateSaleDetailForm;

        public GenerateDeletionCodeForm()
        {
            InitializeComponent();
        }

        public GenerateDeletionCodeForm(UpdateSaleDetailForm updateSaleDetailForm)
        {
            InitializeComponent();
            this.updateSaleDetailForm = updateSaleDetailForm;
        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<IconButton>(new List<IconButton>
            {
            });
            GeneralFunction.ApplyFontToAllControls(this);

        }

        private void InvoiceSettingForm_Load(object sender, EventArgs e)
        {
            ApplyTranslations();
        }

        private async void btnGenerateCode_Click(object sender, EventArgs e)
        {
            Response<string> res = await HttpClientHelper.PostAsync<string>("generateDeletionCodeForSaleDetail", new
            {
                sale_detail_id = updateSaleDetailForm.saleDetail.Id,
            });
            txtGeneratedCode.Text = res.Data.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtGeneratedCode.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtVerifyCode.Text == "")
            {
                MessageBox.Show("Please enter the verify code.");
                return;
            }

                        updateSaleDetailForm.UpdateSaleDetail(txtVerifyCode.Text);
                  }
    }
}
