using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace XiJinHuiWindow.Reports
{
    /// <summary>
    /// Summary description for rptTopupInformation.
    /// </summary>
    public partial class TopupInformationReport : Telerik.Reporting.Report
    {
        public TopupInformationReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            ReportParameters["pStart"].Value = new DateTime(); 
            ReportParameters["pEnd"].Value = new DateTime(); 
            ReportParameters["pCus_info"].Value = ""; 
        }
    }
}