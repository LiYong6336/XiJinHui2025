using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class AnimalPartsForm : Telerik.WinControls.UI.RadForm
    {
        FoodDishesForm foodDishesForm;
        FoodDish foodDish;

        AnimalPart animalPart = new AnimalPart();
        List<AnimalPart> animalParts = new List<AnimalPart>();

        public AnimalPartsForm(FoodDishesForm foodDishesForm, FoodDish foodDish)
        {
            InitializeComponent();
            this.foodDishesForm = foodDishesForm;
            this.foodDish = foodDish;
            animalParts = foodDish.AnimalParts;
            //if (animalParts.Count > 0)
            //{
            //    ddType.SelectedValue = animalParts[0].Id;
            //}
        }

        private void frmPrinter_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            TranslateText();
            foreach (string k in AnimalPart.TypeNames.Keys.ToList())
            {
                string value = AnimalPart.TypeNames[k];
                ddType.Items.Add(new RadListDataItem { Text = value, Value = k });
            }
        }

        private async void BindData()
        {
            dgView.DataSource = animalParts;
        }

        private void ClearData()
        {
            txtEnglish.Clear();
            txtKhmer.Clear();
            txtChinese.Clear();
            animalPart = new AnimalPart();

            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                animalPart = animalParts[e.RowIndex];

                txtEnglish.Text = animalPart.EnglishName;
                txtChinese.Text = animalPart.ChineseName;
                txtKhmer.Text = animalPart.KhmerName;
                ddType.SelectedValue = animalPart.Type;
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (ddType.SelectedValue ==null)
            {
                MessageBox.Show("Please select type");
                return;
            }
            if (txtEnglish.Text.Length == 0)
            {

                MessageBox.Show("English Cann't Empty");
                return;
            }

            try
            {
                animalPart.EnglishName = txtEnglish.Text;
                animalPart.ChineseName = txtChinese.Text;
                animalPart.KhmerName = txtKhmer.Text;
                animalPart.Type = ddType.SelectedValue.ToString();

                Response<List<AnimalPart>> res;
                if (animalPart.Id > 0)
                {
                    res = await HttpClientHelper.PutAsync<List<AnimalPart>>($"food-dishes/{foodDish.Id}/animal-parts/" + animalPart.Id, animalPart);
                }
                else
                {
                    res = await HttpClientHelper.PostAsync<List<AnimalPart>>($"food-dishes/{foodDish.Id}/animal-parts", animalPart);
                }
                animalParts = res.Data;
                foodDish.AnimalParts = animalParts;

                ClearData();
                BindData();
                MessageBox.Show("Sucessful Save Changed");
                foodDishesForm.LoadItems();
            }
            catch (Exception)
            {
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
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblEnglish,  lblChinese, lblKhmer, lblType
            });
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateObjects<RadDropDownList>(new List<RadDropDownList> {
                ddType
            });
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync($"food-dishes/{foodDish.Id}/animal-parts/{animalPart.Id}");
                ClearData();
                BindData();
                animalParts.RemoveAt(animalParts.IndexOf(animalPart));
                foodDishesForm.LoadItems();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
