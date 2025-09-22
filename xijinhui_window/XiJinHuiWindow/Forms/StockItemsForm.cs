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
    public partial class StockItemsForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        StockItem stockItem = new StockItem();
        List<StockItem> stockItems = new List<StockItem>();
        List<FoodDish> ingredients = new List<FoodDish>();
        StocksForm stocksForm;
        Stock stock;

        public StockItemsForm(StocksForm stocksForm, Stock stock)
        {
            InitializeComponent();
            this.stocksForm = stocksForm;
            this.stock = stock;
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
            //ddOperation.Items.Clear();
            ddIngredient.Items.Clear();
            //var ls = new List<string> { "added","confused","defective","lost"};
            //foreach (string s in ls)
            //{
            //    var item = new RadListDataItem { Value = s, Text = AppLocalization.Translate(s), };
            //    ddOperation.Items.Add(item);
            //}
            //ddOperation.SelectedIndex = 0;

            try
            {
                PaginationResponse<List<FoodDish>> res = await HttpClientHelper.GetPaginateAsync<List<FoodDish>>("food_dish");
                ingredients.Clear();
                ingredients = res.Data;
                GeneralFunction.BindCombobox<FoodDish>(ddIngredient, res.Data, "Id", (FoodDish c) => c.GetNameConcat());
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.ToString());
            }

        }



        private async void BindData()
        {
            Response<List<StockItem>> res = await HttpClientHelper.GetAsync<List<StockItem>>("stocks/"+stock.Id+"/stock-items", new Dictionary<string, string>
            {
                { "stock_id",  ""+stock.Id}
            });
            stockItems = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtPrice.Clear();
            txtQuantity.Clear();
            txtNote.Clear();
            ddIngredient.Focus();
            stockItem = new StockItem();
            btnDelete.Visible = false;
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

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && ddIngredient.SelectedValue!=null)
            {

                try
                {
                    stockItem.ItemId = (int)ddIngredient.SelectedValue;
                    stockItem.Price = double.TryParse(txtPrice.Text, out double pri) ? pri : 0;
                    stockItem.Quantity = double.TryParse(txtQuantity.Text, out double up) ? up : 0;
                    stockItem.Note = txtNote.Text;
                    stockItem.MfpDate = dtMfpDate.Text;
                    stockItem.ExpDate = dtExpDate.Text;

                    if (stockItem.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Category>("stocks/" + stock.Id + "/stock-items/"+stockItem.Id, stockItem);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<Category>("stocks/" + stock.Id + "/stock-items", stockItem);
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
                lblQuantity, lblPrice, lblNote, lblIngredient, lblMfpDate, lblExpDate,
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
                bool res = await HttpClientHelper.DeleteAsync("stocks/"+stock.Id+"/stock-items/" + stockItem.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

        private void ddIngredient_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var v = ingredients[ddIngredient.SelectedIndex];
            //if (v.UnitType == "qty")
                lblQuantity.Text = AppLocalization.Translate("Quantity");
            //else 
            //    lblQuantity.Text = AppLocalization.Translate("Weight") + "(KG)";

            txtPrice.Text = v.FoodPrice.ToString();
        }
    }
}
