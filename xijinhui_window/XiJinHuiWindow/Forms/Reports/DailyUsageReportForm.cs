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
    public partial class DailyUsageReportForm : Telerik.WinControls.UI.RadForm
    {
        public DailyUsageReportForm()
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
            //rptDailyUsage rpt = new rptDailyUsage();
            //var frm = new frmReportViewer();

            //DataTable dt = Utilities.GerneralFunction.GetDataTable(
            //    @"
            //        SELECT dbo.STOCK_DAILY_USAGE_TABLE.sdu_id,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_item_id,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_sale_id,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_icd_id,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_food_id,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_event_date,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_total_food_qty,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_usage,
            //               dbo.STOCK_DAILY_USAGE_TABLE.sdu_kilo,
            //               dbo.ITEM_TABLE.itm_english,
            //               dbo.ITEM_TABLE.itm_chinese,
            //               dbo.ITEM_TABLE.itm_khmer,
            //               dbo.FOODS_TABLE.fdt_english,
            //               dbo.FOODS_TABLE.fdt_chinese,
            //               dbo.FOODS_TABLE.fdt_khmer,
            //               dbo.INGREDIENTS_TABLE.icd_usage,
            //               dbo.INGREDIENTS_TABLE.icd_kilo
            //        FROM dbo.FOODS_TABLE
            //            INNER JOIN dbo.INGREDIENTS_TABLE
            //                INNER JOIN dbo.STOCK_DAILY_USAGE_TABLE
            //                    INNER JOIN dbo.ITEM_TABLE
            //                        ON dbo.STOCK_DAILY_USAGE_TABLE.sdu_item_id = dbo.ITEM_TABLE.itm_id
            //                    INNER JOIN dbo.SALE_TABLE
            //                        ON dbo.STOCK_DAILY_USAGE_TABLE.sdu_sale_id = dbo.SALE_TABLE.Id
            //                    ON dbo.INGREDIENTS_TABLE.icd_id = dbo.STOCK_DAILY_USAGE_TABLE.sdu_icd_id
            //                ON dbo.FOODS_TABLE.fdt_id = dbo.STOCK_DAILY_USAGE_TABLE.sdu_food_id
            //        WHERE dbo.SALE_TABLE.SaleDate
            //        BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + "';");


            //var dtabel = Utilities.GerneralFunction.GetDataTable(@"SELECT * FROM View_SALE 
            //WHERE SaleDate BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + "' AND InvoiceNo IS NOT NULL ORDER BY InvoiceNo ");
            Response<List<UsageReport>> res = await HttpClientHelper.GetAsync<List<UsageReport>>($"dailyUsage?start_date={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&end_date={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}");
            List<UsageReport> dailyUsages = res.Data;

         

            if (dailyUsages.Count>0)
            {
            DailyUsageReport rpt = new DailyUsageReport();
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

    public class DailyUsageModel : HasNameLanguages
    {
        [JsonPropertyName("total_usage"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? TotalUsage { get; set; }
    }
}
