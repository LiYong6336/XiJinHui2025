namespace XiJinHuiWindow.Forms.Reports
{
    partial class SaleReportSecretForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReportSecretForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.btnOwe = new Telerik.WinControls.UI.RadButton();
            this.lblEndDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.lblStartDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOwe
            // 
            resources.ApplyResources(this.btnOwe, "btnOwe");
            this.btnOwe.Name = "btnOwe";
            this.btnOwe.ThemeName = "Material";
            this.btnOwe.Click += new System.EventHandler(this.btnOwe_Click);
            // 
            // lblEndDate
            // 
            resources.ApplyResources(this.lblEndDate, "lblEndDate");
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.ThemeName = "Material";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            resources.ApplyResources(this.dtpEnd, "dtpEnd");
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.TabStop = false;
            this.dtpEnd.ThemeName = "Material";
            this.dtpEnd.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 0);
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.ThemeName = "Material";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStartDate
            // 
            resources.ApplyResources(this.lblStartDate, "lblStartDate");
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.ThemeName = "Material";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            resources.ApplyResources(this.dtpStart, "dtpStart");
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.TabStop = false;
            this.dtpStart.ThemeName = "Material";
            this.dtpStart.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 0);
            // 
            // SaleReportSecretForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOwe);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStart);
            this.Name = "SaleReportSecretForm";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton btnOwe;
        private Telerik.WinControls.UI.RadLabel lblEndDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadLabel lblStartDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
    }
}
