using XiJinHuiWindow;
using XiJinHuiWindow.Forms.Reports;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace XiJinHuiWindow.Forms.Reports
{
    public partial class SaleReportForm : Telerik.WinControls.UI.RadForm
    {
        public SaleReportForm()
        {
            InitializeComponent();
        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var rpt = new SaleReport();
            var frm = new ReportViewerForm();

            //var dtabel = Utilities.GerneralFunction.GetDataTable(@"SELECT * FROM View_SALE 
            //WHERE SaleDate BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + "' AND InvoiceNo IS NOT NULL ORDER BY InvoiceNo ");
            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>($"dailySaleReport?date_start={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&date_end={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}");
            List<SaleTable> saleTables = res.Data;

            if (saleTables.Count>0) {
                rpt.DataSource = saleTables;
                rpt.ReportParameters["pStart"].Value = dtpStart.Value;
                rpt.ReportParameters["pEnd"].Value = dtpEnd.Value;
                rpt.ReportParameters["pType"].Value = 2;
                rpt.ReportParameters["pReportType"].Value = "PUBLIC";
                frm.rptViewer.Report = rpt;
                
                frm.rptViewer.RefreshReport();
                frm.Show();
            } else
            {
                MessageBox.Show("Nothing");
            }

        }

        private async void btnOwe_Click(object sender, EventArgs e)
        {
            var rpt = new OwedReport();
            var frm = new ReportViewerForm();

            //var dtabel = Utilities.GerneralFunction.GetDataTable(@"SELECT * FROM View_SALE 
            //WHERE SaleDate BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + "' AND paytype=2 AND InvoiceNo IS NOT NULL ORDER BY InvoiceNo ");

            Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>($"dailySaleReport?date_start={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&date_end={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}&owed");
            List<SaleTable> saleTables = res.Data;
            if (saleTables.Count > 0)
            {
                rpt.DataSource = saleTables;
                rpt.ReportParameters["pStart"].Value = dtpStart.Value;
                rpt.ReportParameters["pEnd"].Value = dtpEnd.Value;
                rpt.ReportParameters["pType"].Value = 2;
                rpt.ReportParameters["pReportType"].Value = "SECRET";
                frm.rptViewer.Report = rpt;

                frm.rptViewer.RefreshReport();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

    }
}
