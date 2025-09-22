using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class DiningFloorsForm : Telerik.WinControls.UI.RadForm
    {
        DiningFloor diningFloor = new DiningFloor();
        List<DiningFloor> diningFloors = new List<DiningFloor>();

        public DiningFloorsForm()
        {
            InitializeComponent();
        }

        private void frmDiningFloor_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            TranslateText();
        }



        private async void BindData()
        {
            Response<List<DiningFloor>> res = await HttpClientHelper.GetAsync<List<DiningFloor>>("dining_floor");
            diningFloors = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtChinese.Clear();
            txtCode.Clear();
            txtEnglish.Clear();
            txtKhmer.Clear();
            txtMemo.Clear();
            txtDescription.Clear();
            txtCode.Focus();
            diningFloor = new DiningFloor();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                diningFloor = diningFloors[e.RowIndex];
                txtCode.Text = diningFloor.FloorCode;
                txtEnglish.Text = diningFloor.EnglishName;
                txtChinese.Text = diningFloor.ChineseName;
                txtKhmer.Text = diningFloor.KhmerName;
                txtMemo.Text = diningFloor.Remark;
                txtDescription.Text = diningFloor.Description;
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                try
                {
                    diningFloor.ChineseName = txtChinese.Text;
                    diningFloor.FloorCode = txtCode.Text;
                    diningFloor.EnglishName = txtEnglish.Text;
                    diningFloor.KhmerName = txtKhmer.Text;
                    diningFloor.Remark = txtMemo.Text;
                    diningFloor.Description = txtDescription.Text;
                    if (diningFloor.Id > 0)
                    {
                        Response<DiningFloor> res = await HttpClientHelper.PutAsync<DiningFloor>("dining_floor/" + diningFloor.Id, diningFloor);
                    }
                    else
                    {
                        Response<DiningFloor> res = await HttpClientHelper.PostAsync<DiningFloor>("dining_floor", diningFloor);
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
                lblCode, lblChinese, lblEnglish, lblKhmer, lblRemark, lblDescription,
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
                bool res = await HttpClientHelper.DeleteAsync("dining_floor/" + diningFloor.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
