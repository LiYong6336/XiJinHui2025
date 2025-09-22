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
    public partial class CategoriesForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        Category category = new Category();
        List<Category> categories = new List<Category>();

        public CategoriesForm()
        {
            InitializeComponent();
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
            try
            {
                Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
                Debug.WriteLine(res.Data.Count);
                GeneralFunction.BindCombobox<Printer>(cobPrinter, res.Data, "Id", (Printer c) => c.DeviceName);
                //GeneralFunction.BindCombobox(cobParent, @"SELECT  ctt_english + '-' + ctt_chinese + ' - '+ ctt_khmer 'ctt_english', ctt_id FROM dbo.CATEGORIES_TABLE ORDER BY ctt_id DESC");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.ToString());
            }
        }



        private async void BindData()
        {
            Response<List<Category>> res = await HttpClientHelper.GetAsync<List<Category>>("category");
            categories = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtChinese.Clear();
            txtCode.Clear();
            txtEnglish.Clear();
            txtKhmer.Clear();
            txtMemo.Clear();
            txtCode.Focus();
            ckIsAnimalPart.Checked = false;
            category = new Category();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                category = categories[e.RowIndex];
                txtCode.Text = category.CategoryCode;
                txtEnglish.Text = category.EnglishName;
                txtChinese.Text = category.ChineseName;
                txtKhmer.Text = category.KhmerName;
                txtMemo.Text = category.Remark;
                ckIsAnimalPart.Checked = category.IsAnimalPart;
                cobPrinter.SelectedValue = category.PrinterId;
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {

                try
                {
                    category.ChineseName = txtChinese.Text;
                    category.CategoryCode = txtCode.Text;
                    category.EnglishName = txtEnglish.Text;
                    category.KhmerName = txtKhmer.Text;
                    category.Remark = txtMemo.Text;
                    category.IsAnimalPart = ckIsAnimalPart.Checked;
                    category.PrinterId = (int)cobPrinter.SelectedValue;
                    if (category.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<Category>("category/" + category.Id, category);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<Category>("category", category);
                    }

                    LoadCombo();
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
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblCode, lblChinese, lblEnglish, lblKhmer, lblRemark, lblPrinter,
            });
            AppLocalization.TranslateObjects<RadCheckBox>(new List<RadCheckBox> {
                ckIsAnimalPart
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
                bool res = await HttpClientHelper.DeleteAsync("category/" + category.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
