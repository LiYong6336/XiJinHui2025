namespace XiJinHuiWindow.Forms
{
    partial class StockOutsForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutsForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.ddOperation = new Telerik.WinControls.UI.RadDropDownList();
            this.lblOperation = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.lblDate = new Telerik.WinControls.UI.RadLabel();
            this.txtNote = new Telerik.WinControls.UI.RadTextBox();
            this.lblNote = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtDate);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.ddOperation);
            this.radPanel1.Controls.Add(this.lblOperation);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.lblDate);
            this.radPanel1.Controls.Add(this.txtNote);
            this.radPanel1.Controls.Add(this.lblNote);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 152);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            this.radPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel1_Paint);
            // 
            // dtDate
            // 
            this.dtDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtDate.CustomFormat = "yyyy-MM-dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(520, 17);
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
            // ddOperation
            // 
            this.ddOperation.DropDownAnimationEnabled = true;
            this.ddOperation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddOperation.Location = new System.Drawing.Point(151, 12);
            this.ddOperation.Name = "ddOperation";
            this.ddOperation.Size = new System.Drawing.Size(229, 41);
            this.ddOperation.TabIndex = 2;
            this.ddOperation.ThemeName = "MaterialPink";
            // 
            // lblOperation
            // 
            this.lblOperation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(39, 25);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(79, 26);
            this.lblOperation.TabIndex = 34;
            this.lblOperation.Text = "Operation";
            this.lblOperation.ThemeName = "MaterialPink";
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
            this.lblDate.Location = new System.Drawing.Point(408, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 26);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date";
            this.lblDate.ThemeName = "MaterialPink";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(151, 73);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(598, 41);
            this.txtNote.TabIndex = 5;
            this.txtNote.ThemeName = "MaterialPink";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(39, 84);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 26);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note";
            this.lblNote.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 152);
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
            gridViewTextBoxColumn1.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn1.FieldName = "StockDate";
            gridViewTextBoxColumn1.FormatString = "yyyy-MM-dd HH:mm:ss";
            gridViewTextBoxColumn1.HeaderText = "Date";
            gridViewTextBoxColumn1.Name = "StockDate";
            gridViewTextBoxColumn1.Width = 281;
            gridViewTextBoxColumn2.DataType = typeof(float);
            gridViewTextBoxColumn2.FieldName = "InvoiceNumber";
            gridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "InvoiceNumber";
            gridViewTextBoxColumn2.Width = 153;
            gridViewTextBoxColumn3.FieldName = "Operation";
            gridViewTextBoxColumn3.HeaderText = "Operation";
            gridViewTextBoxColumn3.Name = "Operation";
            gridViewTextBoxColumn3.Width = 280;
            gridViewTextBoxColumn4.FieldName = "Note";
            gridViewTextBoxColumn4.HeaderText = "Note";
            gridViewTextBoxColumn4.Name = "Note";
            gridViewTextBoxColumn4.Width = 280;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(841, 457);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // StockOutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockOutsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).EndInit();
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
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadDateTimePicker dtDate;
        private Telerik.WinControls.UI.RadDropDownList ddOperation;
        private Telerik.WinControls.UI.RadLabel lblOperation;
    }
}
