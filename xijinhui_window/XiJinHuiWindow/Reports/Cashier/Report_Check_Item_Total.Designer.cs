namespace XiJinHuiWindow.Reports.Cashier
{
    partial class Report_Check_Item_Total
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
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.reportFooterSection1 = new Telerik.Reporting.ReportFooterSection();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.468D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox4,
            this.textBox2,
            this.textBox23});
            this.detail.Name = "detail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.146D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.287D), Telerik.Reporting.Drawing.Unit.Inch(0.468D));
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
            // textBox4
            // 
            this.textBox4.Format = "{0:N1}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.63D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.484D), Telerik.Reporting.Drawing.Unit.Inch(0.468D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.TextWrap = false;
            this.textBox4.Value = "=Fields.Qty";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.018D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.612D), Telerik.Reporting.Drawing.Unit.Inch(0.234D));
            this.textBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox2.Style.Font.Name = "Hanuman";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.TextWrap = false;
            this.textBox2.Value = "=IIf(Len(Fields.FoodDishDetail.KhmerName) = 0, Fields.FoodDish.KhmerName, Fields." +
    "FoodDishDetail.KhmerName)";
            // 
            // textBox23
            // 
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.018D), Telerik.Reporting.Drawing.Unit.Inch(0.234D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.612D), Telerik.Reporting.Drawing.Unit.Inch(0.234D));
            this.textBox23.Style.Font.Name = "Hanuman";
            this.textBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox23.TextWrap = true;
            this.textBox23.Value = "{IIf(Len(Fields.FoodDishDetail.ChineseName) = 0, Fields.FoodDish.ChineseName, Fie" +
    "lds.FoodDishDetail.ChineseName)} {Fields.Remark}";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Mm(0.1D);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Mm(0.1D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // reportFooterSection1
            // 
            this.reportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.054D);
            this.reportFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox24});
            this.reportFooterSection1.Name = "reportFooterSection1";
            // 
            // textBox24
            // 
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.412D), Telerik.Reporting.Drawing.Unit.Inch(0.054D));
            this.textBox24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox24.Style.Color = System.Drawing.Color.White;
            this.textBox24.Style.Font.Name = "Hanuman";
            this.textBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox24.TextWrap = false;
            this.textBox24.Value = "1";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.332D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox12,
            this.textBox3,
            this.textBox27,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox1,
            this.textBox13});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.022D), Telerik.Reporting.Drawing.Unit.Inch(0.928D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.376D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox12.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox12.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox12.TextWrap = false;
            this.textBox12.Value = "人数：";
            // 
            // textBox3
            // 
            this.textBox3.Format = "{0}";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.397D), Telerik.Reporting.Drawing.Unit.Inch(0.932D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.015D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.TextWrap = false;
            this.textBox3.Value = "=Parameters.personCount.Value";
            // 
            // textBox27
            // 
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.885D), Telerik.Reporting.Drawing.Unit.Inch(0.266D));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.527D), Telerik.Reporting.Drawing.Unit.Inch(0.269D));
            this.textBox27.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox27.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox27.TextWrap = false;
            this.textBox27.Value = "= Parameters.tableName.Value";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.022D), Telerik.Reporting.Drawing.Unit.Inch(0.532D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.376D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.TextWrap = false;
            this.textBox6.Value = "用户:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.397D), Telerik.Reporting.Drawing.Unit.Inch(0.536D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.015D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox7.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.TextWrap = false;
            this.textBox7.Value = "= Parameters.userName.Value";
            // 
            // textBox8
            // 
            this.textBox8.Format = "{0:dd-MM-yyyy HH:mm:ss}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.397D), Telerik.Reporting.Drawing.Unit.Inch(0.734D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.015D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.TextWrap = false;
            this.textBox8.Value = "= Now()";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.022D), Telerik.Reporting.Drawing.Unit.Inch(0.73D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.376D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.TextWrap = false;
            this.textBox9.Value = "日期:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.017D), Telerik.Reporting.Drawing.Unit.Inch(1.132D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.613D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox10.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox10.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox10.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox10.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox10.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox10.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox10.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox10.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox10.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.TextWrap = false;
            this.textBox10.Value = "菜名";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.63D), Telerik.Reporting.Drawing.Unit.Inch(1.132D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.484D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox11.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox11.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(1D);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.TextWrap = false;
            this.textBox11.Value = "数量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.011D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.873D), Telerik.Reporting.Drawing.Unit.Inch(0.535D));
            this.textBox1.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "总单";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.884D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.527D), Telerik.Reporting.Drawing.Unit.Inch(0.266D));
            this.textBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.Font.Name = "Microsoft Sans Serif";
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox13.Value = "桌号";
            // 
            // Report_Check_Item_Total
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.pageHeaderSection1,
            this.pageFooterSection1,
            this.reportFooterSection1,
            this.reportHeaderSection1});
            this.Name = "Report_Check_Item_Total";
            this.PageSettings.ContinuousPaper = true;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D));
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(2.433D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ReportFooterSection reportFooterSection1;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox13;
    }
}