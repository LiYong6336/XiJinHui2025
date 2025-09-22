using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace XiJinHuiWindow.Forms.Reports
{
    public partial class SaleReportByFoodForm : Telerik.WinControls.UI.RadForm
    {
        public SaleReportByFoodForm()
        {
            InitializeComponent();
        }

        private void frmSaleByFood_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            //     var dt = Utilities.GerneralFunction.GetDataTable(@"
            //SELECT SUM(Qty) AS 'Qty',
            //	   SUM(Cost) AS 'Cost',
            //	   SUM(Price) AS 'Price',
            //	   SUM(TotalQty) AS 'TotalQty',
            //	   SUM(QtyFree) AS 'QtyFree',
            //	   SUM(Amount) AS 'Amount',
            //	   SUM(AmountAfterDiscount) AS 'AmountAfterDiscount',
            //	   SUM(taxamount) AS 'taxamount',
            //	   SUM(TotalAmount) AS 'TotalAmount',
            //	   SUM(GrandTotalAmount) AS 'GrandTotalAmount',
            //	   SUM(personCount) AS 'personCount',
            //	   SUM(SERVICE_PERCENSE) AS 'SERVICE_PERCENSE',
            //	   SUM(SERVICE_CHARGED) AS 'SERVICE_CHARGED',
            //	   SUM(FINAL_GRANDTOTAL) AS 'FINAL_GRANDTOTAL',
            //	   fdt_english,
            //	   ctt_english,
            //	   ctt_chinese,
            //	   ctt_khmer,
            //	   fdt_chinese,
            //	   fdt_khmer
            //FROM dbo.View_SALE_DETAIL_ADMIN
            //WHERE SaleDate
            //BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + @"'
            //GROUP BY fdt_english,
            //	   ctt_english,
            //	   ctt_chinese,
            //	   ctt_khmer,
            //	   fdt_chinese,
            //	   fdt_khmer");

            //     if (dt.Rows.Count > 0)
            //     {
            //         rptSaleByDateSecret rpt = new rptSaleByDateSecret();
            //         rpt.DataSource = dt;
            //         rpt.ReportParameters["dStart"].Value = dtpStart.Value;
            //         rpt.ReportParameters["dEnd"].Value = dtpEnd.Value;
            //         frmReportViewer frm = new frmReportViewer();
            //         frm.rptViewer.Report = rpt;
            //         frm.rptViewer.RefreshReport();
            //         frm.Show();
            //     }
            //     else
            //     {
            //         MessageBox.Show("Nothing");
            //     }

            {

                //var dtabel = Utilities.GerneralFunction.GetDataTable(@"SELECT * FROM View_SALE 
                //WHERE SaleDate BETWEEN '" + dtpStart.Value + "' AND '" + dtpEnd.Value + "' AND InvoiceNo IS NOT NULL ORDER BY InvoiceNo ");
                Response<List<SaleDetail>> res = await HttpClientHelper.GetAsync<List<SaleDetail>>($"saleReportByFood?date_start={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&date_end={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}");
                List<SaleDetail> saleDetails = res.Data;

                if (saleDetails.Count > 0)
                {
                    SaleByFoodReport rpt = new SaleByFoodReport();
                    rpt.DataSource = saleDetails;
                    rpt.ReportParameters["dStart"].Value = dtpStart.Value;
                    rpt.ReportParameters["dEnd"].Value = dtpEnd.Value;
                    ReportViewerForm frm = new ReportViewerForm();
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
}
