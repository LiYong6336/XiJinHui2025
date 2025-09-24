namespace XiJinHuiWindow.Forms
{
    partial class OwedForm
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwedForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ddStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblEnd = new Telerik.WinControls.UI.RadLabel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblSearch = new Telerik.WinControls.UI.RadLabel();
            this.lblStart = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ddStatus);
            this.radPanel1.Controls.Add(this.txtSearch);
            this.radPanel1.Controls.Add(this.dtpEnd);
            this.radPanel1.Controls.Add(this.dtpStart);
            this.radPanel1.Controls.Add(this.lblEnd);
            this.radPanel1.Controls.Add(this.btnSearch);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.lblSearch);
            this.radPanel1.Controls.Add(this.lblStart);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(871, 121);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            this.radPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel1_Paint);
            // 
            // ddStatus
            // 
            this.ddStatus.DropDownAnimationEnabled = true;
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "owed";
            radListDataItem2.Text = "paid";
            this.ddStatus.Items.Add(radListDataItem1);
            this.ddStatus.Items.Add(radListDataItem2);
            this.ddStatus.Location = new System.Drawing.Point(553, 12);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(204, 36);
            this.ddStatus.TabIndex = 24;
            this.ddStatus.Text = "owed";
            this.ddStatus.ThemeName = "MaterialPink";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 36);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.ThemeName = "MaterialPink";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(553, 54);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 36);
            this.dtpEnd.TabIndex = 22;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Text = "2025-01-18 11:19:39";
            this.dtpEnd.ThemeName = "MaterialPink";
            this.dtpEnd.Value = new System.DateTime(2025, 1, 18, 11, 19, 39, 806);
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(123, 54);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(238, 36);
            this.dtpStart.TabIndex = 22;
            this.dtpStart.TabStop = false;
            this.dtpStart.Text = "2025-01-18 11:19:39";
            this.dtpStart.ThemeName = "MaterialPink";
            this.dtpStart.Value = new System.DateTime(2025, 1, 18, 11, 19, 39, 806);
            // 
            // lblEnd
            // 
            this.lblEnd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(481, 59);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(37, 26);
            this.lblEnd.TabIndex = 19;
            this.lblEnd.Text = "End";
            this.lblEnd.ThemeName = "MaterialPink";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(789, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(464, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 26);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Status";
            this.radLabel1.ThemeName = "MaterialPink";
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 26);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            this.lblSearch.ThemeName = "MaterialPink";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(21, 59);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(43, 26);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Start";
            this.lblStart.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 121);
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
            gridViewTextBoxColumn1.FieldName = "SaleDate";
            gridViewTextBoxColumn1.FormatString = "yyyy-MM-dd";
            gridViewTextBoxColumn1.HeaderText = "SaleDate";
            gridViewTextBoxColumn1.Name = "SaleDate";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 126;
            gridViewTextBoxColumn2.FieldName = "ShowingInvoiceNumber";
            gridViewTextBoxColumn2.HeaderText = "Invoice";
            gridViewTextBoxColumn2.Name = "ShowingInvoiceNumber";
            gridViewTextBoxColumn2.Width = 122;
            gridViewTextBoxColumn3.FieldName = "InvoiceNumber";
            gridViewTextBoxColumn3.HeaderText = "Invoice";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "InvoiceNumber";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 118;
            gridViewTextBoxColumn4.FieldName = "TotalAmount";
            gridViewTextBoxColumn4.HeaderText = "Total";
            gridViewTextBoxColumn4.Name = "TotalAmount";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 122;
            gridViewTextBoxColumn5.FieldName = "GrandTotal";
            gridViewTextBoxColumn5.HeaderText = "GrandTotal";
            gridViewTextBoxColumn5.Name = "GrandTotal";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 122;
            gridViewTextBoxColumn6.FieldName = "OwedAmount";
            gridViewTextBoxColumn6.HeaderText = "OwedAmount";
            gridViewTextBoxColumn6.Name = "OwedAmount";
            gridViewTextBoxColumn6.Width = 122;
            gridViewTextBoxColumn7.FieldName = "Remark";
            gridViewTextBoxColumn7.HeaderText = "Remark";
            gridViewTextBoxColumn7.Name = "Remark";
            gridViewTextBoxColumn7.Width = 160;
            gridViewTextBoxColumn8.HeaderText = "Pay";
            gridViewTextBoxColumn8.Name = "colExecute";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 97;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(871, 488);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.dgView_CellFormatting);
            this.dgView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellClick);
            // 
            // OwedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owed";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmSaleTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblStart;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStart;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadLabel lblEnd;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadLabel lblSearch;
        private Telerik.WinControls.UI.RadDropDownList ddStatus;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
