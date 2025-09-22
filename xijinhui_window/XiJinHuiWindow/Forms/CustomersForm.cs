using XiJinHuiWindow.Forms;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using XiJinHuiWindow.Utils.TelerikCustom;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class CustomersForm : RadForm
    {
        private List<Customer> items = new List<Customer>();
        private Customer item = new Customer();
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            //gridItems.BestFitColumns(BestFitColumnMode.DisplayedDataCells);
          
            TranslateTexts();
        }

        public async void LoadItems()
        {
            try
            {
                items.Clear();
                Response<List<Customer>> res = await HttpClientHelper.GetAsync<List<Customer>>("customers");
                items = res.Data;
                gridItems.DataSource = res.Data;
                gridItems.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void TranslateTexts()
        {
            this.Text = AppLocalization.Translate("customers");
            AppLocalization.TranslateGridView(gridItems);
            GeneralFunction.ApplyFontToAllControls(this);
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton> { btnTopup });
        }

 
        private void gridItems_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];
                btnDelete.Visible = true;
                btnTopup.Visible = true;
            }
        }

        private void gridItems_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];

                CustomerCUForm frm = new CustomerCUForm(this);
                frm.SetFormData(item);
                frm.ShowDialog();
                LoadItems();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerCUForm frm = new CustomerCUForm(this);
            frm.ShowDialog();
            LoadItems();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("customers/" + item.Id);
                item = new Customer();
                btnDelete.Visible = false;
                btnTopup.Visible = false;
                LoadItems();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnTopup_Click(object sender, EventArgs e)
        {
            CustomerTopupForm frm = new CustomerTopupForm(this, item);
            frm.ShowDialog();
            LoadItems();
        }
    }
}
