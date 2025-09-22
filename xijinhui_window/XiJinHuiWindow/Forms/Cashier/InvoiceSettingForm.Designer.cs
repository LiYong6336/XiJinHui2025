namespace XiJinHuiWindow.Forms.Cashier
{
    partial class InvoiceSettingForm
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
            this.btnDiscount = new FontAwesome.Sharp.IconButton();
            this.btnSplitInvoice = new FontAwesome.Sharp.IconButton();
            this.btnChangeTable = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnDiscountCategory = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiscount
            // 
            this.btnDiscount.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.btnDiscount.IconColor = System.Drawing.Color.Black;
            this.btnDiscount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscount.Location = new System.Drawing.Point(35, 31);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(148, 95);
            this.btnDiscount.TabIndex = 0;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSplitInvoice
            // 
            this.btnSplitInvoice.IconChar = FontAwesome.Sharp.IconChar.ArrowsSplitUpAndLeft;
            this.btnSplitInvoice.IconColor = System.Drawing.Color.Black;
            this.btnSplitInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSplitInvoice.Location = new System.Drawing.Point(189, 31);
            this.btnSplitInvoice.Name = "btnSplitInvoice";
            this.btnSplitInvoice.Size = new System.Drawing.Size(148, 95);
            this.btnSplitInvoice.TabIndex = 0;
            this.btnSplitInvoice.Text = "SplitInvoice";
            this.btnSplitInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSplitInvoice.UseVisualStyleBackColor = true;
            this.btnSplitInvoice.Click += new System.EventHandler(this.btnSplitInvoice_Click);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnChangeTable.IconColor = System.Drawing.Color.Black;
            this.btnChangeTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeTable.Location = new System.Drawing.Point(35, 132);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(148, 95);
            this.btnChangeTable.TabIndex = 0;
            this.btnChangeTable.Text = "ChangeTable";
            this.btnChangeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(189, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 95);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDiscountCategory
            // 
            this.btnDiscountCategory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.btnDiscountCategory.IconColor = System.Drawing.Color.Black;
            this.btnDiscountCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscountCategory.Location = new System.Drawing.Point(35, 233);
            this.btnDiscountCategory.Name = "btnDiscountCategory";
            this.btnDiscountCategory.Size = new System.Drawing.Size(302, 95);
            this.btnDiscountCategory.TabIndex = 0;
            this.btnDiscountCategory.Text = "DiscountCategory";
            this.btnDiscountCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscountCategory.UseVisualStyleBackColor = true;
            this.btnDiscountCategory.Click += new System.EventHandler(this.btnDiscountCategory_Click);
            // 
            // InvoiceSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 364);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.btnSplitInvoice);
            this.Controls.Add(this.btnDiscountCategory);
            this.Controls.Add(this.btnDiscount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invioce Setting";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.InvoiceSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDiscount;
        private FontAwesome.Sharp.IconButton btnSplitInvoice;
        private FontAwesome.Sharp.IconButton btnChangeTable;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDiscountCategory;
    }
}
