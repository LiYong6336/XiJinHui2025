using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports.Cashier;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class TaxDeclarationForm : Telerik.WinControls.UI.RadForm
    {
        public List<Printer> printers = new List<Printer>();
        //object ctt_id = null;
        SaleTable saleTable = new SaleTable();
        List<SaleTable> saleTables = new List<SaleTable>();

        public TaxDeclarationForm()
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
            Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
            printers = res.Data;
        }

        private async void LoadData()
        {
            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>("sale_tables", new Dictionary<string, string>
            {
                {"is_public", "1" },
                {"start_date", dtpStart.Text },
                {"end_date", dtpEnd.Text },
            });
            saleTables = res.Data;
            dgView.DataSource = res.Data;
            foreach (var row in dgView.Rows)
            {
                row.Cells["colExecute"].Value = "Execute";
                row.Cells["colPrint"].Value = "Print";
            }
        }

        private async void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                saleTable = saleTables[e.RowIndex];
                // column execute
                if (e.ColumnIndex == 5)
                {
                    var inv = e.Row.Cells["ShowingInvoiceNumber"].Value;

                    Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("sale_tables/" + saleTable.Id + "/update-showing-invoice-number", new
                    {
                        showing_invoice_number = inv,
                    });

                    saleTables[e.RowIndex] = res.Data;
                    saleTable = res.Data;

                    dgView.Rows[e.RowIndex].Cells["ShowingInvoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
                }
                if (e.ColumnIndex == 6)
                {
                    if (printers.Count == 0)
                    {
                        MessageBox.Show("No printer found");
                        return;
                    }
                    ReportInvoice rpt = new ReportInvoice();
                    rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
                    rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
                    rpt.ReportParameters["invoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
                    rpt.ReportParameters["saleDate"].Value = saleTable.SaleDate.Split(' ')[0];
                    rpt.ReportParameters["totalAmount"].Value = saleTable.TotalAmount;
                    rpt.ReportParameters["discountAmount"].Value = saleTable.DiscountAmount;
                    rpt.ReportParameters["discountPercentage"].Value = saleTable.DiscountPercentage;
                    rpt.ReportParameters["roomServiceAmount"].Value = saleTable.RoomServiceAmount;
                    rpt.ReportParameters["taxAmount"].Value = saleTable.TaxAmount;

                    rpt.ReportParameters["grandTotal"].Value = Convert.ToDecimal(saleTable.GrandTotal).ToString("N2");
                    rpt.ReportParameters["grandTotalRiel"].Value = Convert.ToDecimal((saleTable.GrandTotal ?? 0) * (saleTable.ExchangeRate ?? 0)).ToString("N2");
                    rpt.ReportParameters["received"].Value = Convert.ToDecimal(saleTable.ReceivedDollar + (saleTable.ReceivedRiel / saleTable.ExchangeRate)).ToString("N2");
                    rpt.ReportParameters["returnDollar"].Value = Convert.ToDecimal(saleTable.ReturnDollars + (saleTable.ReturnRiels / saleTable.ExchangeRate)).ToString("N2");
                    rpt.ReportParameters["returnRiel"].Value = Convert.ToDecimal((saleTable.ReturnDollars * saleTable.ExchangeRate) + saleTable.ReturnRiels).ToString("N2");
                    rpt.DataSource = saleTable.SaleDetails;

                    GeneralFunction.PrintReporting(rpt, printers[0].DeviceName);
                }
            }
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

        private void dgView_Click(object sender, EventArgs e)
        {

        }

        private async void dgView_CellClick(object sender, GridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                saleTable = saleTables[e.RowIndex];
                // column execute
                if (e.ColumnIndex == 5)
                {
                    var inv = e.Row.Cells["ShowingInvoiceNumber"].Value;

                    Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("sale_tables/" + saleTable.Id + "/update-showing-invoice-number", new
                    {
                        showing_invoice_number = inv,
                    });

                    saleTables[e.RowIndex] = res.Data;
                    saleTable = res.Data;

                    dgView.Rows[e.RowIndex].Cells["ShowingInvoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
                }
                if (e.ColumnIndex == 6)
                {
                    if (printers.Count == 0)
                    {
                        MessageBox.Show("No printer found");
                        return;
                    }
                    ReportInvoice rpt = new ReportInvoice();
                    rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
                    rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
                    rpt.ReportParameters["invoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
                    rpt.ReportParameters["saleDate"].Value = saleTable.SaleDate.Split(' ')[0];
                    rpt.ReportParameters["totalAmount"].Value = saleTable.TotalAmount;
                    rpt.ReportParameters["discountAmount"].Value = saleTable.DiscountAmount;
                    rpt.ReportParameters["discountPercentage"].Value = saleTable.DiscountPercentage;
                    rpt.ReportParameters["roomServiceAmount"].Value = saleTable.RoomServiceAmount;
                    rpt.ReportParameters["taxAmount"].Value = saleTable.TaxAmount;

                    rpt.ReportParameters["grandTotal"].Value = Convert.ToDecimal(saleTable.GrandTotal).ToString("N2");
                    rpt.ReportParameters["grandTotalRiel"].Value = Convert.ToDecimal((saleTable.GrandTotal ?? 0) * (saleTable.ExchangeRate ?? 0)).ToString("N2");
                    rpt.ReportParameters["received"].Value = Convert.ToDecimal(saleTable.ReceivedDollar + (saleTable.ReceivedRiel / saleTable.ExchangeRate)).ToString("N2");
                    rpt.ReportParameters["returnDollar"].Value = Convert.ToDecimal(saleTable.ReturnDollars + (saleTable.ReturnRiels / saleTable.ExchangeRate)).ToString("N2");
                    rpt.ReportParameters["returnRiel"].Value = Convert.ToDecimal((saleTable.ReturnDollars * saleTable.ExchangeRate) + saleTable.ReturnRiels).ToString("N2");
                    rpt.DataSource = saleTable.SaleDetails;

                    GeneralFunction.PrintReporting(rpt, printers[0].DeviceName);
                }
            }
        }
    }
}
