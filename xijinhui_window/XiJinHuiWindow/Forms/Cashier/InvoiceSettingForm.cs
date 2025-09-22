using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class InvoiceSettingForm : Telerik.WinControls.UI.RadForm
    {

        private SaleForm saleForm;

        public InvoiceSettingForm()
        {
            InitializeComponent();
        }

        public InvoiceSettingForm(SaleForm saleForm)
        {
            InitializeComponent();
            this.saleForm = saleForm;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountAllForm discountAllForm = new DiscountAllForm(saleForm, saleForm.saleTable);
            discountAllForm.ShowDialog();
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {

                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>($"sale_tables/{saleForm.saleTable.Id}/cancel", new { });
                MessageBox.Show("Sale table have been canceled.");
                this.Dispose();
                saleForm.CloseForm();
            }
            catch (Exception ex) {
            }
        }

        private void btnSplitInvoice_Click(object sender, EventArgs e)
        {
            SpliteTableForm frm = new SpliteTableForm(saleForm);
            frm.ShowDialog();
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            ChangeTableForm frm = new ChangeTableForm(saleForm, this);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<IconButton>(new List<IconButton>
            {
                btnDiscount, btnSplitInvoice, btnChangeTable, btnCancel, btnDiscountCategory
            });
            GeneralFunction.ApplyFontToAllControls(this);

        }

        private void InvoiceSettingForm_Load(object sender, EventArgs e)
        {
            ApplyTranslations();
        }

        private void btnDiscountCategory_Click(object sender, EventArgs e)
        {
            DiscountCategoryForm discountCategoryForm = new DiscountCategoryForm(saleForm, saleForm.saleTable);
            discountCategoryForm.ShowDialog();
        }
    }
}
