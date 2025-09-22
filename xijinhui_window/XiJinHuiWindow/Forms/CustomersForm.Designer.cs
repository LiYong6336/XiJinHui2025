namespace XiJinHuiWindow.Forms
{
    partial class CustomersForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.gridItems = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnTopup = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnTopup);
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
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(884, 6);
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
            gridViewTextBoxColumn23.FieldName = "Id";
            gridViewTextBoxColumn23.HeaderText = "Id";
            gridViewTextBoxColumn23.IsVisible = false;
            gridViewTextBoxColumn23.Name = "Id";
            gridViewTextBoxColumn23.Width = 85;
            gridViewTextBoxColumn24.FieldName = "Code";
            gridViewTextBoxColumn24.HeaderText = "Code";
            gridViewTextBoxColumn24.Name = "Code";
            gridViewTextBoxColumn24.Width = 59;
            gridViewTextBoxColumn25.FieldName = "EnglishName";
            gridViewTextBoxColumn25.HeaderText = "English";
            gridViewTextBoxColumn25.Name = "EnglishName";
            gridViewTextBoxColumn25.Width = 96;
            gridViewTextBoxColumn26.FieldName = "ChineseName";
            gridViewTextBoxColumn26.HeaderText = "Chinese";
            gridViewTextBoxColumn26.Name = "ChineseName";
            gridViewTextBoxColumn26.Width = 96;
            gridViewTextBoxColumn27.FieldName = "KhmerName";
            gridViewTextBoxColumn27.HeaderText = "Khmer";
            gridViewTextBoxColumn27.Name = "KhmerName";
            gridViewTextBoxColumn27.Width = 96;
            gridViewTextBoxColumn28.FieldName = "Phone";
            gridViewTextBoxColumn28.HeaderText = "Phone";
            gridViewTextBoxColumn28.Name = "Phone";
            gridViewTextBoxColumn28.Width = 96;
            gridViewTextBoxColumn29.FieldName = "Address";
            gridViewTextBoxColumn29.HeaderText = "Address";
            gridViewTextBoxColumn29.Name = "Address";
            gridViewTextBoxColumn29.Width = 168;
            gridViewTextBoxColumn30.FieldName = "Dob";
            gridViewTextBoxColumn30.HeaderText = "Dob";
            gridViewTextBoxColumn30.Name = "Dob";
            gridViewTextBoxColumn30.Width = 96;
            gridViewTextBoxColumn31.FieldName = "Gender";
            gridViewTextBoxColumn31.HeaderText = "Gender";
            gridViewTextBoxColumn31.Name = "Gender";
            gridViewTextBoxColumn31.Width = 96;
            gridViewTextBoxColumn32.FieldName = "Balance";
            gridViewTextBoxColumn32.HeaderText = "Balance";
            gridViewTextBoxColumn32.Name = "Balance";
            gridViewTextBoxColumn32.Width = 114;
            gridViewTextBoxColumn33.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn33.FieldName = "CreatedAt";
            gridViewTextBoxColumn33.HeaderText = "CreatedAt";
            gridViewTextBoxColumn33.Name = "CreatedAt";
            gridViewTextBoxColumn33.Width = 87;
            this.gridItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33});
            this.gridItems.MasterTemplate.EnableGrouping = false;
            this.gridItems.MasterTemplate.ShowRowHeaderColumn = false;
            this.gridItems.MasterTemplate.ViewDefinition = tableViewDefinition3;
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
            // btnTopup
            // 
            this.btnTopup.Location = new System.Drawing.Point(13, 6);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(110, 38);
            this.btnTopup.TabIndex = 50;
            this.btnTopup.Text = "Topup";
            this.btnTopup.ThemeName = "Material";
            this.btnTopup.Visible = false;
            this.btnTopup.Click += new System.EventHandler(this.btnTopup_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gridItems;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnTopup;
    }
}