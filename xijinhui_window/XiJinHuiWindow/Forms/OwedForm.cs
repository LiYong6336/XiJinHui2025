using XiJinHuiWindow.Forms.Reports;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class OwedForm : Telerik.WinControls.UI.RadForm
    {
        public List<Printer> printers = new List<Printer>();
        //object ctt_id = null;
        SaleTable saleTable = new SaleTable();
        List<SaleTable> saleTables = new List<SaleTable>();

        public OwedForm()
        {
            InitializeComponent();
        }

        private void frmSaleTable_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            LoadPrinters();
            TranslateText();
        }
        private async void LoadPrinters()
        {
            //Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
            //printers = res.Data;
        }

        private async void LoadData()
        {
            dgView.Rows.Clear();
            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>("sale_tables", new Dictionary<string, string>
            {
                {"is_public", "1" },
                {"start_date", dtpStart.Text },
                {"end_date", dtpEnd.Text },
                {"owed", "1" },
                {"search", txtSearch.Text },
                {"owe_status", ddStatus.Text },
            });
            saleTables = res.Data;
            dgView.DataSource = res.Data;
            if (ddStatus.Text == "owed")
            {
                foreach (var row in dgView.Rows)
                {
                    row.Cells["colExecute"].Value = "Pay Now";
                }
            }
        }

        private async void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lblStart, lblEnd,
            });
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void dgView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name == "SaleDate" && e.CellElement.Value != null)
            {
                if (DateTime.TryParse(e.CellElement.Value.ToString(), out DateTime dateValue))
                {
                    e.CellElement.Text = dateValue.ToString("yyyy-MM-dd");
                }
            }
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgView_CellClick(object sender, GridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
            {
                saleTable = saleTables[e.RowIndex];
                // column execute
                if (e.ColumnIndex == 7 && ddStatus.Text== "owed")
                {
                    PayOwedForm owedForm = new PayOwedForm(saleTable);
                    owedForm.ShowDialog();
                    LoadData();
                    //var inv = e.Row.Cells["ShowingInvoiceNumber"].Value;

                    //Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("sale_tables/" + saleTable.Id + "/update-showing-invoice-number", new
                    //{
                    //    showing_invoice_number = inv,
                    //});

                    //saleTables[e.RowIndex] = res.Data;
                    //saleTable = res.Data;

                    //dgView.Rows[e.RowIndex].Cells["ShowingInvoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
                }
            }

        }
    }
}
