namespace XiJinHuiWindow.Forms
{
    partial class DiningTablesForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.gridItems = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnNew);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1004, 50);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.ThemeName = "Material";
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.MediumBlue;
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.IconSize = 32;
            this.btnNew.Location = new System.Drawing.Point(937, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 38);
            this.btnNew.TabIndex = 46;
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
            this.btnDelete.Location = new System.Drawing.Point(876, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 38);
            this.btnDelete.TabIndex = 47;
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
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 85;
            gridViewTextBoxColumn2.FieldName = "DiningTableCode";
            gridViewTextBoxColumn2.HeaderText = "Code";
            gridViewTextBoxColumn2.Name = "DiningTableCode";
            gridViewTextBoxColumn3.FieldName = "EnglishName";
            gridViewTextBoxColumn3.HeaderText = "English";
            gridViewTextBoxColumn3.Name = "EnglishName";
            gridViewTextBoxColumn3.Width = 85;
            gridViewTextBoxColumn4.FieldName = "ChineseName";
            gridViewTextBoxColumn4.HeaderText = "Chinese";
            gridViewTextBoxColumn4.Name = "ChineseName";
            gridViewTextBoxColumn4.Width = 85;
            gridViewTextBoxColumn5.FieldName = "KhmerName";
            gridViewTextBoxColumn5.HeaderText = "Khmer";
            gridViewTextBoxColumn5.Name = "KhmerName";
            gridViewTextBoxColumn5.Width = 85;
            gridViewTextBoxColumn6.FieldName = "DiningFloorName";
            gridViewTextBoxColumn6.HeaderText = "Floor";
            gridViewTextBoxColumn6.Name = "DiningFloorName";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "Remark";
            gridViewTextBoxColumn7.HeaderText = "Remark";
            gridViewTextBoxColumn7.Name = "Remark";
            gridViewTextBoxColumn7.Width = 85;
            gridViewTextBoxColumn8.FieldName = "PersonCount";
            gridViewTextBoxColumn8.HeaderText = "PersonCount";
            gridViewTextBoxColumn8.Name = "PersonCount";
            gridViewTextBoxColumn8.Width = 85;
            gridViewTextBoxColumn9.FieldName = "TaxPercentage";
            gridViewTextBoxColumn9.HeaderText = "TaxPercentage";
            gridViewTextBoxColumn9.Name = "TaxPercentage";
            gridViewTextBoxColumn9.Width = 85;
            gridViewTextBoxColumn10.FieldName = "TaxFixPrice";
            gridViewTextBoxColumn10.HeaderText = "TaxFixPrice";
            gridViewTextBoxColumn10.Name = "TaxFixPrice";
            gridViewTextBoxColumn10.Width = 85;
            gridViewTextBoxColumn11.HeaderText = "RoomServicePercentage";
            gridViewTextBoxColumn11.Name = "RoomServicePercentage";
            gridViewTextBoxColumn11.Width = 85;
            gridViewTextBoxColumn12.FieldName = "RoomServiceFixPrice";
            gridViewTextBoxColumn12.HeaderText = "RoomServiceFixPrice";
            gridViewTextBoxColumn12.Name = "RoomServiceFixPrice";
            gridViewTextBoxColumn12.Width = 85;
            gridViewTextBoxColumn13.FieldName = "IsBroken";
            gridViewTextBoxColumn13.HeaderText = "IsBroken";
            gridViewTextBoxColumn13.Name = "IsBroken";
            gridViewTextBoxColumn13.Width = 85;
            gridViewTextBoxColumn14.FieldName = "IsEnable";
            gridViewTextBoxColumn14.HeaderText = "IsEnable";
            gridViewTextBoxColumn14.Name = "IsEnable";
            gridViewTextBoxColumn14.Width = 85;
            gridViewTextBoxColumn15.FieldName = "CalculationType";
            gridViewTextBoxColumn15.HeaderText = "CalculationType";
            gridViewTextBoxColumn15.Name = "CalculationType";
            gridViewTextBoxColumn15.Width = 85;
            gridViewTextBoxColumn16.FieldName = "FlagStatus";
            gridViewTextBoxColumn16.HeaderText = "Status";
            gridViewTextBoxColumn16.Name = "FlagStatus";
            gridViewTextBoxColumn16.Width = 85;
            gridViewTextBoxColumn17.FieldName = "CreatedAt";
            gridViewTextBoxColumn17.HeaderText = "CreatedAt";
            gridViewTextBoxColumn17.Name = "CreatedAt";
            gridViewTextBoxColumn17.Width = 120;
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
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17});
            this.gridItems.MasterTemplate.EnableGrouping = false;
            this.gridItems.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridItems.Name = "gridItems";
            this.gridItems.ReadOnly = true;
            this.gridItems.Size = new System.Drawing.Size(1004, 488);
            this.gridItems.TabIndex = 0;
            this.gridItems.ThemeName = "Material";
            this.gridItems.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridItems_CellClick);
            this.gridItems.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridItems_CellDoubleClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.gridItems);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 50);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1004, 488);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.ThemeName = "Material";
            // 
            // DiningTablesForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "DiningTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dining Tables";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
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
    }
}