using XiJinHuiWindow;
using XiJinHuiWindow.Forms.Cashier;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reporting;
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
    public partial class StartDateEndDateTimeForm : RadForm

    {
        private TableForm tableForm;
        public StartDateEndDateTimeForm(TableForm tableForm)
        {
            InitializeComponent();
            this.tableForm = tableForm;
        }
       
        private void frmReprintInvoice_Load(object sender, EventArgs e)
        {
            //Utilities.GerneralFunction.BindCombobox(cmbInvoice, "SELECT InvoiceNo FROM dbo.SALE_TAX_TABLE WHERE LEN(InvoiceNo)>5 AND CONVERT(DATE,SaleDate,101) = '" + dtpSaleDate.Value.ToString("yyyy-MM-dd") + "'", Utilities.DBHelper.SQLCONNECTION);

            var now = DateTime.Now;
            dtStartDate.Value = now.Date;
            dtEndDate.Value = now.Date.AddDays(1).AddTicks(-1);

        }

        private async void btnPrint_Click_1(object sender, EventArgs e)
        {
            
            if (tableForm.printers.Count == 0)
            {
                MessageBox.Show("No printer found");
                return;
            }

            //var sDate = GeneralFunction.FormatStandardDatetime( DateTime.Now);
            //var eDt = DateTime.Now;
            //var eDate = 
            //var now = DateTime.Now;
            //var sDate = now.Date;
            //var eDate = now.Date.AddDays(1).AddTicks(-1);
            var sDate = dtStartDate.Value;
            var eDate = dtEndDate.Value;

            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>("sale_tables", new Dictionary<string, string>
            {
                {"start_date", GeneralFunction.FormatStandardDatetime(sDate)},
                { "end_date", GeneralFunction.FormatStandardDatetime(eDate)},
                { "owned", "true" },
            });

            ReportTotalInvoice rpt = new ReportTotalInvoice();

            //rpt.ReportParameters["dStart"].Value = sDate.ToString();
            //rpt.ReportParameters["dEnd"].Value = eDate.ToString();
            //rpt.ReportParameters["grandTotal"].Value = res.TotalAmount;
            //rpt.ReportParameters["totalMethod"].Value = res.TotalAmount2;
            //rpt.DataSource = res.Data;

            rpt.ReportParameters["dStart"].Value = sDate.ToString();
            rpt.ReportParameters["dEnd"].Value = eDate.ToString();
            rpt.ReportParameters["grandTotal"].Value = res.TotalAmount;
            //rpt.ReportParameters["totalMethod"].Value = res.TotalAmount2.Replace("\\\n", System.Environment.NewLine);
            rpt.ReportParameters["totalMethod"].Value = string.Join("\n-------------------------------------------\n", res.TotalByMethods);
            rpt.ReportParameters["customerTopup"].Value = "Customer Topup: " + res.CustomerTopup;
            rpt.ReportParameters["payOwed"].Value = "Pay Owed: " + res.PayOwed;
            rpt.DataSource = res.Data;


            GeneralFunction.PrintReporting(rpt, tableForm.printers[0].DeviceName);
            this.Dispose();
        }

    }
}
