namespace XiJinHuiWindow.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.txtCurrentPassword = new Telerik.WinControls.UI.RadTextBox();
            this.lblCurrentPassword = new Telerik.WinControls.UI.RadLabel();
            this.lblNewPassword = new Telerik.WinControls.UI.RadLabel();
            this.txtNewPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblConfirmNewPassword = new Telerik.WinControls.UI.RadLabel();
            this.txtConfirmNewPassword = new Telerik.WinControls.UI.RadTextBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(35, 68);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(307, 36);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.ThemeName = "Material";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Location = new System.Drawing.Point(35, 41);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(119, 21);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "CurrentPassword";
            this.lblCurrentPassword.ThemeName = "Material";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Location = new System.Drawing.Point(35, 120);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 21);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "NewPassword";
            this.lblNewPassword.ThemeName = "Material";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(35, 147);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(307, 36);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.ThemeName = "Material";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Change";
            this.btnSave.ThemeName = "Material";
            this.btnSave.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnSave);
            this.radPanel1.Controls.Add(this.txtCurrentPassword);
            this.radPanel1.Controls.Add(this.lblConfirmNewPassword);
            this.radPanel1.Controls.Add(this.txtConfirmNewPassword);
            this.radPanel1.Controls.Add(this.lblNewPassword);
            this.radPanel1.Controls.Add(this.txtNewPassword);
            this.radPanel1.Controls.Add(this.lblCurrentPassword);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(379, 374);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Material";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(35, 202);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(152, 21);
            this.lblConfirmNewPassword.TabIndex = 4;
            this.lblConfirmNewPassword.Text = "ConfirmNewPassword";
            this.lblConfirmNewPassword.ThemeName = "Material";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(35, 229);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(307, 36);
            this.txtConfirmNewPassword.TabIndex = 5;
            this.txtConfirmNewPassword.ThemeName = "Material";
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 374);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtCurrentPassword;
        private Telerik.WinControls.UI.RadLabel lblCurrentPassword;
        private Telerik.WinControls.UI.RadLabel lblNewPassword;
        private Telerik.WinControls.UI.RadTextBox txtNewPassword;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel lblConfirmNewPassword;
        private Telerik.WinControls.UI.RadTextBox txtConfirmNewPassword;
    }
}
