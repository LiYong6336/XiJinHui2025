namespace XiJinHuiWindow.Forms.Cashier
{
    partial class PersonCountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCountForm));
            this.pnlContent = new Telerik.WinControls.UI.RadPanel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(463, 316);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.ThemeName = "MaterialPink";
            // 
            // PersonCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 316);
            this.Controls.Add(this.pnlContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonCountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Person Count";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.TableForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel pnlContent;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
    }
}
