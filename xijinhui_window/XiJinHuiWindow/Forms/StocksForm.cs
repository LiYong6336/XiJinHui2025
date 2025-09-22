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
    public partial class StocksForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        Stock stock = new Stock();
        List<Stock> stocks = new List<Stock>();
        List<FoodDish> ingredients = new List<FoodDish>();

        public StocksForm()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCombo();
            ClearData();
            BindData();
            TranslateText();
        }

        private async void LoadCombo()
        {
            //var ls = new List<string> { "added","confused","defective","lost"};
            //foreach (string s in ls)
            //{
            //    var item = new RadListDataItem { Value = s, Text = AppLocalization.Translate(s), };
            //    ddOperation.Items.Add(item);
            //}
            //ddOperation.SelectedIndex = 0;
        }



        private async void BindData()
        {
            Response<List<Stock>> res = await HttpClientHelper.GetAsync<List<Stock>>("stocks");
            stocks = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtInvoiceNumber.Clear();
            txtReference.Clear();
            txtNote.Clear();
            stock = new Stock();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                stock = stocks[e.RowIndex];

                StockItemsForm stockItemsForm = new StockItemsForm(this, stock);
                stockItemsForm.ShowDialog();

                //txtNote.Text = stock.Note;
                //txtInvoiceNumber.Text = stock.InvoiceNumber.ToString();
                //ddOperation.SelectedValue = stock.Operation;
                //txtReference.Text = stock.Reference;
                //dtDate.Text = stock.StockDate;
                //btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtReference.Text.Length > 0)
            {

                try
                {
                    stock.InvoiceNumber = txtInvoiceNumber.Text;
                    stock.Reference = txtReference.Text;
                    stock.Note = txtNote.Text;
                    stock.Operation = (string)ddOperation.SelectedValue;
                    stock.StockDate = dtDate.Text;
                    if (stock.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Category>("stocks/" + stock.Id, stock);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<Category>("stocks", stock);
                    }

                    ClearData();
                    BindData();
                    //MessageBox.Show("Sucessful SaveChanged");
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("CODE Cann't Empty");
                ClearData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtKhmer_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchKhmerKeyboard();
        }

        private void txtKhmer_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtChinese_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtChinese_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchChineseKeyboard();
        }
        private void TranslateText()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblReference, lblDate, lblNote, lblOperation, lblDate,
            });
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("stocks/" + stock.Id);

                ClearData();
                BindData();
                MessageBox.Show(AppLocalization.Translate("Stock delete successfully"));
            }
            catch (Exception ex)
            {
            }
        }

    }
}
