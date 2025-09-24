namespace XiJinHuiWindow.Forms.Reports
{
    partial class SaleReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReportForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.btnOwe = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOwe
            // 
            resources.ApplyResources(this.btnOwe, "btnOwe");
            this.btnOwe.Name = "btnOwe";
            this.btnOwe.ThemeName = "MaterialPink";
            this.btnOwe.Click += new System.EventHandler(this.btnOwe_Click);
            // 
            // radLabel2
            // 
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.ThemeName = "MaterialPink";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            resources.ApplyResources(this.dtpEnd, "dtpEnd");
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.TabStop = false;
            this.dtpEnd.ThemeName = "MaterialPink";
            this.dtpEnd.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 0);
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.ThemeName = "MaterialPink";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.ThemeName = "MaterialPink";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            resources.ApplyResources(this.dtpStart, "dtpStart");
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.TabStop = false;
            this.dtpStart.ThemeName = "MaterialPink";
            this.dtpStart.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 0);
            // 
            // SaleReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOwe);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpStart);
            this.Name = "SaleReportForm";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton btnOwe;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
    }
}
