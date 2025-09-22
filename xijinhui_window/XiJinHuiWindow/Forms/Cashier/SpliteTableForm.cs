using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class SpliteTableForm : Telerik.WinControls.UI.RadForm
    {
       // string st_new_menu = "";
       // string st_new_qty = "";
        List<SaleDetail> saleDetails1;
        List<SaleDetail> saleDetails2 = new List<SaleDetail>();

        private SaleForm saleForm;
        public SpliteTableForm()
        {
            InitializeComponent();
        }

        public SpliteTableForm(SaleForm saleForm)
        {
            InitializeComponent();
            this.saleForm = saleForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SpliteTableForm_Load(object sender, EventArgs e)
        {
            saleDetails1 =saleForm.saleDetails;
            dgvInvoice1.DataSource = saleDetails1;

        }

        private void btnDgv1Up_Click(object sender, EventArgs e)
        {
            if (dgvInvoice1.SelectedRows[0].Index > 0)
            {
                int prevIndex = dgvInvoice1.CurrentRow.Index - 1;
                dgvInvoice1.CurrentRow = dgvInvoice1.Rows[prevIndex];
            }
        }

        private void btnDgv1Down_Click(object sender, EventArgs e)
        {
            if (dgvInvoice1.SelectedRows[0].Index < dgvInvoice1.Rows.Count - 1)
            {
                int prevIndex = dgvInvoice1.CurrentRow.Index + 1;
                dgvInvoice1.CurrentRow = dgvInvoice1.Rows[prevIndex];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int idx1 = dgvInvoice1.CurrentRow.Index;

            // Remove the current data sources
            dgvInvoice1.DataSource = null;
            dgvInvoice2.DataSource = null;

            // Get the current SaleDetail from saleDetails1
            SaleDetail sDetail1 = saleDetails1[idx1];

            // Find matching SaleDetail in saleDetails2
            List<SaleDetail> sDetails2 = saleDetails2.Where(sd => sd.Id == sDetail1.Id).ToList();

            if (sDetails2.Count > 0)
            {
                // SaleDetail exists in saleDetails2, update quantities
                SaleDetail sDetail2 = sDetails2[0];
                int idx2 = saleDetails2.IndexOf(sDetail2);

                double transferQty = Math.Min(1.0,  sDetail1.Qty??0);
                sDetail1.Qty -= transferQty;
                sDetail2.Qty += transferQty;

                // Remove the item if Qty reaches 0
                if (sDetail1.Qty <= 0)
                {
                    saleDetails1.RemoveAt(idx1);
                }
            }
            else
            {
                // SaleDetail does not exist in saleDetails2, add it
                SaleDetail sd = JsonSerializer.Deserialize<SaleDetail>(JsonSerializer.Serialize(sDetail1));
                sd.Qty = 0;
                saleDetails2.Add(sd);

                SaleDetail sDetail2 = saleDetails2.Last();
                double transferQty = Math.Min(1.0, sDetail1.Qty ??0);

                // Update quantities
                sDetail1.Qty -= transferQty;
                sDetail2.Qty += transferQty;

                // Remove the item if Qty reaches 0
                if (sDetail1.Qty <= 0)
                {
                    saleDetails1.RemoveAt(idx1);
                }
            }

            // Rebind data sources
            dgvInvoice1.DataSource = saleDetails1;
            dgvInvoice2.DataSource = saleDetails2;

            // Refresh the DataGridViews
            dgvInvoice1.Update();
            dgvInvoice2.Update();
            dgvInvoice1.Refresh();
            dgvInvoice2.Refresh();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            int idx2 = dgvInvoice2.CurrentRow.Index;

            // Remove the current data sources
            dgvInvoice1.DataSource = null;
            dgvInvoice2.DataSource = null;

            // Get the current SaleDetail from saleDetails1
            SaleDetail sDetail2 = saleDetails2[idx2];

            // Find matching SaleDetail in saleDetails2
            List<SaleDetail> sDetails1 = saleDetails1.Where(sd => sd.Id == sDetail2.Id).ToList();

            if (sDetails1.Count > 0)
            {
                // SaleDetail exists in saleDetails2, update quantities
                SaleDetail sDetail1 = sDetails1[0];
                int idx1 = saleDetails1.IndexOf(sDetail1);

                double transferQty = Math.Min(1.0,  sDetail2.Qty??0);
                sDetail2.Qty -= transferQty;
                sDetail1.Qty += transferQty;

                // Remove the item if Qty reaches 0
                if (sDetail2.Qty <= 0)
                {
                    saleDetails2.RemoveAt(idx2);
                }
            }
            else
            {
                // SaleDetail does not exist in saleDetails2, add it
                SaleDetail sd = JsonSerializer.Deserialize<SaleDetail>(JsonSerializer.Serialize(sDetail2));
                sd.Qty = 0;
                saleDetails1.Add(sd);

                SaleDetail sDetail1 = saleDetails1.Last();
                double transferQty = Math.Min(1.0, sDetail2.Qty ??0);

                // Update quantities
                sDetail2.Qty -= transferQty;
                sDetail1.Qty += transferQty;

                // Remove the item if Qty reaches 0
                if (sDetail2.Qty <= 0)
                {
                    saleDetails2.RemoveAt(idx2);
                }
            }

            // Rebind data sources
            dgvInvoice2.DataSource = saleDetails2;
            dgvInvoice1.DataSource = saleDetails1;

            // Refresh the DataGridViews
            dgvInvoice1.Update();
            dgvInvoice2.Update();
            dgvInvoice1.Refresh();
            dgvInvoice2.Refresh();
        }

        private void btnDgv2Up_Click(object sender, EventArgs e)
        {
            if (dgvInvoice2.SelectedRows[0].Index > 0)
            {
                int prevIndex = dgvInvoice2.CurrentRow.Index - 1;
                dgvInvoice2.CurrentRow = dgvInvoice2.Rows[prevIndex];
            }
        }

        private void btnDgv2Down_Click(object sender, EventArgs e)
        {
            if (dgvInvoice2.SelectedRows[0].Index < dgvInvoice2.Rows.Count - 1)
            {
                int prevIndex = dgvInvoice2.CurrentRow.Index + 1;
                dgvInvoice2.CurrentRow = dgvInvoice2.Rows[prevIndex];
            }
        }

        private void dgvInvoice1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoice1.SelectedRows.Count < 1)
            {
                //dgvInvoice1.CurrentRow = dgvInvoice1.Rows[0];
            }
        }

        private void dgvInvoice2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoice2.SelectedRows.Count < 1)
            {
                //dgvInvoice2.CurrentRow = dgvInvoice2.Rows[0];
            }
        }

        private void dgvInvoice1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            foreach(SaleDetail sd in saleDetails2)
            {
                list.Add(new
                {
                    id = sd.Id,
                    qty = sd.Qty,
                });
            }
            Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("split_table", new
            {
                sale_table_id = saleForm.saleTable.Id,
                new_details = list,
            });
            saleForm.SetSaleTableResponseData(res);
            saleForm.CreateCartItems();
            saleForm.tableForm.LoadDiningTables();

            this.Dispose();
        }

        private void pnSale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
