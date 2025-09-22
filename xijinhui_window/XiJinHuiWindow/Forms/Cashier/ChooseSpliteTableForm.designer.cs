namespace XiJinHuiWindow.Forms.Cashier
{
    partial class ChooseSpliteTableForm
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
            this.pnlInvoice = new Telerik.WinControls.UI.RadPanel();
            this.panel1 = new Telerik.WinControls.UI.RadPanel();
            this.atLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.AutoScroll = true;
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.Location = new System.Drawing.Point(45, 102);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(321, 170);
            this.pnlInvoice.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(45, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 5);
            this.panel1.TabIndex = 13;
            // 
            // atLabel1
            // 
            this.atLabel1.BackColor = System.Drawing.Color.Transparent;
            this.atLabel1.Font = new System.Drawing.Font("Khmer OS Bokor", 20F, System.Drawing.FontStyle.Bold);
            this.atLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.atLabel1.Location = new System.Drawing.Point(122, 9);
            this.atLabel1.Name = "atLabel1";
            this.atLabel1.Size = new System.Drawing.Size(146, 65);
            this.atLabel1.TabIndex = 0;
            this.atLabel1.Text = "Split Table";
            // 
            // btnClose
            // 
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(45, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(321, 56);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChooseSpliteTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 396);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.atLabel1);
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChooseSpliteTableForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.ChooseSpliteTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panel1;
        private Telerik.WinControls.UI.RadLabel atLabel1;
        private Telerik.WinControls.UI.RadPanel pnlInvoice;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}