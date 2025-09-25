namespace XiJinHuiWindow.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.lblUsername = new Telerik.WinControls.UI.RadLabel();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblVersion = new Telerik.WinControls.UI.RadLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.radPictureBox2 = new Telerik.WinControls.UI.RadPictureBox();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.lblIsAdmin = new Telerik.WinControls.UI.RadLabel();
            this.switchAdmin = new Telerik.WinControls.UI.RadToggleSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(66, 162);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(311, 36);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.ThemeName = "MaterialPink";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(66, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.ThemeName = "MaterialPink";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(66, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.ThemeName = "MaterialPink";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(66, 241);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(311, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "MaterialPink";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(66, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.ThemeName = "MaterialPink";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblVersion);
            this.radPanel1.Controls.Add(this.iconButton1);
            this.radPanel1.Controls.Add(this.radPictureBox2);
            this.radPanel1.Controls.Add(this.radPictureBox1);
            this.radPanel1.Controls.Add(this.btnCancel);
            this.radPanel1.Controls.Add(this.lblIsAdmin);
            this.radPanel1.Controls.Add(this.switchAdmin);
            this.radPanel1.Controls.Add(this.pictureBox1);
            this.radPanel1.Controls.Add(this.btnLogin);
            this.radPanel1.Controls.Add(this.txtUsername);
            this.radPanel1.Controls.Add(this.lblPassword);
            this.radPanel1.Controls.Add(this.txtPassword);
            this.radPanel1.Controls.Add(this.lblUsername);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(424, 496);
            this.radPanel1.TabIndex = 5;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(184, 464);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 18);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version:";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(389, 464);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 32);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // radPictureBox2
            // 
            this.radPictureBox2.Location = new System.Drawing.Point(24, 168);
            this.radPictureBox2.Name = "radPictureBox2";
            this.radPictureBox2.Size = new System.Drawing.Size(30, 30);
            this.radPictureBox2.SvgImageXml = resources.GetString("radPictureBox2.SvgImageXml");
            this.radPictureBox2.TabIndex = 8;
            this.radPictureBox2.ThemeName = "MaterialPink";
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Location = new System.Drawing.Point(24, 247);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.radPictureBox1.SvgImageXml = resources.GetString("radPictureBox1.SvgImageXml");
            this.radPictureBox1.TabIndex = 8;
            this.radPictureBox1.ThemeName = "MaterialPink";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "MaterialPink";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.Location = new System.Drawing.Point(184, 307);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(53, 21);
            this.lblIsAdmin.TabIndex = 7;
            this.lblIsAdmin.Text = "Setting";
            this.lblIsAdmin.ThemeName = "MaterialPink";
            // 
            // switchAdmin
            // 
            this.switchAdmin.Location = new System.Drawing.Point(107, 307);
            this.switchAdmin.Name = "switchAdmin";
            this.switchAdmin.Size = new System.Drawing.Size(50, 20);
            this.switchAdmin.TabIndex = 6;
            this.switchAdmin.ThemeName = "MaterialPink";
            this.switchAdmin.Value = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 496);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadLabel lblUsername;
        private Telerik.WinControls.UI.RadLabel lblPassword;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel lblIsAdmin;
        private Telerik.WinControls.UI.RadToggleSwitch switchAdmin;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox2;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Telerik.WinControls.UI.RadLabel lblVersion;
    }
}
