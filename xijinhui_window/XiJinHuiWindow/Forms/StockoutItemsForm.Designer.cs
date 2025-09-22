namespace XiJinHuiWindow.Forms
{
    partial class StockoutItemsForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockoutItemsForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.mcbIngredient = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lblIngredient = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.txtNote = new Telerik.WinControls.UI.RadTextBox();
            this.lblNote = new Telerik.WinControls.UI.RadLabel();
            this.txtQuantity = new Telerik.WinControls.UI.RadTextBox();
            this.lblQuantity = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredient)).BeginInit();
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
            this.radPanel1.Controls.Add(this.mcbIngredient);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.lblIngredient);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.txtNote);
            this.radPanel1.Controls.Add(this.lblNote);
            this.radPanel1.Controls.Add(this.txtQuantity);
            this.radPanel1.Controls.Add(this.lblQuantity);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 153);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "Material";
            // 
            // mcbIngredient
            // 
            this.mcbIngredient.DisplayMember = "EnglishName";
            // 
            // mcbIngredient.NestedRadGridView
            // 
            this.mcbIngredient.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.mcbIngredient.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcbIngredient.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mcbIngredient.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mcbIngredient.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mcbIngredient.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.mcbIngredient.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.mcbIngredient.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.mcbIngredient.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.mcbIngredient.EditorControl.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "FullName";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "FullName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.AllowGroup = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ChineseName";
            gridViewTextBoxColumn3.HeaderText = "ChineseName";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ChineseName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.AllowGroup = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "KhmerName";
            gridViewTextBoxColumn4.HeaderText = "KhmerName";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "KhmerName";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.VisibleInColumnChooser = false;
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.AllowGroup = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Quantity";
            gridViewTextBoxColumn5.HeaderText = "Quantity";
            gridViewTextBoxColumn5.Name = "Quantity";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.VisibleInColumnChooser = false;
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.AllowGroup = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "UnPackage";
            gridViewTextBoxColumn6.HeaderText = "UnPackage";
            gridViewTextBoxColumn6.Name = "UnPackage";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.VisibleInColumnChooser = false;
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "UnitCapacity";
            gridViewTextBoxColumn7.HeaderText = "UnitCapacity";
            gridViewTextBoxColumn7.Name = "UnitCapacity";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.VisibleInColumnChooser = false;
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ChineseKeyword";
            gridViewTextBoxColumn8.HeaderText = "ChineseKeyword";
            gridViewTextBoxColumn8.MinWidth = 0;
            gridViewTextBoxColumn8.Name = "ChineseKeyword";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 150;
            this.mcbIngredient.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.mcbIngredient.EditorControl.MasterTemplate.EnableGrouping = false;
            this.mcbIngredient.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.mcbIngredient.EditorControl.MasterTemplate.ShowRowHeaderColumn = false;
            this.mcbIngredient.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.mcbIngredient.EditorControl.Name = "NestedRadGridView";
            this.mcbIngredient.EditorControl.ReadOnly = true;
            this.mcbIngredient.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mcbIngredient.EditorControl.ShowGroupPanel = false;
            this.mcbIngredient.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.mcbIngredient.EditorControl.TabIndex = 0;
            this.mcbIngredient.Location = new System.Drawing.Point(109, 14);
            this.mcbIngredient.Name = "mcbIngredient";
            this.mcbIngredient.Size = new System.Drawing.Size(638, 36);
            this.mcbIngredient.TabIndex = 47;
            this.mcbIngredient.TabStop = false;
            this.mcbIngredient.ThemeName = "Material";
            this.mcbIngredient.ValueMember = "Id";
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
            // lblIngredient
            // 
            this.lblIngredient.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(51, 24);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(40, 26);
            this.lblIngredient.TabIndex = 34;
            this.lblIngredient.Text = "Item";
            this.lblIngredient.ThemeName = "Material";
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
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(479, 72);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(268, 41);
            this.txtNote.TabIndex = 5;
            this.txtNote.ThemeName = "Material";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(406, 83);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 26);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note";
            this.lblNote.ThemeName = "Material";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(109, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(229, 41);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.ThemeName = "Material";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(20, 83);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 26);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.ThemeName = "Material";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 153);
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
            gridViewTextBoxColumn9.DataType = typeof(float);
            gridViewTextBoxColumn9.FieldName = "Item.FullName";
            gridViewTextBoxColumn9.HeaderText = "Item";
            gridViewTextBoxColumn9.Name = "ItemName";
            gridViewTextBoxColumn9.Width = 210;
            gridViewTextBoxColumn10.FieldName = "Quantity";
            gridViewTextBoxColumn10.HeaderText = "Quantity";
            gridViewTextBoxColumn10.Name = "Quantity";
            gridViewTextBoxColumn10.Width = 316;
            gridViewTextBoxColumn11.FieldName = "Note";
            gridViewTextBoxColumn11.HeaderText = "Note";
            gridViewTextBoxColumn11.Name = "Note";
            gridViewTextBoxColumn11.Width = 315;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(841, 456);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "Material";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // StockoutItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockoutItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out Items";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcbIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIngredient)).EndInit();
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
        private Telerik.WinControls.UI.RadLabel lblIngredient;
        private Telerik.WinControls.UI.RadTextBox txtNote;
        private Telerik.WinControls.UI.RadLabel lblNote;
        private Telerik.WinControls.UI.RadTextBox txtQuantity;
        private Telerik.WinControls.UI.RadLabel lblQuantity;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadMultiColumnComboBox mcbIngredient;
    }
}
