namespace XiJinHuiWindow.Forms.Cashier
{
    partial class ChangeTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTableForm));
            this.pnlTop = new Telerik.WinControls.UI.RadPanel();
            this.pnlFoot = new Telerik.WinControls.UI.RadPanel();
            this.pnlContent = new Telerik.WinControls.UI.RadPanel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1022, 76);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.ThemeName = "Material";
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // pnlFoot
            // 
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFoot.Location = new System.Drawing.Point(0, 631);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(1022, 100);
            this.pnlFoot.TabIndex = 1;
            this.pnlFoot.ThemeName = "Material";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 76);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1022, 555);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.ThemeName = "Material";
            // 
            // ChangeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFoot);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Table";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.TableForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel pnlTop;
        private Telerik.WinControls.UI.RadPanel pnlFoot;
        private Telerik.WinControls.UI.RadPanel pnlContent;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}
