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
using System.Text.Json;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class CopyFoodIngredientsForm : Telerik.WinControls.UI.RadForm
    {
        FoodDishesForm foodDishesForm;
        FoodDishDetailsForm foodDishDetailsForm;
        FoodDish foodDish;
        FoodDishDetail foodDishDetail;
        FoodIngredient foodIngredient = new FoodIngredient();
        List<FoodIngredient> foodIngredients = new List<FoodIngredient>();
        List<Ingredient> ingredients = new List<Ingredient>();

        public CopyFoodIngredientsForm()
        {
            InitializeComponent();
        }
        public CopyFoodIngredientsForm(FoodDishesForm foodDishesForm, FoodDish foodDish)
        {
            InitializeComponent();
            this.foodDishesForm = foodDishesForm;
            this.foodDish = foodDish;
        }
        public CopyFoodIngredientsForm(FoodDishesForm foodDishesForm, FoodDishDetailsForm foodDishDetailsForm, FoodDish foodDish, FoodDishDetail foodDishDetail)
        {
            InitializeComponent();
            this.foodDishesForm = foodDishesForm;
            this.foodDishDetailsForm = foodDishDetailsForm;
            this.foodDish = foodDish;
            this.foodDishDetail = foodDishDetail;
        }


        private void FormIngredient_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadRelation();
            TranslateText();

        }

        private async void LoadRelation()
        {
            Response<List<Ingredient>> res = await HttpClientHelper.GetAsync<List<Ingredient>>("ingredients");

            GridViewComboBoxColumn categoryColumn = new GridViewComboBoxColumn("Ingredients");
            categoryColumn.HeaderText = AppLocalization.Translate("Ingredients");
            categoryColumn.DataSource = res.Data;
            categoryColumn.FieldName = "Ingredients";
            categoryColumn.DropDownStyle = RadDropDownStyle.DropDown;
            categoryColumn.ValueMember = "Id";
            categoryColumn.DisplayMember = "EnglishName";
            dgView.Columns.Add(categoryColumn);
            // Add a text box column for input values
            GridViewTextBoxColumn valueColumn = new GridViewTextBoxColumn("Usage");
            valueColumn.HeaderText = AppLocalization.Translate("Usage");
            dgView.Columns.Add(valueColumn);

            BindData();


            foreach (FoodDish fd in foodDishesForm.items)
            {
                if (fd.FoodDishDetails.Count > 0)
                {
                    foreach (FoodDishDetail fdt in fd.FoodDishDetails)
                    {
                        var item = new ListViewDataItem { 
                            Value = fdt.Id, 
                            Text =(string)fd.GetNameConcat() + " (" +(string)GeneralFunction.GetPropertyValue(fdt)+")", 
                            Tag = fdt ,
                        CheckState = foodDishDetail?.Id == fdt.Id? ToggleState.On: ToggleState.Off,
                        };
                        ckFoodDish.Items.Add(item);
                    }
                }
                else
                {
                    var item = new ListViewDataItem { 
                        Value = fd.Id, 
                        Text = (string)fd.GetNameConcat(), 
                        Tag = fd ,
                        CheckState = foodDish?.Id == fd.Id? ToggleState.On: ToggleState.Off,
                    };
                    ckFoodDish.Items.Add(item);
                }
            }
        }

        private async void BindData()
        {
            dgView.Rows.Clear();
            //Response<List<FoodIngredient>> res = await HttpClientHelper.GetAsync<List<FoodIngredient>>("food_dish/" + foodDish.Id + "/food_ingredients"+(foodDishDetail!=null?"?food_dish_detail_id="+foodDishDetail.Id:""));
            if (foodDishDetail != null)
            {
                foodIngredients = foodDishDetail.FoodIngredients;
            }
            else
            {
                foodIngredients = foodDish.FoodIngredients;
            }
            Debug.Print(JsonSerializer.Serialize(foodIngredients));
            //dgView.DataSource = res.Data;
            foreach (FoodIngredient fid in foodIngredients)
            {
                dgView.Rows.Add(fid.IngredientId, fid.Usage);
            }
        }



        private void ClearData()
        {
            foodIngredient = new FoodIngredient();
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foodIngredient = foodIngredients[e.RowIndex];
            }
        }

        //private async void btnModify_Click(object sender, EventArgs e)
        //{
        //    if (txtUsage.Text.Length > 0)
        //    {

        //        try
        //        {
        //            foodIngredient.IngredientId = (int)ddIngredient.SelectedValue;

        //            if (foodDishDetail != null)
        //            {
        //                foodIngredient.FoodDishDetailId = foodDishDetail.Id;
        //            }
        //            foodIngredient.Usage = double.TryParse(txtUsage.Text, out double ing) ? ing : 0;
        //            if (foodIngredient.Id > 0)
        //            {
        //                await HttpClientHelper.PutAsync<Ingredient>("food_dish/" + foodDish.Id + "/food_ingredients/" + foodIngredient.Id, foodIngredient);
        //            }
        //            else
        //            {
        //                await HttpClientHelper.PostAsync<Ingredient>("food_dish/" + foodDish.Id + "/food_ingredients", foodIngredient);
        //            }

        //            ClearData();
        //            BindData();
        //            MessageBox.Show("Sucessful SaveChanged");
        //        }
        //        catch (Exception)
        //        {
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("Name Cann't Empty");
        //        ClearData();
        //    }
        //}

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
            this.Text = AppLocalization.Translate(this.Text);
            //AppLocalization.TranslateGridView(dgView);
            GeneralFunction.ApplyFontToAllControls(this);
            tooltipBtnSubmit.SetToolTip(this.btnSubmit, AppLocalization.Translate("Apply to selected food dishes"));
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {

            var ingredientsData = new List<object>();

            foreach (var row in dgView.Rows)
            {
                var ingId = row.Cells["Ingredients"].Value?.ToString();
                var value = row.Cells["Usage"].Value?.ToString();

                if (!string.IsNullOrEmpty(ingId) && !string.IsNullOrEmpty(value))
                {
                    ingredientsData.Add(new {
                        ingredient_id = ingId,
                        usage = value
                    });
                }
            }


            var foodDishIds = new List<int>();
            var foodDishDetialIds = new List<int>();
            foreach (var ckItem in ckFoodDish.Items)
            {
                if (ckItem.CheckState == ToggleState.On)
                {
                    if(ckItem.Tag is FoodDish)
                    {
                        foodDishIds.Add((int)(ckItem.Tag as FoodDish).Id);
                    } else
                    {
                        foodDishDetialIds.Add((int)(ckItem.Tag as FoodDishDetail).Id);
                    }
                }
            }

            Response<List<FoodDish>> res = await HttpClientHelper.PostAsync<List<FoodDish>>("food_dish/apply_ingredients", new {
                ingredients = ingredientsData, 
                food_dish_ids=foodDishIds, 
                food_dish_detail_ids = foodDishDetialIds 
            });
            foodDishesForm.items = res.Data;

            this.Dispose();
        }

        //private async void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bool res = await HttpClientHelper.DeleteAsync("food_dish/" + foodDish.Id + "/food_ingredients/" + foodIngredient.Id);

        //        ClearData();
        //        BindData();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
    }
}
