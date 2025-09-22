using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Telerik.WinControls;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Forms.Reports
{
    public partial class StockTransactionReportForm : Telerik.WinControls.UI.RadForm
    {
        public StockTransactionReportForm()
        {
            InitializeComponent();
        }

        private void frmDailyUsage_Load(object sender, EventArgs e)
        {
            var dValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpStart.Value = dValue.Date;
            dtpEnd.Value = dValue.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            Response<List<UsageReport>> res = await HttpClientHelper.GetAsync<List<UsageReport>>($"stock-transactions-report?start_date={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&end_date={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}");
            List<UsageReport> dailyUsages = res.Data;

            if (dailyUsages.Count>0)
            {
            StockTransactionReport rpt = new StockTransactionReport();
            var frm = new ReportViewerForm();
                rpt.DataSource= dailyUsages;
                rpt.ReportParameters["pStart"].Value= (DateTime)dtpStart.Value;
                rpt.ReportParameters["pEnd"].Value= (DateTime)dtpEnd.Value;
                frm.rptViewer.Report = rpt;
                frm.rptViewer.RefreshReport();
                frm.Show();

            } else
            {
                MessageBox.Show("Empty");
            }
        }
    }

    //public class DailyUsageModel : HasNameLanguages
    //{
    //    [JsonPropertyName("total_usage"), JsonConverter(typeof(StringToDoubleConverter))]
    //    public double? TotalUsage { get; set; }
    //}
}
