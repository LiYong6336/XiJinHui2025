using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class UpdateSaleDetailForm : Telerik.WinControls.UI.RadForm
    {
        public bool public_changed_item = false;
        public static decimal edited_price = 0;

        public SaleForm saleForm;
        public SaleTable saleTable;
        public SaleDetail saleDetail;

        private string original_qty = "";
        public UpdateSaleDetailForm()
        {
            InitializeComponent();
        }
        public UpdateSaleDetailForm(SaleForm saleForm, SaleTable saleTable, SaleDetail saleDetail)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.saleTable = saleTable;
            this.saleDetail = saleDetail;
            txtQty.Text = saleDetail.Qty.ToString();
            txtPrice.Text = saleDetail.FoodPrice.ToString();

            txtRemark.Text =String.IsNullOrEmpty(saleDetail?.Remark)? saleDetail.Remark:"";
            if (saleDetail.DiscountPercentage > 0)
            {
                txtDiscount.Text = saleDetail.DiscountPercentage.ToString();
            }
        }

        private void UpdateSaleDetailForm_Load(object sender, EventArgs e)
        {
            //txtPrice.Enabled = saleDetail.FoodDish.CanChangePrice == true || PublicVariable.User.IsAdmin == 1;
            txtPrice.Enabled = true;
            ApplyTranslations();
        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>
            {
                lblPrice, lblDiscount, lblQty, lblRemark,
            });
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton>
            {
                btnOk, btnEnter,
            });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            var ctl = (Control)sender;
            string disValue = ctl.Text.Replace("%", "");
            txtDiscount.Text = disValue;


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!saleForm.IsAdmin &&
                saleTable.PreReceiptPrintTime > 0 &&
                (
                    saleDetail.Qty > GeneralFunction.ConvertDouble(txtQty.Text) ||
                    saleDetail.FoodPrice != GeneralFunction.ConvertDouble(txtPrice.Text)
                )
            )
            {
                GenerateDeletionCodeForm generateDeletionCodeForm = new GenerateDeletionCodeForm(this);
                generateDeletionCodeForm.ShowDialog();
                return;
            }
            UpdateSaleDetail();
        }

        public async void UpdateSaleDetail(string verifyCode = null)
        {
            try
            {
                Response<SaleTable> res = await HttpClientHelper.PutAsync<SaleTable>("sale_details/" + saleDetail.Id, new
                {
                    discount_percentage = txtDiscount.Text,
                    qty = GeneralFunction.ConvertDouble(txtQty.Text),
                    food_price = txtPrice.Text,
                    code = verifyCode,
                    remark = txtRemark.Text,
                });
                saleForm.SetSaleTableResponseData(res);
                saleForm.CreateCartItems();

                this.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void atLabel1_Click(object sender, EventArgs e)
        {

            //frmChangeFoodPrice frmChangeFoodPrice = new frmChangeFoodPrice();
            //frmChangeFoodPrice.public_food_id = item_id;
            //frmChangeFoodPrice.ShowDialog();
        }

        private void txtQty_Enter(object sender, EventArgs e)
        {
            original_qty = txtQty.Text;


        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var qty = double.TryParse(txtQty.Text, out double result) ? result : 0;
            txtQty.Text = (qty + 1).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            var qty = double.TryParse(txtQty.Text, out double result) ? result : 0;
            if (qty > 0)
            {
                txtQty.Text = (qty - 1).ToString();
            }

        }
    }

}
