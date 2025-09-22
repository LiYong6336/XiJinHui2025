namespace XiJinHuiWindow.Reports.Cashier
{
    using XiJinHuiWindow.Utils;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Collections.Generic;

    /// <summary>
    /// Summary description for Report_CheckItem.
    /// </summary>
    public partial class ReportCheckItem : Telerik.Reporting.Report
    {
        public ReportCheckItem()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            ApplyTranslations();

        }

        private void ApplyTranslations()
        {

            AppLocalization.TranslateObjects<TextBox>(new List<TextBox> { 
                txtTitle, txtQty, txtCashier, txtDate,
            });
        }
    }
}