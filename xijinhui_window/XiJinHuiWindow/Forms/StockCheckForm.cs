using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
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

namespace XiJinHuiWindow.Forms
{
    public partial class StockCheckForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        StockItem stockItem = new StockItem();
        //List<Warehouse> stockItems = new List<Warehouse>();

        public StockCheckForm()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now;
            ClearData();
            BindData();
            TranslateText();
        }


        private async void BindData()
        {
            //Response<List<Warehouse>> res = await HttpClientHelper.GetAsync<List<Warehouse>>("warehouses", new Dictionary<string, string>
            //{
            //    {"start_date", dtStartDate.Text },
            //    {"end_date", dtEndDate.Text },
            //});
            //stockItems = res.Data;
            //dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            stockItem = new StockItem();
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //stockItem = stockItems[e.RowIndex];

                //StockItemsForm stockItemsForm = new StockItemsForm(this, stock);

                //ddIngredient.SelectedValue = stock.IngredientId;
                //txtPrice.Text = stock.Price.ToString();
                //txtQuantity.Text = stock.Quantity.ToString();
                //txtNote.Text = stock.Note;
                //dtMfpDate.Text = stock.MfpDate.ToString();
                //dtExpDate.Text = stock.ExpDate.ToString();

                //btnDelete.Visible = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtStartDate.Text.Length > 0 && dtEndDate.Text.Length>0)
            {
                BindData();

            }
            else
            {
                MessageBox.Show("Start date and end date cann't empty");
                ClearData();
            }
        }

        private void TranslateText()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                 lblMfpDate, lblExpDate,
            });
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }
    }
}
