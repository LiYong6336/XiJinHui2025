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
using XiJinHuiWindow.Utils;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using System.Diagnostics;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class DiscountCategoryForm : RadForm
    {

        private SaleForm saleForm;
        private SaleTable saleTable;
        private Category category;
        private string discount = "0";

        public DiscountCategoryForm()
        {
            InitializeComponent();
        }
        public DiscountCategoryForm(SaleForm saleForm, SaleTable saleTable)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.saleTable = saleTable;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            CreateCategoryButtons();
        }

        private void CreateCategoryButtons()
        {
            foreach (Category menu in saleForm.categories)
            {
                if (menu.Id > 0)
                {
                    var item = new ListViewDataItem { Value = menu.Id, Text = menu.GetNameConcat(" - "), Tag = menu };
                    cklCategory.Items.Add(item);
                }
            }
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            category = btn.Tag as Category;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            var ctl = (Control)sender;
            string disValue = ctl.Text.Replace("%", "");
            discount = disValue;

        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            List<int?> catIds = new List<int?>();
            foreach (var ckItem in cklCategory.Items)
            {
                if (ckItem.CheckState == ToggleState.On)
                {
                    catIds.Add((ckItem.Tag as Category).Id);
                }
            }
            if (catIds.Count == 0)
            {
                MessageBox.Show("Please select a category");
                return;
            }

            Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("discountSaleDetailByCategory", new
            {
                sale_table_id = saleTable.Id,
                discount_percentage = discount,
                category_ids = catIds,
            });
            saleForm.SetSaleTableResponseData(res);
            saleForm.CreateCartItems();

            this.Dispose();
        }
    }
}
