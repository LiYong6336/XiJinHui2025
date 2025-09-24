namespace XiJinHuiWindow.Forms
{
    partial class StockInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInsForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.lblDate = new Telerik.WinControls.UI.RadLabel();
            this.txtNote = new Telerik.WinControls.UI.RadTextBox();
            this.lblNote = new Telerik.WinControls.UI.RadLabel();
            this.txtInvoiceNumber = new Telerik.WinControls.UI.RadTextBox();
            this.lblInvoiceNumber = new Telerik.WinControls.UI.RadLabel();
            this.txtReference = new Telerik.WinControls.UI.RadTextBox();
            this.lblReference = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtDate);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.lblDate);
            this.radPanel1.Controls.Add(this.txtNote);
            this.radPanel1.Controls.Add(this.lblNote);
            this.radPanel1.Controls.Add(this.txtInvoiceNumber);
            this.radPanel1.Controls.Add(this.lblInvoiceNumber);
            this.radPanel1.Controls.Add(this.txtReference);
            this.radPanel1.Controls.Add(this.lblReference);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(843, 150);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // dtDate
            // 
            this.dtDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtDate.CustomFormat = "yyyy-MM-dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(151, 85);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(229, 36);
            this.dtDate.TabIndex = 42;
            this.dtDate.TabStop = false;
            this.dtDate.Text = "2024-12-11";
            this.dtDate.ThemeName = "MaterialPink";
            this.dtDate.Value = new System.DateTime(2024, 12, 11, 10, 25, 2, 633);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancel.IconColor = System.Drawing.Color.MediumBlue;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(776, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 38);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(776, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 38);
            this.btnDelete.TabIndex = 41;
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
            this.btnModify.TabIndex = 7;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(39, 89);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 26);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            this.lblDate.ThemeName = "MaterialPink";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(520, 80);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(229, 41);
            this.txtNote.TabIndex = 5;
            this.txtNote.ThemeName = "MaterialPink";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(408, 91);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 26);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note";
            this.lblNote.ThemeName = "MaterialPink";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(151, 20);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(229, 41);
            this.txtInvoiceNumber.TabIndex = 3;
            this.txtInvoiceNumber.ThemeName = "MaterialPink";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(28, 30);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(117, 26);
            this.lblInvoiceNumber.TabIndex = 19;
            this.lblInvoiceNumber.Text = "InvoiceNumber";
            this.lblInvoiceNumber.ThemeName = "MaterialPink";
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(520, 20);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(229, 41);
            this.txtReference.TabIndex = 3;
            this.txtReference.ThemeName = "MaterialPink";
            // 
            // lblReference
            // 
            this.lblReference.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(408, 30);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(83, 26);
            this.lblReference.TabIndex = 19;
            this.lblReference.Text = "Reference";
            this.lblReference.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 150);
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
            this.dgView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(float);
            gridViewTextBoxColumn1.FieldName = "InvoiceNumber";
            gridViewTextBoxColumn1.HeaderText = "InvoiceNumber";
            gridViewTextBoxColumn1.Name = "InvoiceNumber";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 198;
            gridViewTextBoxColumn2.FieldName = "Operation";
            gridViewTextBoxColumn2.HeaderText = "Operation";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Operation";
            gridViewTextBoxColumn2.Width = 230;
            gridViewTextBoxColumn3.FieldName = "Note";
            gridViewTextBoxColumn3.HeaderText = "Note";
            gridViewTextBoxColumn3.Name = "Note";
            gridViewTextBoxColumn3.Width = 297;
            gridViewTextBoxColumn4.FieldName = "StockItemsCount";
            gridViewTextBoxColumn4.HeaderText = "Items Count";
            gridViewTextBoxColumn4.Name = "StockItemsCount";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 118;
            gridViewTextBoxColumn5.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn5.FieldName = "StockDate";
            gridViewTextBoxColumn5.FormatString = "yyyy-MM-dd HH:mm:ss";
            gridViewTextBoxColumn5.HeaderText = "Date";
            gridViewTextBoxColumn5.Name = "StockDate";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 230;
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
            this.dgView.Size = new System.Drawing.Size(843, 461);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // StockInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblDate;
        private Telerik.WinControls.UI.RadTextBox txtNote;
        private Telerik.WinControls.UI.RadLabel lblNote;
        private Telerik.WinControls.UI.RadTextBox txtReference;
        private Telerik.WinControls.UI.RadLabel lblReference;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadTextBox txtInvoiceNumber;
        private Telerik.WinControls.UI.RadLabel lblInvoiceNumber;
        private Telerik.WinControls.UI.RadDateTimePicker dtDate;
    }
}
