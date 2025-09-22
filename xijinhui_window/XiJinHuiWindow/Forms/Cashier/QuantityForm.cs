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
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class QuantityForm : RadForm
    {
        public decimal quantity=0;
        public decimal remark = 1;
        string input = string.Empty;
        string input_QTY = string.Empty;
        private SaleForm saleForm;
        private SaleTable saleTable;
        private FoodDish foodDish;

        public int? headId;
        public int? tailId;
        public int? wholeId;
        public int? mixId;

        public static string typeString = "";

        public QuantityForm(SaleForm saleForm,SaleTable saleTable,FoodDish foodDish)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.saleTable = saleTable;
            this.foodDish = foodDish; 
        }

       
        private void btnNumber_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            btn.Focus();

            input += btn.Text;
            txtKg.Text=input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKg.Text = "";
            input = txtKg.Text;
        }
        public async void btnEnter_Click(object sender, EventArgs e)
        {
            quantity = (decimal)GeneralFunction.ConvertNumber(txtKg.Text);
            remark = (decimal)GeneralFunction.ConvertNumber(txtRemark.Text);

            try
            {
                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("addSaleDetail", new
                {
                    food_dish_id = foodDish.Id,
                    sale_table_id = saleTable.Id,
                    dining_table_id = saleTable.DiningTableId,

                    head_id = headId,
                    tail_id = tailId,
                    whole_id = wholeId,
                    mix_id = mixId,
                    remark = "Qty: "+ remark,
                    qty = quantity,
                });
                saleForm.SetSaleTableResponseData(res);
                saleForm.CreateCartItems();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            this.Close();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtKg.Text.Length>0)
            {
                txtKg.Text = txtKg.Text.Substring(0, txtKg.Text.Length - 1);
                input = txtKg.Text;
            }
            else
            {
                txtKg.Text = "1";
                input = txtKg.Text;
            }
        }

        private void btnMultiChoice_Click(object sender, EventArgs e)
        {
            quantity = (decimal)GeneralFunction.ConvertNumber(txtKg.Text);
            remark = (decimal)GeneralFunction.ConvertNumber(txtRemark.Text);
            ChooseAnimalPartsForm frm = new ChooseAnimalPartsForm(saleForm, this, saleTable,foodDish);
            frm.ShowDialog();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            //frmHead frm = new frmHead();
            //frm.ShowDialog();

        }

        private void b1_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        void getQTY(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            btn.Focus();


            input_QTY += btn.Text;
            txtRemark.Text = input_QTY;
        }
        private void bdot_Click(object sender, EventArgs e)
        {
            getQTY(sender, e);
        }

        private void bc_Click(object sender, EventArgs e)
        {
            txtRemark.Text = "";
            input_QTY = txtRemark.Text;
        }

        private void frmAdjust_Load(object sender, EventArgs e)
        {
            if (typeString == "SEAFOOD2")
	        {
                btnMultiChoice.Visible = false;
	        }
        }
    }
}
