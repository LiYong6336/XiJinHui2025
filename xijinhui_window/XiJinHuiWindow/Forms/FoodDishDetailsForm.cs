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
    public partial class FoodDishDetailsForm : Telerik.WinControls.UI.RadForm
    {
        FoodDishesForm foodDishesForm;
        //object ctt_id = null;
        FoodDish foodDish;
        FoodDishDetail foodDishDetail = new FoodDishDetail();
        List<FoodDishDetail> foodDishDetails = new List<FoodDishDetail>();

        public FoodDishDetailsForm(FoodDishesForm foodDishesForm, FoodDish foodDish)
        {
            InitializeComponent();
            this.foodDish = foodDish;
            this.foodDishesForm = foodDishesForm; 
            this.Text = "Food Dish Detail: "+ foodDish.GetNameConcat();
        }

        private void frmFoodDishDetail_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            TranslateText();
        }

        private async void BindData()
        {
            Response<List<FoodDishDetail>> res = await HttpClientHelper.GetAsync<List<FoodDishDetail>>("food_dish/" + foodDish.Id + "/food_dish_detail");
            foodDishDetails = res.Data;
            dgView.DataSource = res.Data;
            //foodDishDetails = foodDish.FoodDishDetails;
            //dgView.DataSource = foodDishDetails;
        }

        private void ClearData()
        {
            txtEnglish.Clear();
            txtChinese.Clear();
            txtKhmer.Clear();
            txtPrice.Clear();
            txtEnglish.Focus();
            foodDishDetail = new FoodDishDetail();

            btnDelete.Visible = false;
            btnIngredients.Visible = false;
            btnCopyIngredients.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foodDishDetail = foodDishDetails[e.RowIndex];
                txtEnglish.Text = foodDishDetail.EnglishName;
                txtChinese.Text = foodDishDetail.ChineseName;
                txtKhmer.Text = foodDishDetail.KhmerName;
                txtPrice.Text = foodDishDetail.Price.ToString();

                btnDelete.Visible = true;
                btnIngredients.Visible = true;
                btnCopyIngredients.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if ((txtEnglish.Text.Length + txtKhmer.Text.Length + txtChinese.Text.Length) > 0)
            {

                try
                {
                    foodDishDetail.EnglishName = txtEnglish.Text;
                    foodDishDetail.ChineseName = txtChinese.Text;
                    foodDishDetail.KhmerName = txtKhmer.Text;
                    foodDishDetail.Price = double.TryParse(txtPrice.Text, out double p) ? p : 0;
                    if (foodDishDetail.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<FoodDishDetail>("food_dish/" + foodDish.Id + "/food_dish_detail/" + foodDishDetail.Id, foodDishDetail);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<FoodDishDetail>("food_dish/" + foodDish.Id + "/food_dish_detail", foodDishDetail);
                    }
                    ClearData();
                    BindData();
                    MessageBox.Show("Sucessful SaveChanged");
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Name Cann't Empty");
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
                lblEnglish, lblChinese,lblKhmer, lblPrice,
            });
            AppLocalization.TranslateGridView(dgView);
            GeneralFunction.ApplyFontToAllControls(this);

            tooltipCopyIngredient.SetToolTip(this.btnCopyIngredients, AppLocalization.Translate("Copy Ingredients"));
            tooltipBtnIngredient.SetToolTip(this.btnIngredients, AppLocalization.Translate("Ingredients"));
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("food_dish/" + foodDish.Id + "/food_dish_detail/" + foodDishDetail.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            FoodIngredientsForm frm = new FoodIngredientsForm(foodDish, foodDishDetail);
            frm.ShowDialog();
        }

        private void dgView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foodDishDetail = foodDishDetails[e.RowIndex];
                txtEnglish.Text = foodDishDetail.EnglishName;
                txtChinese.Text = foodDishDetail.ChineseName;
                txtKhmer.Text = foodDishDetail.KhmerName;
                txtPrice.Text = foodDishDetail.Price.ToString();

                btnDelete.Visible = true;
                btnIngredients.Visible = true;
                btnCopyIngredients.Visible = true;
            }
        }

        private void btnCopyIngredient_Click(object sender, EventArgs e)
        {
            CopyFoodIngredientsForm frm = new CopyFoodIngredientsForm(foodDishesForm, this, foodDish, foodDishDetail);
            frm.ShowDialog();
        }
    }
}
