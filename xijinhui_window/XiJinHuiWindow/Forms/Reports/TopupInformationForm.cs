using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Reports
{
    public partial class TopupInformationForm : Telerik.WinControls.UI.RadForm
    {
        public TopupInformationForm()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            Response<List<CustomerTopup>> res = await HttpClientHelper.GetAsync<List<CustomerTopup>>($"customerTopupReport?date_start={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&date_end={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}");
            List<CustomerTopup> topups = res.Data;
            if (topups.Count > 0)
            {

           TopupInformationReport rpt = new TopupInformationReport();
            rpt.DataSource = topups;
            rpt.ReportParameters["pStart"].Value = dtpStart.Value; 
            rpt.ReportParameters["pEnd"].Value = dtpEnd.Value; 
            rpt.ReportParameters["pCus_info"].Value = ""; 

            ReportViewerForm frm = new ReportViewerForm();
            frm.rptViewer.Report = rpt;
            frm.rptViewer.RefreshReport();
            frm.Show();
            }else
            {
                MessageBox.Show("Empty");
            }



        }

        private void frmTopupInformation_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            ApplyTranslations();
        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<RadButton>(new List<RadButton> { btnPhone, btnShow,  });
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> { lblStartDate,lblEndDate,lblPhone  });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show("Please enter a phone number");
                return;
            }
            Response<List<CustomerTopup>> res = await HttpClientHelper.GetAsync<List<CustomerTopup>>($"customerTopupReport?date_start={dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss")}&date_end={dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss")}&phone={txtPhoneNumber.Text}");
            List<CustomerTopup> topups = res.Data;
            if (topups.Count > 0)
            {

           TopupInformationReport rpt = new TopupInformationReport();
            rpt.DataSource = topups;
            rpt.ReportParameters["pStart"].Value = dtpStart.Value; 
            rpt.ReportParameters["pEnd"].Value = dtpEnd.Value; 
            rpt.ReportParameters["pCus_info"].Value = ""; 

            ReportViewerForm frm = new ReportViewerForm();
            frm.rptViewer.Report = rpt;
            frm.rptViewer.RefreshReport();
            frm.Show();
            }else
            {
                MessageBox.Show("Empty");
            }

        }
    }
}
