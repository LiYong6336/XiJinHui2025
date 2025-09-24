namespace XiJinHuiWindow.Forms
{
    partial class ExchangeRatesForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRatesForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtNssf = new Telerik.WinControls.UI.RadTextBox();
            this.lblNssf = new Telerik.WinControls.UI.RadLabel();
            this.txtTax = new Telerik.WinControls.UI.RadTextBox();
            this.lblTax = new Telerik.WinControls.UI.RadLabel();
            this.txtRateReturn = new Telerik.WinControls.UI.RadTextBox();
            this.lblRateReturn = new Telerik.WinControls.UI.RadLabel();
            this.txtRate = new Telerik.WinControls.UI.RadTextBox();
            this.lblRate = new Telerik.WinControls.UI.RadLabel();
            this.lblDate = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNssf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNssf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRateReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.btnClear);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.dtpDate);
            this.radPanel1.Controls.Add(this.txtNssf);
            this.radPanel1.Controls.Add(this.lblNssf);
            this.radPanel1.Controls.Add(this.txtTax);
            this.radPanel1.Controls.Add(this.lblTax);
            this.radPanel1.Controls.Add(this.txtRateReturn);
            this.radPanel1.Controls.Add(this.lblRateReturn);
            this.radPanel1.Controls.Add(this.txtRate);
            this.radPanel1.Controls.Add(this.lblRate);
            this.radPanel1.Controls.Add(this.lblDate);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(843, 188);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancel.IconColor = System.Drawing.Color.MediumBlue;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(776, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 38);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClear.IconColor = System.Drawing.Color.MediumBlue;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 32;
            this.btnClear.Location = new System.Drawing.Point(776, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 38);
            this.btnClear.TabIndex = 51;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(776, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 38);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnModify.IconColor = System.Drawing.Color.MediumBlue;
            this.btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModify.IconSize = 32;
            this.btnModify.Location = new System.Drawing.Point(776, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(55, 38);
            this.btnModify.TabIndex = 6;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(164, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 36);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "2024-08-05";
            this.dtpDate.ThemeName = "MaterialPink";
            this.dtpDate.Value = new System.DateTime(2024, 8, 5, 0, 0, 0, 0);
            // 
            // txtNssf
            // 
            this.txtNssf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNssf.Location = new System.Drawing.Point(164, 130);
            this.txtNssf.Name = "txtNssf";
            this.txtNssf.Size = new System.Drawing.Size(218, 41);
            this.txtNssf.TabIndex = 5;
            this.txtNssf.ThemeName = "MaterialPink";
            // 
            // lblNssf
            // 
            this.lblNssf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNssf.Location = new System.Drawing.Point(35, 139);
            this.lblNssf.Name = "lblNssf";
            this.lblNssf.Size = new System.Drawing.Size(41, 26);
            this.lblNssf.TabIndex = 27;
            this.lblNssf.Text = "Nssf";
            this.lblNssf.ThemeName = "MaterialPink";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(535, 77);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(218, 38);
            this.txtTax.TabIndex = 4;
            this.txtTax.ThemeName = "MaterialPink";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(406, 90);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(36, 26);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "Tax";
            this.lblTax.ThemeName = "MaterialPink";
            // 
            // txtRateReturn
            // 
            this.txtRateReturn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateReturn.Location = new System.Drawing.Point(164, 73);
            this.txtRateReturn.Name = "txtRateReturn";
            this.txtRateReturn.Size = new System.Drawing.Size(218, 41);
            this.txtRateReturn.TabIndex = 3;
            this.txtRateReturn.ThemeName = "MaterialPink";
            // 
            // lblRateReturn
            // 
            this.lblRateReturn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateReturn.Location = new System.Drawing.Point(35, 84);
            this.lblRateReturn.Name = "lblRateReturn";
            this.lblRateReturn.Size = new System.Drawing.Size(109, 26);
            this.lblRateReturn.TabIndex = 21;
            this.lblRateReturn.Text = "RateReturned";
            this.lblRateReturn.ThemeName = "MaterialPink";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(535, 23);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(218, 41);
            this.txtRate.TabIndex = 2;
            this.txtRate.ThemeName = "MaterialPink";
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(406, 34);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(43, 26);
            this.lblRate.TabIndex = 21;
            this.lblRate.Text = "Rate";
            this.lblRate.ThemeName = "MaterialPink";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 26);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            this.lblDate.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 188);
            // 
            // 
            // 
            this.dgView.MasterTemplate.AllowAddNewRow = false;
            this.dgView.MasterTemplate.AllowCellContextMenu = false;
            this.dgView.MasterTemplate.AllowColumnChooser = false;
            this.dgView.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.dgView.MasterTemplate.AllowColumnReorder = false;
            this.dgView.MasterTemplate.AllowColumnResize = false;
            this.dgView.MasterTemplate.AllowDeleteRow = false;
            this.dgView.MasterTemplate.AllowDragToGroup = false;
            this.dgView.MasterTemplate.AllowEditRow = false;
            this.dgView.MasterTemplate.AllowRowResize = false;
            this.dgView.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "ExchangeDate";
            gridViewTextBoxColumn1.HeaderText = "Date";
            gridViewTextBoxColumn1.Name = "ExchangeDate";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "RateStandard";
            gridViewTextBoxColumn2.HeaderText = "Rate";
            gridViewTextBoxColumn2.Name = "RateStandard";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "RateReturned";
            gridViewTextBoxColumn3.HeaderText = "RateReturned";
            gridViewTextBoxColumn3.Name = "RateReturned";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "RateTaxation";
            gridViewTextBoxColumn4.HeaderText = "Tax";
            gridViewTextBoxColumn4.Name = "RateTaxation";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "RateNssf";
            gridViewTextBoxColumn5.HeaderText = "Nssf";
            gridViewTextBoxColumn5.Name = "RateNssf";
            gridViewTextBoxColumn5.Width = 150;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(843, 423);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // ExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExchangeRatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Rates";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmExchangeRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNssf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNssf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRateReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtNssf;
        private Telerik.WinControls.UI.RadLabel lblNssf;
        private Telerik.WinControls.UI.RadTextBox txtTax;
        private Telerik.WinControls.UI.RadLabel lblTax;
        private Telerik.WinControls.UI.RadTextBox txtRate;
        private Telerik.WinControls.UI.RadLabel lblRate;
        private Telerik.WinControls.UI.RadLabel lblDate;
        private Telerik.WinControls.UI.RadGridView dgView;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadTextBox txtRateReturn;
        private Telerik.WinControls.UI.RadLabel lblRateReturn;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
    }
}
