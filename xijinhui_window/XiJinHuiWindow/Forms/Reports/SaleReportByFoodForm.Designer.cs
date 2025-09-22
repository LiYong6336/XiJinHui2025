namespace XiJinHuiWindow.Forms.Reports
{
    partial class SaleReportByFoodForm
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.lblEndDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnShowFood = new Telerik.WinControls.UI.RadButton();
            this.lblStartDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(87, 104);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 26);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "EndDate";
            this.lblEndDate.ThemeName = "Material";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpEnd.Culture = new System.Globalization.CultureInfo("");
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(187, 89);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(236, 41);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Text = "2022-06-16 12:11:26";
            this.dtpEnd.ThemeName = "Material";
            this.dtpEnd.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 504);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.Location = new System.Drawing.Point(187, 151);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(236, 36);
            this.btnShowFood.TabIndex = 7;
            this.btnShowFood.Text = "Submit";
            this.btnShowFood.ThemeName = "Material";
            this.btnShowFood.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(81, 45);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(77, 26);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.ThemeName = "Material";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpStart.Culture = new System.Globalization.CultureInfo("");
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(187, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(236, 41);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.TabStop = false;
            this.dtpStart.Text = "2022-06-16 12:11:26";
            this.dtpStart.ThemeName = "Material";
            this.dtpStart.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 504);
            // 
            // SaleReportByFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 240);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStart);
            this.Name = "SaleReportByFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale By Food";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmSaleByFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel lblEndDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadButton btnShowFood;
        private Telerik.WinControls.UI.RadLabel lblStartDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
    }
}
