using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow
{
    partial class StartDateEndDateTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartDateEndDateTimeForm));
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.dtStartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtEndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 32;
            this.btnPrint.Location = new System.Drawing.Point(35, 216);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(259, 57);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(35, 56);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(252, 36);
            this.dtStartDate.TabIndex = 22;
            this.dtStartDate.TabStop = false;
            this.dtStartDate.Text = "2025-01-18 15:05:52";
            this.dtStartDate.ThemeName = "MaterialPink";
            this.dtStartDate.Value = new System.DateTime(2025, 1, 18, 15, 5, 52, 224);
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(35, 139);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(252, 36);
            this.dtEndDate.TabIndex = 22;
            this.dtEndDate.TabStop = false;
            this.dtEndDate.Text = "2025-01-18 15:05:52";
            this.dtEndDate.ThemeName = "MaterialPink";
            this.dtEndDate.Value = new System.DateTime(2025, 1, 18, 15, 5, 52, 224);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(35, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 23;
            this.radLabel1.Text = "Start Date";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(35, 115);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 18);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "End Date";
            // 
            // StartDateEndDateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 300);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartDateEndDateTimeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Date";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmReprintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnPrint;
        private RadDateTimePicker dtStartDate;
        private RadDateTimePicker dtEndDate;
        private RadLabel radLabel1;
        private RadLabel radLabel2;
    }
}