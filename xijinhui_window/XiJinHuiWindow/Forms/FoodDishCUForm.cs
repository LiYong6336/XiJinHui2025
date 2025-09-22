using XiJinHuiWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XiJinHuiWindow.Models.Responses;
using System.Diagnostics;
using XiJinHuiWindow.Utils;
using XiJinHuiWindow.Models.Requests;

namespace XiJinHuiWindow.Forms
{
    public partial class FoodDishCUForm : Telerik.WinControls.UI.RadForm
    {
        private FoodDishesForm foodDishesForm;
        public FoodDish foodDish;
        public List<DiningFloor> diningFloors;
        private List<Category> categories;

        private string foodPhotoPath;
        public FoodDishCUForm( FoodDishesForm dtForm, List<Category> categories)
        {
            InitializeComponent();
            foodDishesForm = dtForm;
            foodDish = new FoodDish();
            this.categories = categories;

        }

        private void FoodDishCUForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
            foreach (Category cat in categories)
            {
                dropdownCategory.Items.Add(new RadListDataItem { Text = cat.GetNameConcat(" - "), Value = cat.Id });
            }
            dropdownCategory.SelectedValue = foodDish.CategoryId;
        }
        

        public async void SetFormData(FoodDish dt)
        {
            foodDish = dt;
            txtCode.Text = dt.FoodCode;
            txtEnglishName.Text = dt.EnglishName;
            txtChineseName.Text = dt.ChineseName;
            txtKhmerName.Text = dt.KhmerName;
            txtEnglishKeyword.Text = dt.EnglishKeyword;
            txtChineseKeyword.Text = dt.ChineseKeyword;
            txtKhmerKeyword.Text = dt.KhmerKeyword;
            txtRemark.Text = dt.Remark;
            txtDescription.Text = dt.Description;
            txtPrice.Text = dt.FoodPrice.ToString();
            txtDisplayOrder.Text = dt.DisplayOrder.ToString();
            cbIsEnable.Checked = dt.IsEnable == true;

            if (!string.IsNullOrEmpty(dt.FoodPhoto))
            {
                Image img = await GeneralFunction.LoadImageFromUrlAsync(dt.FoodPhotoUrl);
                pictureBox.Image = img;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            foodDish.FoodCode = txtCode.Text;
            foodDish.EnglishName = txtEnglishName.Text;
            foodDish.ChineseName = txtChineseName.Text;
            foodDish.KhmerName = txtKhmerName.Text;
            foodDish.EnglishKeyword = txtEnglishKeyword.Text;
            foodDish.ChineseKeyword = txtChineseKeyword.Text;
            foodDish.KhmerKeyword = txtKhmerKeyword.Text;
            foodDish.Description = txtDescription.Text;
            foodDish.FoodPrice = double.TryParse( txtPrice.Text, out double mtc) ? mtc : 0;
            foodDish.Remark = txtRemark.Text;
            foodDish.IsEnable = cbIsEnable.Checked == true;
            foodDish.DisplayOrder = int.TryParse(txtDisplayOrder.Text, out int dorder) ? dorder: 1;
            if (dropdownCategory.SelectedIndex >= 0)
            {
                foodDish.CategoryId = (int)dropdownCategory.SelectedValue;
            }

            List<FileField> files = new List<FileField>();
            if (!string.IsNullOrEmpty(foodPhotoPath))
            {
                files.Add(new FileField { FieldName="food_photo_upload", FilePath=foodPhotoPath });
            }

            try
            { 
                Response<FoodDish> res;
                if(foodDish.Id > 0)
                {
                    res= await HttpClientHelper.PutAsync<FoodDish>("food_dish/"+ foodDish.Id, foodDish, files);
                } else
                {
                    res = await HttpClientHelper.PostAsync<FoodDish>("food_dish", foodDish, files);
                }
                foodDishesForm.LoadItems();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplyTranslation()
        {
            this.Text = AppLocalization.Translate(this.foodDish.Id>0? "update_food_dish": "create_food_dish");
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>
            {
                lblCode, lblChinese, lblEnglish, lblKhmer, lblDescription, lblRemark,
                lblCategory, lblDisplayOrder, lblPrice,
                lblEnglishKeyword, lblChineseKeyword, lblKhmerKeyword,
            });
            AppLocalization.TranslateObjects<RadCheckBox>(new List<RadCheckBox>
            {
                cbIsEnable
            });
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton>
            {
                btnSubmit
            });
            btnPickImage.Text = AppLocalization.Translate("PickImage");
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void btnPickImage_Click(object sender, EventArgs e)
        {
            using (RadOpenFileDialog openFileDialog = new RadOpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(filePath);
                    foodPhotoPath = filePath;
                }
            }
        }

        private void txtKhmerName_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtKhmerName_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchKhmerKeyboard();
        }

        private void txtChineseName_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();

        }

        private void txtChineseName_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchChineseKeyboard();
        }
    }
}
