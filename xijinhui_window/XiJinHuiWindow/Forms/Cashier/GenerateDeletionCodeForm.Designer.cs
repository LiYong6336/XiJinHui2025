namespace XiJinHuiWindow.Forms.Cashier
{
    partial class GenerateDeletionCodeForm
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
            this.txtGeneratedCode = new Telerik.WinControls.UI.RadTextBox();
            this.txtVerifyCode = new Telerik.WinControls.UI.RadTextBox();
            this.btnGenerateCode = new FontAwesome.Sharp.IconButton();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeneratedCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerifyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.Enabled = false;
            this.txtGeneratedCode.Location = new System.Drawing.Point(78, 114);
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.Size = new System.Drawing.Size(181, 36);
            this.txtGeneratedCode.TabIndex = 0;
            this.txtGeneratedCode.ThemeName = "Material";
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(78, 202);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(218, 36);
            this.txtVerifyCode.TabIndex = 0;
            this.txtVerifyCode.ThemeName = "Material";
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerateCode.IconColor = System.Drawing.Color.Black;
            this.btnGenerateCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateCode.Location = new System.Drawing.Point(78, 27);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(222, 48);
            this.btnGenerateCode.TabIndex = 1;
            this.btnGenerateCode.Text = "Generate Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmit.IconColor = System.Drawing.Color.Black;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.Location = new System.Drawing.Point(78, 254);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(218, 48);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(78, 82);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Hash Code";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(78, 169);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Verify Code";
            // 
            // btnCopy
            // 
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopy.IconColor = System.Drawing.Color.Black;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.IconSize = 24;
            this.btnCopy.Location = new System.Drawing.Point(265, 115);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(35, 35);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // GenerateDeletionCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 364);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.txtGeneratedCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateDeletionCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Deletion Code";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.InvoiceSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGeneratedCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerifyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtGeneratedCode;
        private Telerik.WinControls.UI.RadTextBox txtVerifyCode;
        private FontAwesome.Sharp.IconButton btnGenerateCode;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private FontAwesome.Sharp.IconButton btnCopy;
    }
}
