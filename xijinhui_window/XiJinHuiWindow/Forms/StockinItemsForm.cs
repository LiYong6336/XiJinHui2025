using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class StockinItemsForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        StockItem stockItem = new StockItem();
        List<StockItem> stockItems = new List<StockItem>();
        List<Ingredient> ingredients = new List<Ingredient>();
        StockInsForm stocksForm;
        Stock stock;
        List<Category> categories = new List<Category>();

        public StockinItemsForm(StockInsForm stocksForm, Stock stock)
        {
            InitializeComponent();
            this.stocksForm = stocksForm;
            this.stock = stock;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            btnConfirm.Visible =
            btnConfirm.Enabled =
            btnModify.Enabled =
            stock.Status == false;

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

            dtExpDate.Text = GeneralFunction.FormatStandardDate(DateTime.Now);
            dtMfpDate.Text = GeneralFunction.FormatStandardDate(DateTime.Now);
        }

        private async void LoadCombo()
        {
            //ddOperation.Items.Clear();
            //ddIngredient.Items.Clear();
            //var ls = new List<string> { "added","confused","defective","lost"};
            //foreach (string s in ls)
            //{
            //    var item = new RadListDataItem { Value = s, Text = AppLocalization.Translate(s), };
            //    ddOperation.Items.Add(item);
            //}
            //ddOperation.SelectedIndex = 0;

            try
            {
                Response<List<Ingredient>> res = await HttpClientHelper.GetAsync<List<Ingredient>>("ingredients", new Dictionary<string, string>
                {
                    //{"is_cocktail", "false" },
                    //{"with_categories", "true" },
                    //{"order_by", "id" },
                    //{"order_dir", "desc" },
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
            Response<List<StockItem>> res = await HttpClientHelper.GetAsync<List<StockItem>>("stocks/" + stock.Id + "/stock-items", new Dictionary<string, string>
            {
                { "stock_id",  ""+stock.Id}
            });
            stockItems = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            //txtPrice.Clear();
            txtQuantity.Clear();
            txtNote.Clear();
            //ddIngredient.Focus();
            stockItem = new StockItem();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && stock.Status == false)
            {
                stockItem = stockItems[e.RowIndex];

                //StockItemsForm stockItemsForm = new StockItemsForm(this, stock);

                mcbIngredient.SelectedValue = stockItem.ItemId;
                //txtPrice.Text = stock.Price.ToString();
                txtQuantity.Text = stockItem.Quantity.ToString();
                txtNote.Text = stockItem.Note;
                dtMfpDate.Text = stockItem.MfpDate.ToString();
                dtExpDate.Text = stockItem.ExpDate.ToString();

                btnDelete.Visible = true;
            }
            else
            {
                //MessageBox.Show("")
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && mcbIngredient.SelectedValue != null)
            {

                try
                {
                    stockItem.ItemId = (int)mcbIngredient.SelectedValue;
                    //stockItem.Price = double.TryParse(txtPrice.Text, out double pri) ? pri : 0;
                    stockItem.Quantity = double.TryParse(txtQuantity.Text, out double up) ? up : 0;
                    stockItem.Note = txtNote.Text;
                    stockItem.MfpDate = dtMfpDate.Text;
                    stockItem.ExpDate = dtExpDate.Text;


                    if (stockItem.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Category>("stocks/" + stock.Id + "/stock-items/" + stockItem.Id, stockItem);
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
                MessageBox.Show("Quantity Cann't Empty");
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
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblQuantity, lblNote, lblIngredient, lblMfpDate, lblExpDate,
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
                bool res = await HttpClientHelper.DeleteAsync("stocks/" + stock.Id + "/stock-items/" + stockItem.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

        //private void ddIngredient_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        //{

        //}

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            IngredientsForm foodDishCUForm = new IngredientsForm();
            foodDishCUForm.ShowDialog();
            LoadCombo();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await HttpClientHelper.PostAsync<Stock>("stocks/" + stock.Id + "/confirm", new { });

                stock = res.Data;
                btnConfirm.Visible = false;
                btnConfirm.Enabled = false;
                btnModify.Enabled = false;
                ClearData();
                BindData();
                stocksForm.BindData();
                MessageBox.Show("Stock in have been set.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
