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
using System.Windows.Controls;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class FoodDishesForm : RadForm
    {
        public List<FoodDish> items = new List<FoodDish>();
        private List<Category> categories = new List<Category>();
        private FoodDish item = new FoodDish();
        public FoodDishesForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            //gridItems.BestFitColumns(BestFitColumnMode.DisplayedDataCells);
            GridViewImageUrlColumn imageColumn = new GridViewImageUrlColumn
            {
                HeaderText = "Photo",
                FieldName = "FoodPhotoUrl",
                Name = "FoodPhotoUrl",
                Width = 50
            };

            gridItems.Columns.Insert(0, imageColumn);

            TranslateTexts();
        }

        public async void LoadItems()
        {
            try
            {
                gridItems.DataSource = null;
                items.Clear();
                Response<FoodDishesResponse> res = await HttpClientHelper.GetAsync<FoodDishesResponse>("food_dish", new Dictionary<string, string>
                {
                    {"with_categories", "true" },
                    {"search", txtSearch.Text },
                    {"order_by", "created_at" },
                    {"order_dir", "desc" },
                });
                categories = res.Data.Categories;
                foreach (FoodDish food in res.Data.FoodDishes)
                {
                    food.CategoryName = food.Category.EnglishName;
                    items.Add(food);
                }
                gridItems.DataSource = items;
                gridItems.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        private void TranslateTexts()
        {
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateGridView(gridItems);
            GeneralFunction.ApplyFontToAllControls(this);
            tooltipCopyIngredient.SetToolTip(this.btnCopyIngredients, AppLocalization.Translate("Copy Ingredients"));
            tooltipBtnIngredient.SetToolTip(this.btnIngredients, AppLocalization.Translate("Ingredients"));
        }


        private void gridItems_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];
                btnDelete.Visible = true;
                btnShowDetail.Visible = true;
                if (item.FoodDishDetails == null || item.FoodDishDetails.Count == 0)
                {
                    btnIngredients.Visible = true;
                    btnCopyIngredients.Visible = true;
                }
                else
                {
                    btnIngredients.Visible = false;
                    btnCopyIngredients.Visible = false;

                }
            }
        }

        private void gridItems_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];

                FoodDishCUForm frm = new FoodDishCUForm(this, categories);
                frm.SetFormData(item);
                frm.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FoodDishCUForm frm = new FoodDishCUForm(this, categories);
            frm.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("food_dish/" + item.Id);
                item = new FoodDish();
                btnDelete.Visible = false;
                btnShowDetail.Visible = false;
                btnIngredients.Visible = false;
                btnCopyIngredients.Visible = false;
                LoadItems();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if (item.Category.IsAnimalPart)
            {
                AnimalPartsForm frm = new AnimalPartsForm(this, item);
                frm.ShowDialog();
            }
            else
            {
                FoodDishDetailsForm frm = new FoodDishDetailsForm(this, item);
                frm.ShowDialog(this);
            }
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            FoodIngredientsForm frm = new FoodIngredientsForm(item);
            frm.ShowDialog();
        }

        private void btnCopyIngredients_Click(object sender, EventArgs e)
        {
            CopyFoodIngredientsForm frm = new CopyFoodIngredientsForm(this, item);
            frm.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadItems();
        }
    }
}
