using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class DiscountAllForm : Telerik.WinControls.UI.RadForm
    {

        private SaleForm saleForm;
        private SaleTable saleTable;

        public DiscountAllForm()
        {
            InitializeComponent();
        }
        public DiscountAllForm(SaleForm saleForm, SaleTable saleTable)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.saleTable = saleTable;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnDis_Click(object sender, EventArgs e)
        {
            var ctl = (Control)sender;
            string disValue = ctl.Text.Replace("%", "");
            Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("discountSale", new
            {
                sale_table_id = saleTable.Id,
                discount_percentage = disValue,
            });
            saleForm.SetSaleTableResponseData(res);
            saleForm.CreateCartItems();

            this.Dispose();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }
    }
}
