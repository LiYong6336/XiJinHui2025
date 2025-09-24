namespace XiJinHuiWindow.Forms
{
    partial class AdminChooseForm
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
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnCashier = new FontAwesome.Sharp.IconButton();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Gauge;
            this.btnDashboard.IconColor = System.Drawing.Color.Black;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.Location = new System.Drawing.Point(65, 207);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(162, 86);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnCashier.IconColor = System.Drawing.Color.Black;
            this.btnCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCashier.Location = new System.Drawing.Point(233, 207);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(162, 86);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.Image = global::XiJinHuiWindow.Properties.Resources.logo;
            this.radPictureBox1.Location = new System.Drawing.Point(127, 12);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(215, 179);
            this.radPictureBox1.TabIndex = 1;
            // 
            // AdminChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.radPictureBox1);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnDashboard);
            this.Name = "AdminChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminChooseForm";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.AdminChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnCashier;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
    }
}
