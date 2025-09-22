namespace XiJinHuiWindow.Forms.Cashier
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.pnlTop = new Telerik.WinControls.UI.RadPanel();
            this.pnlFoot = new Telerik.WinControls.UI.RadPanel();
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.btnReprint = new FontAwesome.Sharp.IconButton();
            this.btnReloadTable = new FontAwesome.Sharp.IconButton();
            this.btnPrintDailySale = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new Telerik.WinControls.UI.RadPanel();
            this.MaterialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoot)).BeginInit();
            this.pnlFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.AutoScroll = true;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(1014, 88);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.ThemeName = "Material";
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // pnlFoot
            // 
            this.pnlFoot.Controls.Add(this.btnChangePassword);
            this.pnlFoot.Controls.Add(this.btnReprint);
            this.pnlFoot.Controls.Add(this.btnReloadTable);
            this.pnlFoot.Controls.Add(this.btnPrintDailySale);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFoot.Location = new System.Drawing.Point(0, 641);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(1014, 82);
            this.pnlFoot.TabIndex = 1;
            this.pnlFoot.ThemeName = "Material";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChangePassword.IconColor = System.Drawing.Color.Black;
            this.btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword.Location = new System.Drawing.Point(921, 8);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(81, 62);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnReprint.IconColor = System.Drawing.Color.Black;
            this.btnReprint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReprint.Location = new System.Drawing.Point(12, 8);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(81, 62);
            this.btnReprint.TabIndex = 0;
            this.btnReprint.UseVisualStyleBackColor = true;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // btnReloadTable
            // 
            this.btnReloadTable.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnReloadTable.IconColor = System.Drawing.Color.Black;
            this.btnReloadTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReloadTable.Location = new System.Drawing.Point(186, 8);
            this.btnReloadTable.Name = "btnReloadTable";
            this.btnReloadTable.Size = new System.Drawing.Size(81, 62);
            this.btnReloadTable.TabIndex = 0;
            this.btnReloadTable.UseVisualStyleBackColor = true;
            this.btnReloadTable.Click += new System.EventHandler(this.btnReloadTable_Click);
            // 
            // btnPrintDailySale
            // 
            this.btnPrintDailySale.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrintDailySale.IconColor = System.Drawing.Color.Black;
            this.btnPrintDailySale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrintDailySale.Location = new System.Drawing.Point(99, 8);
            this.btnPrintDailySale.Name = "btnPrintDailySale";
            this.btnPrintDailySale.Size = new System.Drawing.Size(81, 62);
            this.btnPrintDailySale.TabIndex = 0;
            this.btnPrintDailySale.UseVisualStyleBackColor = true;
            this.btnPrintDailySale.Click += new System.EventHandler(this.btnPrintDailySale_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 88);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1014, 553);
            this.pnlContent.TabIndex = 2;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 723);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFoot);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableForm";
            this.ThemeName = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TableForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoot)).EndInit();
            this.pnlFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel pnlTop;
        private Telerik.WinControls.UI.RadPanel pnlFoot;
        private Telerik.WinControls.UI.RadPanel pnlContent;
        private FontAwesome.Sharp.IconButton btnPrintDailySale;
        private Telerik.WinControls.Themes.MaterialTheme MaterialTheme1;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private FontAwesome.Sharp.IconButton btnReprint;
        private FontAwesome.Sharp.IconButton btnReloadTable;
    }
}
