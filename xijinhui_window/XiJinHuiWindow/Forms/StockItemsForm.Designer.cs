namespace XiJinHuiWindow.Forms
{
    partial class StockItemsForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockItemsForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtExpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblExpDate = new Telerik.WinControls.UI.RadLabel();
            this.dtMfpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblMfpDate = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.ddIngredient = new Telerik.WinControls.UI.RadDropDownList();
            this.lblIngredient = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.txtPrice = new Telerik.WinControls.UI.RadTextBox();
            this.lblPrice = new Telerik.WinControls.UI.RadLabel();
            this.txtNote = new Telerik.WinControls.UI.RadTextBox();
            this.lblNote = new Telerik.WinControls.UI.RadLabel();
            this.txtQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.lblQuantity = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMfpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMfpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtExpDate);
            this.radPanel1.Controls.Add(this.lblExpDate);
            this.radPanel1.Controls.Add(this.dtMfpDate);
            this.radPanel1.Controls.Add(this.lblMfpDate);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.ddIngredient);
            this.radPanel1.Controls.Add(this.lblIngredient);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.txtPrice);
            this.radPanel1.Controls.Add(this.lblPrice);
            this.radPanel1.Controls.Add(this.txtNote);
            this.radPanel1.Controls.Add(this.lblNote);
            this.radPanel1.Controls.Add(this.txtQuantity);
            this.radPanel1.Controls.Add(this.lblQuantity);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 187);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // dtExpDate
            // 
            this.dtExpDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtExpDate.CustomFormat = "yyyy-MM-dd";
            this.dtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpDate.Location = new System.Drawing.Point(520, 130);
            this.dtExpDate.Name = "dtExpDate";
            this.dtExpDate.Size = new System.Drawing.Size(229, 36);
            this.dtExpDate.TabIndex = 44;
            this.dtExpDate.TabStop = false;
            this.dtExpDate.Text = "2024-12-11";
            this.dtExpDate.ThemeName = "MaterialPink";
            this.dtExpDate.Value = new System.DateTime(2024, 12, 11, 10, 25, 2, 633);
            // 
            // lblExpDate
            // 
            this.lblExpDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(408, 134);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(70, 26);
            this.lblExpDate.TabIndex = 43;
            this.lblExpDate.Text = "ExpDate";
            this.lblExpDate.ThemeName = "MaterialPink";
            // 
            // dtMfpDate
            // 
            this.dtMfpDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtMfpDate.CustomFormat = "yyyy-MM-dd";
            this.dtMfpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMfpDate.Location = new System.Drawing.Point(151, 130);
            this.dtMfpDate.Name = "dtMfpDate";
            this.dtMfpDate.Size = new System.Drawing.Size(229, 36);
            this.dtMfpDate.TabIndex = 44;
            this.dtMfpDate.TabStop = false;
            this.dtMfpDate.Text = "2024-12-11";
            this.dtMfpDate.ThemeName = "MaterialPink";
            this.dtMfpDate.Value = new System.DateTime(2024, 12, 11, 10, 25, 2, 633);
            // 
            // lblMfpDate
            // 
            this.lblMfpDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfpDate.Location = new System.Drawing.Point(39, 134);
            this.lblMfpDate.Name = "lblMfpDate";
            this.lblMfpDate.Size = new System.Drawing.Size(69, 26);
            this.lblMfpDate.TabIndex = 43;
            this.lblMfpDate.Text = "MfpDate";
            this.lblMfpDate.ThemeName = "MaterialPink";
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
            // ddIngredient
            // 
            this.ddIngredient.DropDownAnimationEnabled = true;
            this.ddIngredient.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddIngredient.Location = new System.Drawing.Point(151, 22);
            this.ddIngredient.Name = "ddIngredient";
            this.ddIngredient.Size = new System.Drawing.Size(229, 41);
            this.ddIngredient.TabIndex = 1;
            this.ddIngredient.ThemeName = "MaterialPink";
            this.ddIngredient.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddIngredient_SelectedIndexChanged);
            // 
            // lblIngredient
            // 
            this.lblIngredient.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(39, 35);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(80, 26);
            this.lblIngredient.TabIndex = 34;
            this.lblIngredient.Text = "Ingredient";
            this.lblIngredient.ThemeName = "MaterialPink";
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
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(151, 69);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(229, 45);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.ThemeName = "MaterialPink";
            this.txtPrice.Enter += new System.EventHandler(this.txtChinese_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtChinese_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(39, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 26);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price";
            this.lblPrice.ThemeName = "MaterialPink";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(520, 77);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(229, 41);
            this.txtNote.TabIndex = 5;
            this.txtNote.ThemeName = "MaterialPink";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(408, 88);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 26);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note";
            this.lblNote.ThemeName = "MaterialPink";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(520, 27);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(229, 41);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.ThemeName = "MaterialPink";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(408, 37);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 26);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 187);
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
            gridViewTextBoxColumn1.FieldName = "Ingredient.FullName";
            gridViewTextBoxColumn1.HeaderText = "Ingredient";
            gridViewTextBoxColumn1.Name = "InGreFullName";
            gridViewTextBoxColumn1.Width = 99;
            gridViewTextBoxColumn2.FieldName = "Operation";
            gridViewTextBoxColumn2.HeaderText = "Operation";
            gridViewTextBoxColumn2.Name = "Operation";
            gridViewTextBoxColumn2.Width = 149;
            gridViewTextBoxColumn3.FieldName = "Quantity";
            gridViewTextBoxColumn3.HeaderText = "Quantity";
            gridViewTextBoxColumn3.Name = "Quantity";
            gridViewTextBoxColumn3.Width = 149;
            gridViewTextBoxColumn4.FieldName = "Note";
            gridViewTextBoxColumn4.HeaderText = "Note";
            gridViewTextBoxColumn4.Name = "Note";
            gridViewTextBoxColumn4.Width = 148;
            gridViewTextBoxColumn5.DataType = typeof(decimal);
            gridViewTextBoxColumn5.FieldName = "MfpDate";
            gridViewTextBoxColumn5.HeaderText = "Mfp Date";
            gridViewTextBoxColumn5.Name = "MfpDate";
            gridViewTextBoxColumn5.Width = 149;
            gridViewTextBoxColumn6.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn6.FieldName = "ExpDate";
            gridViewTextBoxColumn6.FormatString = "yyyy-MM-dd";
            gridViewTextBoxColumn6.HeaderText = "Exp Date";
            gridViewTextBoxColumn6.Name = "ExpDate";
            gridViewTextBoxColumn6.Width = 147;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(841, 422);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // StockItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Items";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMfpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMfpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList ddIngredient;
        private Telerik.WinControls.UI.RadLabel lblIngredient;
        private Telerik.WinControls.UI.RadTextBox txtPrice;
        private Telerik.WinControls.UI.RadLabel lblPrice;
        private Telerik.WinControls.UI.RadTextBox txtNote;
        private Telerik.WinControls.UI.RadLabel lblNote;
        private Telerik.WinControls.UI.RadTextBox txtQuantity;
        private Telerik.WinControls.UI.RadLabel lblQuantity;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadDateTimePicker dtExpDate;
        private Telerik.WinControls.UI.RadLabel lblExpDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtMfpDate;
        private Telerik.WinControls.UI.RadLabel lblMfpDate;
    }
}
