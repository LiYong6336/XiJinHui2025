namespace XiJinHuiWindow.Forms.Reports
{
    partial class TopupInformationForm
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.lblEndDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.lblStartDate = new Telerik.WinControls.UI.RadLabel();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblPhone = new Telerik.WinControls.UI.RadLabel();
            this.txtPhoneNumber = new Telerik.WinControls.UI.RadTextBox();
            this.btnPhone = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(33, 105);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 26);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "EndDate";
            this.lblEndDate.ThemeName = "MaterialPink";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpEnd.Culture = new System.Globalization.CultureInfo("");
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(154, 90);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(236, 41);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Text = "2022-06-16 12:11:26";
            this.dtpEnd.ThemeName = "MaterialPink";
            this.dtpEnd.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 504);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(270, 159);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 36);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.ThemeName = "MaterialPink";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(27, 32);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(77, 26);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.ThemeName = "MaterialPink";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpStart.Culture = new System.Globalization.CultureInfo("");
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(154, 17);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(236, 41);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.TabStop = false;
            this.dtpStart.Text = "2022-06-16 12:11:26";
            this.dtpStart.ThemeName = "MaterialPink";
            this.dtpStart.Value = new System.DateTime(2022, 6, 16, 12, 11, 26, 504);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(33, 246);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 26);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            this.lblPhone.ThemeName = "MaterialPink";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(198, 236);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(192, 36);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.ThemeName = "MaterialPink";
            // 
            // btnPhone
            // 
            this.btnPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.Location = new System.Drawing.Point(270, 294);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(114, 36);
            this.btnPhone.TabIndex = 12;
            this.btnPhone.Text = "Show";
            this.btnPhone.ThemeName = "MaterialPink";
            this.btnPhone.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(1, 211);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(427, 2);
            this.radPanel1.TabIndex = 13;
            // 
            // TopupInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 360);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStart);
            this.Name = "TopupInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopupInformation";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmTopupInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel lblEndDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadLabel lblStartDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
        private Telerik.WinControls.UI.RadLabel lblPhone;
        private Telerik.WinControls.UI.RadTextBox txtPhoneNumber;
        private Telerik.WinControls.UI.RadButton btnPhone;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}
