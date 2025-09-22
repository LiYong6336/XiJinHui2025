using XiJinHuiWindow;
using XiJinHuiWindow.Forms.Cashier;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports.Cashier;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow
{
    public partial class ReprintInvoiceForm : RadForm

    {
        private TableForm tableForm;
        private List<SaleTable> saleTables;
        private SaleTable saleTable;
        public ReprintInvoiceForm(TableForm tableForm)
        {
            InitializeComponent();
            this.tableForm = tableForm;
        }
       
        private void frmReprintInvoice_Load(object sender, EventArgs e)
        {
            //Utilities.GerneralFunction.BindCombobox(cmbInvoice, "SELECT InvoiceNo FROM dbo.SALE_TAX_TABLE WHERE LEN(InvoiceNo)>5 AND CONVERT(DATE,SaleDate,101) = '" + dtpSaleDate.Value.ToString("yyyy-MM-dd") + "'", Utilities.DBHelper.SQLCONNECTION);

            dtpSaleDate.Text = GeneralFunction.FormatStandardDate(DateTime.Now);
            //LoadSaleTables();
        }

        private async void LoadSaleTables()
        {
            cmbInvoice.Items.Clear();
            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>($"sale_tables?start_date={dtpSaleDate.Value.ToString("yyyy-MM-dd")} 00:00:00&end_date={dtpSaleDate.Value.ToString("yyyy-MM-dd")} 23:59:59");
            saleTables = res.Data;
            foreach (SaleTable ds in saleTables) {
                var item = new RadListDataItem { 
                    Value = (String) ds.Id,
                    Text = ds.ShowingInvoiceNumber,
                    Tag = ds
                };
                cmbInvoice.Items.Add(item);
            }
        }

        private async void dtpSaleDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSaleTables();

        }

        private void cmbInvoice_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            saleTable = saleTables[cmbInvoice.SelectedIndex];
        }

        private async void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (tableForm.printers.Count == 0)
            {
                MessageBox.Show("No printer found");
                return;
            }
            ReportInvoice rpt = new ReportInvoice();
            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["invoiceNumber"].Value = saleTable.ShowingInvoiceNumber;
            rpt.ReportParameters["saleDate"].Value = saleTable.SaleDate;
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

            GeneralFunction.PrintReporting(rpt, tableForm.printers[0].DeviceName);
            this.Dispose();
        }

    }
}
