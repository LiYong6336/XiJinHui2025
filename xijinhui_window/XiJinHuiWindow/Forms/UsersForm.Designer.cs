namespace XiJinHuiWindow.Forms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            this.cbIsAdmin = new Telerik.WinControls.UI.RadCheckBox();
            this.ddRole = new Telerik.WinControls.UI.RadDropDownList();
            this.ddLanguage = new Telerik.WinControls.UI.RadDropDownList();
            this.lblRole = new Telerik.WinControls.UI.RadLabel();
            this.lblLocale = new Telerik.WinControls.UI.RadLabel();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.lblPhone = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.lblUsername = new Telerik.WinControls.UI.RadLabel();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).BeginInit();
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
            this.radPanel1.Controls.Add(this.cbIsAdmin);
            this.radPanel1.Controls.Add(this.ddRole);
            this.radPanel1.Controls.Add(this.ddLanguage);
            this.radPanel1.Controls.Add(this.lblRole);
            this.radPanel1.Controls.Add(this.lblLocale);
            this.radPanel1.Controls.Add(this.txtPhone);
            this.radPanel1.Controls.Add(this.lblPhone);
            this.radPanel1.Controls.Add(this.txtPassword);
            this.radPanel1.Controls.Add(this.lblPassword);
            this.radPanel1.Controls.Add(this.txtUsername);
            this.radPanel1.Controls.Add(this.lblUsername);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(841, 197);
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
            this.btnCancel.TabIndex = 46;
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
            this.btnClear.TabIndex = 47;
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
            this.btnDelete.TabIndex = 49;
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
            this.btnModify.TabIndex = 48;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.Location = new System.Drawing.Point(524, 141);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(79, 19);
            this.cbIsAdmin.TabIndex = 38;
            this.cbIsAdmin.Text = "IsAdmin";
            this.cbIsAdmin.ThemeName = "MaterialPink";
            // 
            // ddRole
            // 
            this.ddRole.DropDownAnimationEnabled = true;
            this.ddRole.Location = new System.Drawing.Point(161, 127);
            this.ddRole.Name = "ddRole";
            this.ddRole.Size = new System.Drawing.Size(211, 36);
            this.ddRole.TabIndex = 37;
            this.ddRole.Text = "Select Role";
            this.ddRole.ThemeName = "MaterialPink";
            // 
            // ddLanguage
            // 
            this.ddLanguage.DropDownAnimationEnabled = true;
            this.ddLanguage.Location = new System.Drawing.Point(524, 80);
            this.ddLanguage.Name = "ddLanguage";
            this.ddLanguage.Size = new System.Drawing.Size(211, 36);
            this.ddLanguage.TabIndex = 37;
            this.ddLanguage.Text = "Select Language";
            this.ddLanguage.ThemeName = "MaterialPink";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(32, 137);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 26);
            this.lblRole.TabIndex = 27;
            this.lblRole.Text = "Role";
            this.lblRole.ThemeName = "MaterialPink";
            // 
            // lblLocale
            // 
            this.lblLocale.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocale.Location = new System.Drawing.Point(398, 90);
            this.lblLocale.Name = "lblLocale";
            this.lblLocale.Size = new System.Drawing.Size(80, 26);
            this.lblLocale.TabIndex = 27;
            this.lblLocale.Text = "Language";
            this.lblLocale.ThemeName = "MaterialPink";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(161, 77);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(211, 38);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.ThemeName = "MaterialPink";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(32, 90);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 26);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            this.lblPhone.ThemeName = "MaterialPink";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(527, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 38);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.ThemeName = "MaterialPink";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(398, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 26);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            this.lblPassword.ThemeName = "MaterialPink";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(164, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 41);
            this.txtUsername.TabIndex = 22;
            this.txtUsername.ThemeName = "MaterialPink";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(35, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 26);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            this.lblUsername.ThemeName = "MaterialPink";
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
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 112;
            gridViewTextBoxColumn2.FieldName = "Username";
            gridViewTextBoxColumn2.HeaderText = "Username";
            gridViewTextBoxColumn2.Name = "Username";
            gridViewTextBoxColumn2.Width = 169;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 112;
            gridViewTextBoxColumn4.FieldName = "Phone";
            gridViewTextBoxColumn4.HeaderText = "Phone";
            gridViewTextBoxColumn4.Name = "Phone";
            gridViewTextBoxColumn4.Width = 169;
            gridViewTextBoxColumn5.FieldName = "UserLocale";
            gridViewTextBoxColumn5.HeaderText = "Language";
            gridViewTextBoxColumn5.Name = "UserLocale";
            gridViewTextBoxColumn5.Width = 169;
            gridViewTextBoxColumn6.FieldName = "IsAdmin";
            gridViewTextBoxColumn6.HeaderText = "IsAdmin";
            gridViewTextBoxColumn6.Name = "IsAdmin";
            gridViewTextBoxColumn6.Width = 110;
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
            this.dgView.Size = new System.Drawing.Size(841, 412);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblLocale;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel lblPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadLabel lblUsername;
        private Telerik.WinControls.UI.RadGridView dgView;
        private Telerik.WinControls.UI.RadDropDownList ddLanguage;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadLabel lblPhone;
        private Telerik.WinControls.UI.RadCheckBox cbIsAdmin;
        private Telerik.WinControls.UI.RadDropDownList ddRole;
        private Telerik.WinControls.UI.RadLabel lblRole;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
    }
}
