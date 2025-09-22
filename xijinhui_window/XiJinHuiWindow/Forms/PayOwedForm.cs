using XiJinHuiWindow;
using XiJinHuiWindow.Forms.Reports;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports;
using XiJinHuiWindow.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Reports
{
    public partial class PayOwedForm : Telerik.WinControls.UI.RadForm
    {
        SaleTable saleTable;
        public PayOwedForm()
        {
            InitializeComponent();
        }
        public PayOwedForm(SaleTable saleTable)
        {
            InitializeComponent();
            this.saleTable = saleTable;
        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now;
        }

        private void ApplyTranslations()
        {
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                radLabel1, radLabel2
            });
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
                btnShow
            });
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("sale_tables/" + saleTable.Id + "/pay-owed", new
                {
                    date = dtpStart.Text,
                    amount = txtAmount.Text,
                });

                //MessageBox.Show("Payment have been make successfully.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
    }
}
