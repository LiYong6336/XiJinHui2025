namespace XiJinHuiWindow.Forms
{
    partial class DiningFloorsForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.lblDescription = new Telerik.WinControls.UI.RadLabel();
            this.txtMemo = new Telerik.WinControls.UI.RadTextBox();
            this.lblRemark = new Telerik.WinControls.UI.RadLabel();
            this.txtKhmer = new Telerik.WinControls.UI.RadTextBox();
            this.lblKhmer = new Telerik.WinControls.UI.RadLabel();
            this.txtChinese = new Telerik.WinControls.UI.RadTextBox();
            this.lblChinese = new Telerik.WinControls.UI.RadLabel();
            this.txtEnglish = new Telerik.WinControls.UI.RadTextBox();
            this.lblEnglish = new Telerik.WinControls.UI.RadLabel();
            this.txtCode = new Telerik.WinControls.UI.RadTextBox();
            this.lblCode = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
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
            this.radPanel1.Controls.Add(this.txtDescription);
            this.radPanel1.Controls.Add(this.lblDescription);
            this.radPanel1.Controls.Add(this.txtMemo);
            this.radPanel1.Controls.Add(this.lblRemark);
            this.radPanel1.Controls.Add(this.txtKhmer);
            this.radPanel1.Controls.Add(this.lblKhmer);
            this.radPanel1.Controls.Add(this.txtChinese);
            this.radPanel1.Controls.Add(this.lblChinese);
            this.radPanel1.Controls.Add(this.txtEnglish);
            this.radPanel1.Controls.Add(this.lblEnglish);
            this.radPanel1.Controls.Add(this.txtCode);
            this.radPanel1.Controls.Add(this.lblCode);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(843, 197);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.ThemeName = "Material";
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
            this.btnModify.TabIndex = 7;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(522, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 41);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.ThemeName = "Material";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(408, 132);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 26);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description";
            this.lblDescription.ThemeName = "Material";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.Location = new System.Drawing.Point(149, 123);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(229, 41);
            this.txtMemo.TabIndex = 5;
            this.txtMemo.ThemeName = "Material";
            // 
            // lblRemark
            // 
            this.lblRemark.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(35, 132);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(65, 26);
            this.lblRemark.TabIndex = 27;
            this.lblRemark.Text = "Remark";
            this.lblRemark.ThemeName = "Material";
            // 
            // txtKhmer
            // 
            this.txtKhmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhmer.Location = new System.Drawing.Point(522, 71);
            this.txtKhmer.Name = "txtKhmer";
            this.txtKhmer.Size = new System.Drawing.Size(229, 38);
            this.txtKhmer.TabIndex = 4;
            this.txtKhmer.ThemeName = "Material";
            this.txtKhmer.Enter += new System.EventHandler(this.txtKhmer_Enter);
            this.txtKhmer.Leave += new System.EventHandler(this.txtKhmer_Leave);
            // 
            // lblKhmer
            // 
            this.lblKhmer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhmer.Location = new System.Drawing.Point(408, 84);
            this.lblKhmer.Name = "lblKhmer";
            this.lblKhmer.Size = new System.Drawing.Size(56, 26);
            this.lblKhmer.TabIndex = 25;
            this.lblKhmer.Text = "Khmer";
            this.lblKhmer.ThemeName = "Material";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChinese.Location = new System.Drawing.Point(149, 72);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(229, 45);
            this.txtChinese.TabIndex = 3;
            this.txtChinese.ThemeName = "Material";
            this.txtChinese.Enter += new System.EventHandler(this.txtChinese_Enter);
            this.txtChinese.Leave += new System.EventHandler(this.txtChinese_Leave);
            // 
            // lblChinese
            // 
            this.lblChinese.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChinese.Location = new System.Drawing.Point(35, 84);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(68, 26);
            this.lblChinese.TabIndex = 23;
            this.lblChinese.Text = "Chinese";
            this.lblChinese.ThemeName = "Material";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(522, 23);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(229, 41);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.ThemeName = "Material";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(408, 34);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(61, 26);
            this.lblEnglish.TabIndex = 21;
            this.lblEnglish.Text = "English";
            this.lblEnglish.ThemeName = "Material";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(149, 24);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(229, 41);
            this.txtCode.TabIndex = 1;
            this.txtCode.ThemeName = "Material";
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(35, 34);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 26);
            this.lblCode.TabIndex = 19;
            this.lblCode.Text = "Code";
            this.lblCode.ThemeName = "Material";
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
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ctt_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.FieldName = "ParentId";
            gridViewTextBoxColumn2.HeaderText = "ParentId";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ParentId";
            gridViewTextBoxColumn3.FieldName = "PrinterId";
            gridViewTextBoxColumn3.HeaderText = "prt_id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "PrinterId";
            gridViewTextBoxColumn4.FieldName = "location";
            gridViewTextBoxColumn4.HeaderText = "location";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "col_location";
            gridViewTextBoxColumn5.FieldName = "FloorCode";
            gridViewTextBoxColumn5.HeaderText = "CODE";
            gridViewTextBoxColumn5.Name = "FloorCode";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.FieldName = "EnglishName";
            gridViewTextBoxColumn6.HeaderText = "ENGLISH";
            gridViewTextBoxColumn6.Name = "EnglishName";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "ChineseName";
            gridViewTextBoxColumn7.HeaderText = "CHINESE";
            gridViewTextBoxColumn7.Name = "ChineseName";
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.FieldName = "KhmerName";
            gridViewTextBoxColumn8.HeaderText = "KHMER";
            gridViewTextBoxColumn8.Name = "KhmerName";
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.FieldName = "Remark";
            gridViewTextBoxColumn9.HeaderText = "REMARK";
            gridViewTextBoxColumn9.Name = "Remark";
            gridViewTextBoxColumn9.Width = 150;
            gridViewTextBoxColumn10.FieldName = "Description";
            gridViewTextBoxColumn10.HeaderText = "Description";
            gridViewTextBoxColumn10.Name = "Description";
            gridViewTextBoxColumn10.Width = 150;
            this.dgView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(843, 414);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "Material";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // DiningFloorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiningFloorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dining Floors";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.frmDiningFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtMemo;
        private Telerik.WinControls.UI.RadLabel lblRemark;
        private Telerik.WinControls.UI.RadTextBox txtKhmer;
        private Telerik.WinControls.UI.RadLabel lblKhmer;
        private Telerik.WinControls.UI.RadTextBox txtChinese;
        private Telerik.WinControls.UI.RadLabel lblChinese;
        private Telerik.WinControls.UI.RadTextBox txtEnglish;
        private Telerik.WinControls.UI.RadLabel lblEnglish;
        private Telerik.WinControls.UI.RadTextBox txtCode;
        private Telerik.WinControls.UI.RadLabel lblCode;
        private Telerik.WinControls.UI.RadGridView dgView;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadLabel lblDescription;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
    }
}
