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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class ChooseFoodDishDetailForm : Telerik.WinControls.UI.RadForm
    {
        private SaleForm saleForm;
        private FoodDish foodDish;
        public ChooseFoodDishDetailForm()
        {
            InitializeComponent();
        }

        public ChooseFoodDishDetailForm(SaleForm saleForm, FoodDish foodDish)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.foodDish = foodDish;
        }
        private void ChooseFoodDishDetailForm_Load(object sender, EventArgs e)
        {
            gdDishDetails.DataSource = foodDish.FoodDishDetails;
            gdDishDetails.Columns["Price"].FormatString = "{0:N2}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private async void gdDishDetails_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
             FoodDishDetail fdd = foodDish.FoodDishDetails[gdDishDetails.CurrentRow.Index];

            //List<SaleDetail> sDetails = saleForm.saleDetails.Where(s => s.FoodDish.Id == foodDish.Id && s.FoodDishDetail.Id == fdd.Id).ToList();
            //if (sDetails.Count > 0)
            //{
            //    SaleDetail sDetail = sDetails[0];
            //    saleForm.ChangeQty(sDetail, sDetail.Qty + 1);
            //}
            //else
            //{
            Response<SaleTable> res1 = await HttpClientHelper.PostAsync<SaleTable>("addSaleDetail", new
            {
                food_dish_id = foodDish.Id,
                food_dish_detail_id = fdd.Id,
                sale_table_id = saleForm.saleTable.Id,
                dining_table_id = saleForm.saleTable.DiningTableId,
            });

            saleForm.SetSaleTableResponseData(res1);
            saleForm.CreateCartItems();
            //}

            this.Dispose();

        }
    }
}
