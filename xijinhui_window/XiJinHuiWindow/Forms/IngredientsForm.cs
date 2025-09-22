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
    public partial class IngredientsForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        Ingredient ingredient = new Ingredient();
        List<Ingredient> ingredients = new List<Ingredient>();

        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void FormIngredient_Load(object sender, EventArgs e)
        {

            ClearData();
            BindData();
            TranslateText();
        }

        private async void BindData()
        {
            Response<List<Ingredient>> res = await HttpClientHelper.GetAsync<List<Ingredient>>("ingredients");
            ingredients = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtChinese.Clear();
            txtEnglish.Clear();
            txtKhmer.Clear();
            txtUnpackage.Clear();
            txtUnitCapacity.Clear();
            ingredient = new Ingredient();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ingredient = ingredients[e.RowIndex];
                txtEnglish.Text = ingredient.EnglishName;
                txtChinese.Text = ingredient.ChineseName;
                txtKhmer.Text = ingredient.KhmerName;
                txtUnpackage.Text = ingredient.UnPackage.ToString();
                txtUnitCapacity.Text = ingredient.UnitCapacity.ToString();
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if ((txtEnglish.Text + txtChinese.Text + txtKhmer.Text).Length > 0)
            {

                try
                {
                    ingredient.ChineseName = txtChinese.Text;
                    ingredient.EnglishName = txtEnglish.Text;
                    ingredient.KhmerName = txtKhmer.Text;
                    ingredient.UnitCapacity = GeneralFunction.ConvertDouble( txtUnitCapacity.Text);
                    ingredient.UnPackage = GeneralFunction.ConvertDouble(txtUnpackage.Text);
                    if (ingredient.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Ingredient>("ingredients/" + ingredient.Id, ingredient);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<Ingredient>("ingredients", ingredient);
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
                lblChinese, lblEnglish, lblKhmer, lblUnpackage, lblUnitCapacity
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
                bool res = await HttpClientHelper.DeleteAsync("ingredients/" + ingredient.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
