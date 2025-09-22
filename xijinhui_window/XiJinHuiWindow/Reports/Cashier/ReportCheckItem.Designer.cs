namespace XiJinHuiWindow.Reports.Cashier
{
    partial class ReportCheckItem
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.txtTitle = new Telerik.Reporting.TextBox();
            this.txtQty = new Telerik.Reporting.TextBox();
            this.txtDescription = new Telerik.Reporting.TextBox();
            this.txtDate = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.txtCashier = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.txtPersonCount = new Telerik.Reporting.TextBox();
            this.reportFooterSection1 = new Telerik.Reporting.ReportFooterSection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052D);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.662D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2,
            this.textBox4,
            this.textBox5,
            this.textBox13});
            this.detail.Name = "detail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.01D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.616D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.textBox2.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.TextWrap = false;
            this.textBox2.Value = "=Fields.LangDescription";
            // 
            // textBox4
            // 
            this.textBox4.Format = "{0:N1}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.626D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.TextWrap = false;
            this.textBox4.Value = "=Fields.Qty-Fields.OldQty";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.126D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.438D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.textBox5.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.TextWrap = false;
            this.textBox5.Value = "";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.006D), Telerik.Reporting.Drawing.Unit.Inch(0.462D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.568D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox13.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox13.TextWrap = true;
            this.textBox13.Value = "=Fields.Remark";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.002D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.14D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtTitle,
            this.txtQty,
            this.txtDescription,
            this.txtDate,
            this.textBox8,
            this.textBox7,
            this.txtCashier,
            this.textBox27,
            this.textBox3,
            this.txtPersonCount});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.944D), Telerik.Reporting.Drawing.Unit.Inch(0.342D));
            this.txtTitle.Style.Font.Name = "Microsoft Sans Serif";
            this.txtTitle.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtTitle.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtTitle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTitle.Value = "Order";
            // 
            // txtQty
            // 
            this.txtQty.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.626D), Telerik.Reporting.Drawing.Unit.Inch(0.94D));
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.938D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtQty.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.txtQty.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.txtQty.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.txtQty.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.txtQty.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.txtQty.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.txtQty.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.txtQty.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.txtQty.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtQty.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtQty.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtQty.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtQty.Style.Font.Name = "Microsoft Sans Serif";
            this.txtQty.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtQty.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.txtQty.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtQty.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtQty.TextWrap = false;
            this.txtQty.Value = "Qty";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.01D), Telerik.Reporting.Drawing.Unit.Inch(0.94D));
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.616D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtDescription.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.txtDescription.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.txtDescription.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.txtDescription.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.txtDescription.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.txtDescription.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.txtDescription.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.txtDescription.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.txtDescription.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtDescription.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtDescription.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtDescription.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.txtDescription.Style.Font.Name = "Microsoft Sans Serif";
            this.txtDescription.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtDescription.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.txtDescription.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtDescription.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDescription.TextWrap = false;
            this.txtDescription.Value = "Description";
            // 
            // txtDate
            // 
            this.txtDate.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.541D));
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtDate.Style.Font.Name = "Microsoft Sans Serif";
            this.txtDate.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtDate.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.txtDate.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtDate.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDate.TextWrap = false;
            this.txtDate.Value = "Date:";
            // 
            // textBox8
            // 
            this.textBox8.Format = "{0:dd-MM-yyyy HH:mm:ss}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4D), Telerik.Reporting.Drawing.Unit.Inch(0.54D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.168D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.TextWrap = false;
            this.textBox8.Value = "= Now()";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4D), Telerik.Reporting.Drawing.Unit.Inch(0.342D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.164D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox7.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.TextWrap = false;
            this.textBox7.Value = "= Parameters.userName.Value";
            // 
            // txtCashier
            // 
            this.txtCashier.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.341D));
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtCashier.Style.Font.Name = "Microsoft Sans Serif";
            this.txtCashier.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtCashier.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.txtCashier.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtCashier.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCashier.TextWrap = false;
            this.txtCashier.Value = "Cashier:";
            // 
            // textBox27
            // 
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.944D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.62D), Telerik.Reporting.Drawing.Unit.Inch(0.342D));
            this.textBox27.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox27.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox27.TextWrap = false;
            this.textBox27.Value = "= Parameters.tableName.Value";
            // 
            // textBox3
            // 
            this.textBox3.Format = "{0}";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4D), Telerik.Reporting.Drawing.Unit.Inch(0.74D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.168D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.TextWrap = false;
            this.textBox3.Value = "=Parameters.personCount.Value";
            // 
            // txtPersonCount
            // 
            this.txtPersonCount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.74D));
            this.txtPersonCount.Name = "txtPersonCount";
            this.txtPersonCount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtPersonCount.Style.Font.Name = "Microsoft Sans Serif";
            this.txtPersonCount.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtPersonCount.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.txtPersonCount.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtPersonCount.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtPersonCount.TextWrap = false;
            this.txtPersonCount.Value = "PersonCount：";
            // 
            // reportFooterSection1
            // 
            this.reportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.01D);
            this.reportFooterSection1.Name = "reportFooterSection1";
            // 
            // ReportCheckItem
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1,
            this.reportFooterSection1});
            this.Name = "Report_CheckItem";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D), Telerik.Reporting.Drawing.Unit.Mm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(72D), Telerik.Reporting.Drawing.Unit.Mm(500D));
            reportParameter1.Name = "userName";
            reportParameter2.Name = "tableName";
            reportParameter3.Name = "personCount";
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(2.717D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox txtTitle;
        private Telerik.Reporting.TextBox txtQty;
        private Telerik.Reporting.TextBox txtDescription;
        private Telerik.Reporting.TextBox txtDate;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox txtCashier;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.ReportFooterSection reportFooterSection1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox txtPersonCount;
        private Telerik.Reporting.TextBox textBox13;
    }
}