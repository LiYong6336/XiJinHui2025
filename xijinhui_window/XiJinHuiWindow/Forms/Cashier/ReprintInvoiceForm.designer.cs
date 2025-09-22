using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow
{
    partial class ReprintInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReprintInvoiceForm));
            this.cmbInvoice = new Telerik.WinControls.UI.RadDropDownList();
            this.atLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.atPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtpSaleDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSaleDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbInvoice
            // 
            this.cmbInvoice.DropDownAnimationEnabled = true;
            this.cmbInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.cmbInvoice.Location = new System.Drawing.Point(33, 157);
            this.cmbInvoice.Name = "cmbInvoice";
            this.cmbInvoice.Size = new System.Drawing.Size(261, 36);
            this.cmbInvoice.TabIndex = 14;
            this.cmbInvoice.ThemeName = "Material";
            this.cmbInvoice.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbInvoice_SelectedIndexChanged);
            // 
            // atLabel1
            // 
            this.atLabel1.BackColor = System.Drawing.Color.Transparent;
            this.atLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.atLabel1.Location = new System.Drawing.Point(35, 25);
            this.atLabel1.Name = "atLabel1";
            this.atLabel1.Size = new System.Drawing.Size(252, 36);
            this.atLabel1.TabIndex = 0;
            this.atLabel1.Text = "Print Recept Again";
            // 
            // atPanel1
            // 
            this.atPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.atPanel1.Location = new System.Drawing.Point(12, 86);
            this.atPanel1.Name = "atPanel1";
            this.atPanel1.Size = new System.Drawing.Size(299, 5);
            this.atPanel1.TabIndex = 19;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpSaleDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.Location = new System.Drawing.Point(35, 110);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(259, 36);
            this.dtpSaleDate.TabIndex = 20;
            this.dtpSaleDate.TabStop = false;
            this.dtpSaleDate.Text = "2025-01-18";
            this.dtpSaleDate.ThemeName = "Material";
            this.dtpSaleDate.Value = new System.DateTime(2025, 1, 18, 11, 19, 39, 806);
            this.dtpSaleDate.ValueChanged += new System.EventHandler(this.dtpSaleDate_ValueChanged);
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
            // ReprintInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 300);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.atPanel1);
            this.Controls.Add(this.atLabel1);
            this.Controls.Add(this.cmbInvoice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReprintInvoiceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint Invoice";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmReprintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSaleDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadLabel atLabel1;
        private RadDropDownList cmbInvoice;
        private RadPanel atPanel1;
        private RadDateTimePicker dtpSaleDate;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}