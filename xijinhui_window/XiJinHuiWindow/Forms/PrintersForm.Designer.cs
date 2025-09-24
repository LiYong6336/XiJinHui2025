namespace XiJinHuiWindow.Forms
{
    partial class PrintersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintersForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.ddType = new Telerik.WinControls.UI.RadDropDownList();
            this.txtLocation = new Telerik.WinControls.UI.RadTextBox();
            this.lblLocation = new Telerik.WinControls.UI.RadLabel();
            this.lblType = new Telerik.WinControls.UI.RadLabel();
            this.txtPort = new Telerik.WinControls.UI.RadTextBox();
            this.lblPort = new Telerik.WinControls.UI.RadLabel();
            this.txtIp = new Telerik.WinControls.UI.RadTextBox();
            this.lblIp = new Telerik.WinControls.UI.RadLabel();
            this.txtBrand = new Telerik.WinControls.UI.RadTextBox();
            this.lblBrand = new Telerik.WinControls.UI.RadLabel();
            this.txtDeviceName = new Telerik.WinControls.UI.RadTextBox();
            this.lblDeviceName = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeviceName)).BeginInit();
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
            this.radPanel1.Controls.Add(this.ddType);
            this.radPanel1.Controls.Add(this.txtLocation);
            this.radPanel1.Controls.Add(this.lblLocation);
            this.radPanel1.Controls.Add(this.lblType);
            this.radPanel1.Controls.Add(this.txtPort);
            this.radPanel1.Controls.Add(this.lblPort);
            this.radPanel1.Controls.Add(this.txtIp);
            this.radPanel1.Controls.Add(this.lblIp);
            this.radPanel1.Controls.Add(this.txtBrand);
            this.radPanel1.Controls.Add(this.lblBrand);
            this.radPanel1.Controls.Add(this.txtDeviceName);
            this.radPanel1.Controls.Add(this.lblDeviceName);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(843, 197);
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
            this.btnCancel.TabIndex = 42;
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
            this.btnClear.TabIndex = 43;
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
            this.btnDelete.TabIndex = 45;
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
            this.btnModify.TabIndex = 44;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ddType
            // 
            this.ddType.DropDownAnimationEnabled = true;
            this.ddType.Location = new System.Drawing.Point(164, 133);
            this.ddType.Name = "ddType";
            this.ddType.Size = new System.Drawing.Size(219, 36);
            this.ddType.TabIndex = 37;
            this.ddType.Text = "SelectType";
            this.ddType.ThemeName = "MaterialPink";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(535, 128);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(219, 41);
            this.txtLocation.TabIndex = 29;
            this.txtLocation.ThemeName = "MaterialPink";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(406, 137);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 26);
            this.lblLocation.TabIndex = 27;
            this.lblLocation.Text = "Location";
            this.lblLocation.ThemeName = "MaterialPink";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(35, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 26);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Type";
            this.lblType.ThemeName = "MaterialPink";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(535, 71);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(219, 38);
            this.txtPort.TabIndex = 26;
            this.txtPort.ThemeName = "MaterialPink";
            // 
            // lblPort
            // 
            this.lblPort.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(406, 84);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 26);
            this.lblPort.TabIndex = 25;
            this.lblPort.Text = "Port";
            this.lblPort.ThemeName = "MaterialPink";
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(164, 69);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(219, 41);
            this.txtIp.TabIndex = 22;
            this.txtIp.ThemeName = "MaterialPink";
            // 
            // lblIp
            // 
            this.lblIp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.Location = new System.Drawing.Point(35, 80);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(22, 26);
            this.lblIp.TabIndex = 21;
            this.lblIp.Text = "Ip";
            this.lblIp.ThemeName = "MaterialPink";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(164, 19);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(219, 41);
            this.txtBrand.TabIndex = 22;
            this.txtBrand.ThemeName = "MaterialPink";
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(35, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 26);
            this.lblBrand.TabIndex = 21;
            this.lblBrand.Text = "Brand";
            this.lblBrand.ThemeName = "MaterialPink";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(535, 19);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(219, 41);
            this.txtDeviceName.TabIndex = 22;
            this.txtDeviceName.ThemeName = "MaterialPink";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(406, 30);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(101, 26);
            this.lblDeviceName.TabIndex = 21;
            this.lblDeviceName.Text = "DeviceName";
            this.lblDeviceName.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 197);
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
            gridViewTextBoxColumn1.FieldName = "PrinterBrand";
            gridViewTextBoxColumn1.HeaderText = "Brand";
            gridViewTextBoxColumn1.Name = "PrinterBrand";
            gridViewTextBoxColumn1.Width = 112;
            gridViewTextBoxColumn2.FieldName = "DeviceName";
            gridViewTextBoxColumn2.HeaderText = "DeviceName";
            gridViewTextBoxColumn2.Name = "DeviceName";
            gridViewTextBoxColumn2.Width = 169;
            gridViewTextBoxColumn3.FieldName = "PrinterIpAddress";
            gridViewTextBoxColumn3.HeaderText = "Ip";
            gridViewTextBoxColumn3.Name = "PrinterIpAddress";
            gridViewTextBoxColumn3.Width = 112;
            gridViewTextBoxColumn4.FieldName = "Port";
            gridViewTextBoxColumn4.HeaderText = "Port";
            gridViewTextBoxColumn4.Name = "Port";
            gridViewTextBoxColumn4.Width = 169;
            gridViewTextBoxColumn5.FieldName = "PrinterType";
            gridViewTextBoxColumn5.HeaderText = "Type";
            gridViewTextBoxColumn5.Name = "PrinterType";
            gridViewTextBoxColumn5.Width = 169;
            gridViewTextBoxColumn6.FieldName = "PrintLocation";
            gridViewTextBoxColumn6.HeaderText = "Location";
            gridViewTextBoxColumn6.Name = "PrintLocation";
            gridViewTextBoxColumn6.Width = 112;
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
            this.dgView.Size = new System.Drawing.Size(843, 414);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // PrintersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printers";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmPrinter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeviceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblType;
        private Telerik.WinControls.UI.RadTextBox txtPort;
        private Telerik.WinControls.UI.RadLabel lblPort;
        private Telerik.WinControls.UI.RadTextBox txtDeviceName;
        private Telerik.WinControls.UI.RadLabel lblDeviceName;
        private Telerik.WinControls.UI.RadGridView dgView;
        private Telerik.WinControls.UI.RadTextBox txtIp;
        private Telerik.WinControls.UI.RadLabel lblIp;
        private Telerik.WinControls.UI.RadTextBox txtBrand;
        private Telerik.WinControls.UI.RadLabel lblBrand;
        private Telerik.WinControls.UI.RadTextBox txtLocation;
        private Telerik.WinControls.UI.RadLabel lblLocation;
        private Telerik.WinControls.UI.RadDropDownList ddType;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
    }
}
