namespace XiJinHuiWindow.Forms
{
    partial class StockCheckForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCheckForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtEndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblExpDate = new Telerik.WinControls.UI.RadLabel();
            this.dtStartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblMfpDate = new Telerik.WinControls.UI.RadLabel();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMfpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtEndDate);
            this.radPanel1.Controls.Add(this.lblExpDate);
            this.radPanel1.Controls.Add(this.dtStartDate);
            this.radPanel1.Controls.Add(this.lblMfpDate);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 79);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(520, 20);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(229, 36);
            this.dtEndDate.TabIndex = 44;
            this.dtEndDate.TabStop = false;
            this.dtEndDate.Text = "2024-12-11";
            this.dtEndDate.ThemeName = "MaterialPink";
            this.dtEndDate.Value = new System.DateTime(2024, 12, 11, 10, 25, 2, 633);
            // 
            // lblExpDate
            // 
            this.lblExpDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(408, 24);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(71, 26);
            this.lblExpDate.TabIndex = 43;
            this.lblExpDate.Text = "EndDate";
            this.lblExpDate.ThemeName = "MaterialPink";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(151, 20);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(229, 36);
            this.dtStartDate.TabIndex = 44;
            this.dtStartDate.TabStop = false;
            this.dtStartDate.Text = "2024-12-11";
            this.dtStartDate.ThemeName = "MaterialPink";
            this.dtStartDate.Value = new System.DateTime(2024, 12, 11, 10, 25, 2, 633);
            // 
            // lblMfpDate
            // 
            this.lblMfpDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfpDate.Location = new System.Drawing.Point(39, 24);
            this.lblMfpDate.Name = "lblMfpDate";
            this.lblMfpDate.Size = new System.Drawing.Size(77, 26);
            this.lblMfpDate.TabIndex = 43;
            this.lblMfpDate.Text = "StartDate";
            this.lblMfpDate.ThemeName = "MaterialPink";
            // 
            // btnModify
            // 
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnModify.IconColor = System.Drawing.Color.MediumBlue;
            this.btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModify.IconSize = 32;
            this.btnModify.Location = new System.Drawing.Point(774, 18);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(55, 38);
            this.btnModify.TabIndex = 7;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 79);
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
            gridViewTextBoxColumn1.FieldName = "Item.FullName";
            gridViewTextBoxColumn1.HeaderText = "Item";
            gridViewTextBoxColumn1.Name = "Item.FullName";
            gridViewTextBoxColumn1.Width = 414;
            gridViewTextBoxColumn2.FieldName = "Quantity";
            gridViewTextBoxColumn2.HeaderText = "Quantity";
            gridViewTextBoxColumn2.Name = "Quantity";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 232;
            gridViewTextBoxColumn3.FieldName = "TotalUsage";
            gridViewTextBoxColumn3.HeaderText = "Usage";
            gridViewTextBoxColumn3.Name = "TotalUsage";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 195;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(841, 530);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // StockCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Check";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMfpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadDateTimePicker dtEndDate;
        private Telerik.WinControls.UI.RadLabel lblExpDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtStartDate;
        private Telerik.WinControls.UI.RadLabel lblMfpDate;
    }
}
