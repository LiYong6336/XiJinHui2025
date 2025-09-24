namespace XiJinHuiWindow.Forms
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.txtUnitCapacity = new Telerik.WinControls.UI.RadTextBox();
            this.lblUnitCapacity = new Telerik.WinControls.UI.RadLabel();
            this.txtUnpackage = new Telerik.WinControls.UI.RadTextBox();
            this.lblUnpackage = new Telerik.WinControls.UI.RadLabel();
            this.txtKhmer = new Telerik.WinControls.UI.RadTextBox();
            this.lblKhmer = new Telerik.WinControls.UI.RadLabel();
            this.txtChinese = new Telerik.WinControls.UI.RadTextBox();
            this.lblChinese = new Telerik.WinControls.UI.RadLabel();
            this.txtEnglish = new Telerik.WinControls.UI.RadTextBox();
            this.lblEnglish = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnitCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnpackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnpackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).BeginInit();
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
            this.radPanel1.Controls.Add(this.txtUnitCapacity);
            this.radPanel1.Controls.Add(this.lblUnitCapacity);
            this.radPanel1.Controls.Add(this.txtUnpackage);
            this.radPanel1.Controls.Add(this.lblUnpackage);
            this.radPanel1.Controls.Add(this.txtKhmer);
            this.radPanel1.Controls.Add(this.lblKhmer);
            this.radPanel1.Controls.Add(this.txtChinese);
            this.radPanel1.Controls.Add(this.lblChinese);
            this.radPanel1.Controls.Add(this.txtEnglish);
            this.radPanel1.Controls.Add(this.lblEnglish);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(843, 198);
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
            this.btnCancel.TabIndex = 7;
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
            this.btnClear.TabIndex = 6;
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
            this.btnDelete.TabIndex = 8;
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
            this.btnModify.TabIndex = 5;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtUnitCapacity
            // 
            this.txtUnitCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCapacity.Location = new System.Drawing.Point(147, 144);
            this.txtUnitCapacity.Name = "txtUnitCapacity";
            this.txtUnitCapacity.Size = new System.Drawing.Size(229, 38);
            this.txtUnitCapacity.TabIndex = 4;
            this.txtUnitCapacity.ThemeName = "MaterialPink";
            // 
            // lblUnitCapacity
            // 
            this.lblUnitCapacity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCapacity.Location = new System.Drawing.Point(35, 157);
            this.lblUnitCapacity.Name = "lblUnitCapacity";
            this.lblUnitCapacity.Size = new System.Drawing.Size(100, 26);
            this.lblUnitCapacity.TabIndex = 25;
            this.lblUnitCapacity.Text = "UnitCapacity";
            this.lblUnitCapacity.ThemeName = "MaterialPink";
            // 
            // txtUnpackage
            // 
            this.txtUnpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnpackage.Location = new System.Drawing.Point(516, 90);
            this.txtUnpackage.Name = "txtUnpackage";
            this.txtUnpackage.Size = new System.Drawing.Size(229, 38);
            this.txtUnpackage.TabIndex = 3;
            this.txtUnpackage.ThemeName = "MaterialPink";
            // 
            // lblUnpackage
            // 
            this.lblUnpackage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpackage.Location = new System.Drawing.Point(404, 103);
            this.lblUnpackage.Name = "lblUnpackage";
            this.lblUnpackage.Size = new System.Drawing.Size(90, 26);
            this.lblUnpackage.TabIndex = 25;
            this.lblUnpackage.Text = "Unpackage";
            this.lblUnpackage.ThemeName = "MaterialPink";
            // 
            // txtKhmer
            // 
            this.txtKhmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhmer.Location = new System.Drawing.Point(147, 90);
            this.txtKhmer.Name = "txtKhmer";
            this.txtKhmer.Size = new System.Drawing.Size(229, 38);
            this.txtKhmer.TabIndex = 2;
            this.txtKhmer.ThemeName = "MaterialPink";
            this.txtKhmer.Enter += new System.EventHandler(this.txtKhmer_Enter);
            this.txtKhmer.Leave += new System.EventHandler(this.txtKhmer_Leave);
            // 
            // lblKhmer
            // 
            this.lblKhmer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhmer.Location = new System.Drawing.Point(35, 103);
            this.lblKhmer.Name = "lblKhmer";
            this.lblKhmer.Size = new System.Drawing.Size(56, 26);
            this.lblKhmer.TabIndex = 25;
            this.lblKhmer.Text = "Khmer";
            this.lblKhmer.ThemeName = "MaterialPink";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChinese.Location = new System.Drawing.Point(516, 15);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(229, 45);
            this.txtChinese.TabIndex = 1;
            this.txtChinese.ThemeName = "MaterialPink";
            this.txtChinese.Enter += new System.EventHandler(this.txtChinese_Enter);
            this.txtChinese.Leave += new System.EventHandler(this.txtChinese_Leave);
            // 
            // lblChinese
            // 
            this.lblChinese.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChinese.Location = new System.Drawing.Point(404, 27);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(68, 26);
            this.lblChinese.TabIndex = 23;
            this.lblChinese.Text = "Chinese";
            this.lblChinese.ThemeName = "MaterialPink";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(147, 19);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(229, 41);
            this.txtEnglish.TabIndex = 0;
            this.txtEnglish.ThemeName = "MaterialPink";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(35, 30);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(61, 26);
            this.lblEnglish.TabIndex = 21;
            this.lblEnglish.Text = "English";
            this.lblEnglish.ThemeName = "MaterialPink";
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 198);
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
            gridViewTextBoxColumn1.FieldName = "EnglishName";
            gridViewTextBoxColumn1.HeaderText = "ENGLISH";
            gridViewTextBoxColumn1.Name = "EnglishName";
            gridViewTextBoxColumn1.Width = 217;
            gridViewTextBoxColumn2.FieldName = "ChineseName";
            gridViewTextBoxColumn2.HeaderText = "CHINESE";
            gridViewTextBoxColumn2.Name = "ChineseName";
            gridViewTextBoxColumn2.Width = 217;
            gridViewTextBoxColumn3.FieldName = "KhmerName";
            gridViewTextBoxColumn3.HeaderText = "KHMER";
            gridViewTextBoxColumn3.Name = "KhmerName";
            gridViewTextBoxColumn3.Width = 217;
            gridViewTextBoxColumn4.FieldName = "Quantity";
            gridViewTextBoxColumn4.HeaderText = "Stock";
            gridViewTextBoxColumn4.Name = "Quantity";
            gridViewTextBoxColumn4.Width = 192;
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
            this.dgView.Size = new System.Drawing.Size(843, 413);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredients";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.FormIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnitCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnpackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnpackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox txtKhmer;
        private Telerik.WinControls.UI.RadLabel lblKhmer;
        private Telerik.WinControls.UI.RadTextBox txtChinese;
        private Telerik.WinControls.UI.RadLabel lblChinese;
        private Telerik.WinControls.UI.RadTextBox txtEnglish;
        private Telerik.WinControls.UI.RadLabel lblEnglish;
        private Telerik.WinControls.UI.RadGridView dgView;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private Telerik.WinControls.UI.RadTextBox txtUnitCapacity;
        private Telerik.WinControls.UI.RadLabel lblUnitCapacity;
        private Telerik.WinControls.UI.RadTextBox txtUnpackage;
        private Telerik.WinControls.UI.RadLabel lblUnpackage;
    }
}
