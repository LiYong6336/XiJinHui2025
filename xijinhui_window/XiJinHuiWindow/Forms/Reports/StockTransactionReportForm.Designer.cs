namespace XiJinHuiWindow.Forms.Reports
{
    partial class StockTransactionReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStartDate = new Telerik.WinControls.UI.RadLabel();
            this.lblEndDate = new Telerik.WinControls.UI.RadLabel();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(23, 40);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(68, 21);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.ThemeName = "MaterialPink";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(30, 86);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(61, 21);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "EndDate";
            this.lblEndDate.ThemeName = "MaterialPink";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(131, 131);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(236, 41);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Submit";
            this.btnShow.ThemeName = "MaterialPink";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpStart.Culture = new System.Globalization.CultureInfo("");
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(136, 32);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(231, 36);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.TabStop = false;
            this.dtpStart.Text = "2024-04-24 19:47:14";
            this.dtpStart.ThemeName = "MaterialPink";
            this.dtpStart.Value = new System.DateTime(2024, 4, 24, 19, 47, 14, 581);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpEnd.Culture = new System.Globalization.CultureInfo("");
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(136, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(231, 36);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Text = "2024-04-24 19:47:16";
            this.dtpEnd.ThemeName = "MaterialPink";
            this.dtpEnd.Value = new System.DateTime(2024, 4, 24, 19, 47, 16, 561);
            // 
            // StockTransactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 198);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblEndDate);
            this.Name = "StockTransactionReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transactions";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmDailyUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblStartDate;
        private Telerik.WinControls.UI.RadLabel lblEndDate;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
    }
}
