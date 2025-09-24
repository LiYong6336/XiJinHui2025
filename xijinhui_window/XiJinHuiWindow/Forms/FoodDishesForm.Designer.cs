namespace XiJinHuiWindow.Forms
{
    partial class FoodDishesForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnIngredients = new FontAwesome.Sharp.IconButton();
            this.btnCopyIngredients = new FontAwesome.Sharp.IconButton();
            this.btnShowDetail = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.gridItems = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.tooltipCopyIngredient = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipBtnIngredient = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.iconButton1);
            this.radPanel1.Controls.Add(this.txtSearch);
            this.radPanel1.Controls.Add(this.btnIngredients);
            this.radPanel1.Controls.Add(this.btnCopyIngredients);
            this.radPanel1.Controls.Add(this.btnShowDetail);
            this.radPanel1.Controls.Add(this.btnNew);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1004, 67);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(213, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 43);
            this.iconButton1.TabIndex = 54;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NullText = "Search...";
            this.txtSearch.Size = new System.Drawing.Size(193, 36);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.ThemeName = "MaterialPink";
            // 
            // btnIngredients
            // 
            this.btnIngredients.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btnIngredients.IconColor = System.Drawing.Color.Green;
            this.btnIngredients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngredients.IconSize = 32;
            this.btnIngredients.Location = new System.Drawing.Point(692, 6);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(59, 38);
            this.btnIngredients.TabIndex = 51;
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Visible = false;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnCopyIngredients
            // 
            this.btnCopyIngredients.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopyIngredients.IconColor = System.Drawing.Color.Blue;
            this.btnCopyIngredients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopyIngredients.IconSize = 32;
            this.btnCopyIngredients.Location = new System.Drawing.Point(757, 7);
            this.btnCopyIngredients.Name = "btnCopyIngredients";
            this.btnCopyIngredients.Size = new System.Drawing.Size(59, 38);
            this.btnCopyIngredients.TabIndex = 52;
            this.btnCopyIngredients.UseVisualStyleBackColor = true;
            this.btnCopyIngredients.Visible = false;
            this.btnCopyIngredients.Click += new System.EventHandler(this.btnCopyIngredients_Click);
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetail.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowDetail.IconColor = System.Drawing.Color.MediumBlue;
            this.btnShowDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowDetail.IconSize = 32;
            this.btnShowDetail.Location = new System.Drawing.Point(884, 6);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(55, 38);
            this.btnShowDetail.TabIndex = 48;
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Visible = false;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.MediumBlue;
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.IconSize = 32;
            this.btnNew.Location = new System.Drawing.Point(945, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 38);
            this.btnNew.TabIndex = 48;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(823, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 38);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridItems
            // 
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridItems.MasterTemplate.AllowAddNewRow = false;
            this.gridItems.MasterTemplate.AllowDeleteRow = false;
            this.gridItems.MasterTemplate.AllowDragToGroup = false;
            this.gridItems.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.FieldName = "FoodCode";
            gridViewTextBoxColumn2.HeaderText = "Code";
            gridViewTextBoxColumn2.Name = "FoodCode";
            gridViewTextBoxColumn2.Width = 60;
            gridViewTextBoxColumn3.FieldName = "EnglishName";
            gridViewTextBoxColumn3.HeaderText = "English";
            gridViewTextBoxColumn3.Name = "EnglishName";
            gridViewTextBoxColumn3.Width = 102;
            gridViewTextBoxColumn4.FieldName = "ChineseName";
            gridViewTextBoxColumn4.HeaderText = "Chinese";
            gridViewTextBoxColumn4.Name = "ChineseName";
            gridViewTextBoxColumn4.Width = 102;
            gridViewTextBoxColumn5.FieldName = "KhmerName";
            gridViewTextBoxColumn5.HeaderText = "Khmer";
            gridViewTextBoxColumn5.Name = "KhmerName";
            gridViewTextBoxColumn5.Width = 102;
            gridViewTextBoxColumn6.FieldName = "FoodPrice";
            gridViewTextBoxColumn6.HeaderText = "Price";
            gridViewTextBoxColumn6.Name = "FoodPrice";
            gridViewTextBoxColumn6.Width = 102;
            gridViewTextBoxColumn7.FieldName = "CategoryName";
            gridViewTextBoxColumn7.HeaderText = "Category";
            gridViewTextBoxColumn7.Name = "CategoryName";
            gridViewTextBoxColumn7.Width = 179;
            gridViewTextBoxColumn8.FieldName = "Remark";
            gridViewTextBoxColumn8.HeaderText = "Remark";
            gridViewTextBoxColumn8.Name = "Remark";
            gridViewTextBoxColumn8.Width = 102;
            gridViewTextBoxColumn9.FieldName = "IsEnable";
            gridViewTextBoxColumn9.HeaderText = "IsEnable";
            gridViewTextBoxColumn9.Name = "IsEnable";
            gridViewTextBoxColumn9.Width = 102;
            gridViewTextBoxColumn10.FieldName = "DisplayOrder";
            gridViewTextBoxColumn10.HeaderText = "DisplayOrder";
            gridViewTextBoxColumn10.Name = "DisplayOrder";
            gridViewTextBoxColumn10.Width = 105;
            gridViewTextBoxColumn11.FieldName = "CreatedAt";
            gridViewTextBoxColumn11.HeaderText = "CreatedAt";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "CreatedAt";
            gridViewTextBoxColumn11.Width = 120;
            this.gridItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.gridItems.MasterTemplate.EnableGrouping = false;
            this.gridItems.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridItems.Name = "gridItems";
            this.gridItems.ReadOnly = true;
            this.gridItems.Size = new System.Drawing.Size(1004, 471);
            this.gridItems.TabIndex = 0;
            this.gridItems.ThemeName = "MaterialPink";
            this.gridItems.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridItems_CellClick);
            this.gridItems.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridItems_CellDoubleClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.gridItems);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 67);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1004, 471);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.ThemeName = "MaterialPink";
            // 
            // FoodDishesForm
            // 
            this.AcceptButton = this.iconButton1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FoodDishesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Dish";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gridItems;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnShowDetail;
        private FontAwesome.Sharp.IconButton btnIngredients;
        private FontAwesome.Sharp.IconButton btnCopyIngredients;
        private System.Windows.Forms.ToolTip tooltipCopyIngredient;
        private System.Windows.Forms.ToolTip tooltipBtnIngredient;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
    }
}