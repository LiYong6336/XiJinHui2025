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
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class StockoutItemsForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        StockItem stockItem = new StockItem();
        List<StockItem> stockItems = new List<StockItem>();
        List<Ingredient> ingredients = new List<Ingredient>();
        StockOutsForm stocksForm;
        Stock stock;

        public StockoutItemsForm(StockOutsForm stocksForm, Stock stock)
        {
            InitializeComponent();
            this.stocksForm = stocksForm;
            this.stock = stock;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.mcbIngredient.AutoFilter = true;
            this.mcbIngredient.DisplayMember = "FullName";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = "ChineseKeyword";
            filter.Operator = FilterOperator.Contains;
            this.mcbIngredient.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            LoadCombo();
            ClearData();
            BindData();
            TranslateText();
        }

        private async void LoadCombo()
        {
            try
            {
                Response<List<Ingredient>> res = await HttpClientHelper.GetAsync<List<Ingredient>>("ingredients", new Dictionary<string, string>
                {
                    //{"is_cocktail", "false" }
                });
                ingredients.Clear();
                ingredients = res.Data;
                //categories = res.Data.Categories;
                //GeneralFunction.BindCombobox<FoodDish>(ddIngredient, ingredients, "Id", (FoodDish c) => c.GetNameConcat());
                if (ingredients.Count > 0)
                {
                    mcbIngredient.DataSource = ingredients;
                    mcbIngredient.SelectedIndex = 0;
                }
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
            txtQuantity.Clear();
            txtNote.Clear();
            mcbIngredient.Focus();
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
            if (txtQuantity.Text.Length > 0 && mcbIngredient.SelectedValue!=null)
            {

                try
                {
                    stockItem.ItemId = (int)mcbIngredient.SelectedValue;
                    stockItem.Quantity = double.TryParse(txtQuantity.Text, out double up) ? up : 0;
                    stockItem.Note = txtNote.Text;

                    //if (stockItem.Id > 0)
                    //{
                    //    await HttpClientHelper.PutAsync<Category>("stocks/" + stock.Id + "/stock-items/"+stockItem.Id, stockItem);
                    //}
                    //else
                    //{
                        await HttpClientHelper.PostAsync<Category>("stocks/" + stock.Id + "/stock-items", stockItem);
                    //}

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
                MessageBox.Show("Item and Quantity Cann't Empty");
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
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblQuantity, lblNote, lblIngredient,
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
    }
}
