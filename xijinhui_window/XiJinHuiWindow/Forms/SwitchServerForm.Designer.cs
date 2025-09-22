namespace XiJinHuiWindow.Forms
{
    partial class SwitchServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwitchServerForm));
            this.txtOnlineServer = new Telerik.WinControls.UI.RadTextBox();
            this.lblOnlineServer = new Telerik.WinControls.UI.RadLabel();
            this.lblLocalServer = new Telerik.WinControls.UI.RadLabel();
            this.txtLocalServer = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.rbLocalServer = new Telerik.WinControls.UI.RadRadioButton();
            this.rbOnlineServer = new Telerik.WinControls.UI.RadRadioButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnlineServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOnlineServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocalServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbLocalServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOnlineServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOnlineServer
            // 
            this.txtOnlineServer.Location = new System.Drawing.Point(35, 68);
            this.txtOnlineServer.Name = "txtOnlineServer";
            this.txtOnlineServer.Size = new System.Drawing.Size(307, 36);
            this.txtOnlineServer.TabIndex = 0;
            this.txtOnlineServer.ThemeName = "Material";
            // 
            // lblOnlineServer
            // 
            this.lblOnlineServer.Location = new System.Drawing.Point(35, 41);
            this.lblOnlineServer.Name = "lblOnlineServer";
            this.lblOnlineServer.Size = new System.Drawing.Size(90, 21);
            this.lblOnlineServer.TabIndex = 1;
            this.lblOnlineServer.Text = "OnlineServer";
            this.lblOnlineServer.ThemeName = "Material";
            // 
            // lblLocalServer
            // 
            this.lblLocalServer.Location = new System.Drawing.Point(35, 120);
            this.lblLocalServer.Name = "lblLocalServer";
            this.lblLocalServer.Size = new System.Drawing.Size(84, 21);
            this.lblLocalServer.TabIndex = 3;
            this.lblLocalServer.Text = "LocalServer";
            this.lblLocalServer.ThemeName = "Material";
            // 
            // txtLocalServer
            // 
            this.txtLocalServer.Location = new System.Drawing.Point(35, 147);
            this.txtLocalServer.Name = "txtLocalServer";
            this.txtLocalServer.Size = new System.Drawing.Size(307, 36);
            this.txtLocalServer.TabIndex = 2;
            this.txtLocalServer.ThemeName = "Material";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "Material";
            this.btnSave.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.rbLocalServer);
            this.radPanel1.Controls.Add(this.rbOnlineServer);
            this.radPanel1.Controls.Add(this.btnSave);
            this.radPanel1.Controls.Add(this.txtOnlineServer);
            this.radPanel1.Controls.Add(this.lblLocalServer);
            this.radPanel1.Controls.Add(this.txtLocalServer);
            this.radPanel1.Controls.Add(this.lblOnlineServer);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(422, 311);
            this.radPanel1.TabIndex = 5;
            this.radPanel1.ThemeName = "Material";
            // 
            // rbLocalServer
            // 
            this.rbLocalServer.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.rbLocalServer.Location = new System.Drawing.Point(366, 156);
            this.rbLocalServer.Name = "rbLocalServer";
            this.rbLocalServer.Size = new System.Drawing.Size(16, 18);
            this.rbLocalServer.TabIndex = 6;
            this.rbLocalServer.TabStop = false;
            this.rbLocalServer.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbLocalServer_ToggleStateChanged);
            // 
            // rbOnlineServer
            // 
            this.rbOnlineServer.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.rbOnlineServer.Location = new System.Drawing.Point(366, 71);
            this.rbOnlineServer.Name = "rbOnlineServer";
            this.rbOnlineServer.Size = new System.Drawing.Size(16, 18);
            this.rbOnlineServer.TabIndex = 6;
            this.rbOnlineServer.TabStop = false;
            this.rbOnlineServer.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbOnlineServer_ToggleStateChanged);
            // 
            // SwitchServerForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SwitchServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch Server";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOnlineServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOnlineServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocalServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbLocalServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOnlineServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtOnlineServer;
        private Telerik.WinControls.UI.RadLabel lblOnlineServer;
        private Telerik.WinControls.UI.RadLabel lblLocalServer;
        private Telerik.WinControls.UI.RadTextBox txtLocalServer;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadRadioButton rbOnlineServer;
        private Telerik.WinControls.UI.RadRadioButton rbLocalServer;
    }
}
