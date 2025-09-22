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
    public partial class FoodIngredientsForm : Telerik.WinControls.UI.RadForm
    {
        FoodDish foodDish;
        FoodDishDetail foodDishDetail;
        FoodIngredient foodIngredient = new FoodIngredient();
        List<FoodIngredient> foodIngredients = new List<FoodIngredient>();
        List<Ingredient> ingredients = new List<Ingredient>();

        public FoodIngredientsForm()
        {
            InitializeComponent();
        }
        public FoodIngredientsForm(FoodDish foodDish)
        {
            InitializeComponent();
            this.foodDish = foodDish;
        }
        public FoodIngredientsForm(FoodDish foodDish, FoodDishDetail foodDishDetail)
        {
            InitializeComponent();
            this.foodDish = foodDish;
            this.foodDishDetail = foodDishDetail;
        }


        private void FormIngredient_Load(object sender, EventArgs e)
        {
            this.mcbIngredient.AutoFilter = true;
            this.mcbIngredient.DisplayMember = "FullName";
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = "ChineseKeyword";
            filter.Operator = FilterOperator.Contains;
            this.mcbIngredient.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

            ClearData();
            LoadRelation();
            BindData();
            TranslateText();
        }

        private async void LoadRelation()
        {
            try
            {
                Response<List<Ingredient>> res = await HttpClientHelper.GetAsync<List<Ingredient>>("ingredients", new Dictionary<string, string>
                {
                });
                ingredients.Clear();
                ingredients = res.Data;
                if (ingredients.Count > 0)
                {
                    mcbIngredient.DataSource = ingredients;
                    mcbIngredient.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                //
            }
        }

        private async void BindData()
        {
            Response<List<FoodIngredient>> res = await HttpClientHelper.GetAsync<List<FoodIngredient>>("food_dish/" + foodDish.Id + "/food_ingredients"+(foodDishDetail!=null?"?food_dish_detail_id="+foodDishDetail.Id:""));
            foodIngredients = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtUsage.Clear();
            foodIngredient = new FoodIngredient();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foodIngredient = foodIngredients[e.RowIndex];
                mcbIngredient.SelectedValue = foodIngredient.IngredientId;
                txtUsage.Text = foodIngredient.Usage.ToString();
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtUsage.Text.Length > 0)
            {

                try
                {
                    foodIngredient.IngredientId = (int)mcbIngredient.SelectedValue;

                    if (foodDishDetail != null)
                    {
                        foodIngredient.FoodDishDetailId = foodDishDetail.Id;
                    }
                    foodIngredient.Usage = double.TryParse(txtUsage.Text, out double ing) ? ing : 0;
                    if (foodIngredient.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Ingredient>("food_dish/" + foodDish.Id + "/food_ingredients/" + foodIngredient.Id, foodIngredient);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<Ingredient>("food_dish/" + foodDish.Id + "/food_ingredients", foodIngredient);
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

        private void TranslateText()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                 lblIngredient, lblUsage
            });
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("food_dish/" + foodDish.Id + "/food_ingredients/" + foodIngredient.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
