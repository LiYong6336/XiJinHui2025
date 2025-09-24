namespace XiJinHuiWindow.Forms
{
    partial class SetInvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetInvoicesForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtpInvoiceDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.txtInvoiceStart = new Telerik.WinControls.UI.RadTextBox();
            this.lblInvoiceStart = new Telerik.WinControls.UI.RadLabel();
            this.txtInvoiceCount = new Telerik.WinControls.UI.RadTextBox();
            this.lblEnglish = new Telerik.WinControls.UI.RadLabel();
            this.lblCode = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtpInvoiceDate);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.btnClear);
            this.radPanel1.Controls.Add(this.btnDelete);
            this.radPanel1.Controls.Add(this.btnModify);
            this.radPanel1.Controls.Add(this.txtInvoiceStart);
            this.radPanel1.Controls.Add(this.lblInvoiceStart);
            this.radPanel1.Controls.Add(this.txtInvoiceCount);
            this.radPanel1.Controls.Add(this.lblEnglish);
            this.radPanel1.Controls.Add(this.lblCode);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 197);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpInvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(128, 29);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(229, 36);
            this.dtpInvoiceDate.TabIndex = 22;
            this.dtpInvoiceDate.TabStop = false;
            this.dtpInvoiceDate.Text = "2025-01-18";
            this.dtpInvoiceDate.ThemeName = "MaterialPink";
            this.dtpInvoiceDate.Value = new System.DateTime(2025, 1, 18, 11, 19, 39, 806);
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
            this.btnCancel.TabIndex = 9;
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
            this.btnClear.TabIndex = 8;
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
            this.btnDelete.TabIndex = 10;
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
            // txtInvoiceStart
            // 
            this.txtInvoiceStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceStart.Location = new System.Drawing.Point(128, 88);
            this.txtInvoiceStart.Name = "txtInvoiceStart";
            this.txtInvoiceStart.Size = new System.Drawing.Size(229, 41);
            this.txtInvoiceStart.TabIndex = 1;
            this.txtInvoiceStart.ThemeName = "MaterialPink";
            // 
            // lblInvoiceStart
            // 
            this.lblInvoiceStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStart.Location = new System.Drawing.Point(16, 99);
            this.lblInvoiceStart.Name = "lblInvoiceStart";
            this.lblInvoiceStart.Size = new System.Drawing.Size(94, 26);
            this.lblInvoiceStart.TabIndex = 21;
            this.lblInvoiceStart.Text = "InvoiceStart";
            this.lblInvoiceStart.ThemeName = "MaterialPink";
            // 
            // txtInvoiceCount
            // 
            this.txtInvoiceCount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceCount.Location = new System.Drawing.Point(516, 24);
            this.txtInvoiceCount.Name = "txtInvoiceCount";
            this.txtInvoiceCount.Size = new System.Drawing.Size(229, 41);
            this.txtInvoiceCount.TabIndex = 1;
            this.txtInvoiceCount.ThemeName = "MaterialPink";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(404, 35);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(102, 26);
            this.lblEnglish.TabIndex = 21;
            this.lblEnglish.Text = "InvoiceCount";
            this.lblEnglish.ThemeName = "MaterialPink";
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(35, 34);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 26);
            this.lblCode.TabIndex = 19;
            this.lblCode.Text = "Date";
            this.lblCode.ThemeName = "MaterialPink";
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
            gridViewTextBoxColumn1.FieldName = "InvoiceDate";
            gridViewTextBoxColumn1.HeaderText = "Date";
            gridViewTextBoxColumn1.Name = "InvoiceDate";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "InvoiceCount";
            gridViewTextBoxColumn2.HeaderText = "Count";
            gridViewTextBoxColumn2.Name = "InvoiceCount";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "InvoiceStart";
            gridViewTextBoxColumn3.HeaderText = "Start";
            gridViewTextBoxColumn3.Name = "InvoiceStart";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "InvoiceEnd";
            gridViewTextBoxColumn4.HeaderText = "End";
            gridViewTextBoxColumn4.Name = "InvoiceEnd";
            gridViewTextBoxColumn4.Width = 150;
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
            this.dgView.Size = new System.Drawing.Size(841, 412);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // SetInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetInvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Invoice";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmSetInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtInvoiceCount;
        private Telerik.WinControls.UI.RadLabel lblEnglish;
        private Telerik.WinControls.UI.RadLabel lblCode;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadDateTimePicker dtpInvoiceDate;
        private Telerik.WinControls.UI.RadTextBox txtInvoiceStart;
        private Telerik.WinControls.UI.RadLabel lblInvoiceStart;
    }
}
