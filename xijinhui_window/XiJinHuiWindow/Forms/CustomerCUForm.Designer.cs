namespace XiJinHuiWindow.Forms
{
    partial class CustomerCUForm
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
            this.lblCode = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtDob = new Telerik.WinControls.UI.RadDateTimePicker();
            this.ddGender = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.lblAddress = new Telerik.WinControls.UI.RadLabel();
            this.txtBalance = new Telerik.WinControls.UI.RadTextBox();
            this.lblGender = new Telerik.WinControls.UI.RadLabel();
            this.lblBalance = new Telerik.WinControls.UI.RadLabel();
            this.lblDob = new Telerik.WinControls.UI.RadLabel();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.lblPhone = new Telerik.WinControls.UI.RadLabel();
            this.txtKhmerName = new Telerik.WinControls.UI.RadTextBox();
            this.lblKhmer = new Telerik.WinControls.UI.RadLabel();
            this.txtChineseName = new Telerik.WinControls.UI.RadTextBox();
            this.lblChinese = new Telerik.WinControls.UI.RadLabel();
            this.txtEnglishName = new Telerik.WinControls.UI.RadTextBox();
            this.lblEnglish = new Telerik.WinControls.UI.RadLabel();
            this.txtCode = new Telerik.WinControls.UI.RadTextBox();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChineseName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(28, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            this.lblCode.ThemeName = "Material";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtDob);
            this.radPanel1.Controls.Add(this.ddGender);
            this.radPanel1.Controls.Add(this.btnSubmit);
            this.radPanel1.Controls.Add(this.txtAddress);
            this.radPanel1.Controls.Add(this.lblAddress);
            this.radPanel1.Controls.Add(this.txtBalance);
            this.radPanel1.Controls.Add(this.lblGender);
            this.radPanel1.Controls.Add(this.lblBalance);
            this.radPanel1.Controls.Add(this.lblDob);
            this.radPanel1.Controls.Add(this.txtPhone);
            this.radPanel1.Controls.Add(this.lblPhone);
            this.radPanel1.Controls.Add(this.txtKhmerName);
            this.radPanel1.Controls.Add(this.lblKhmer);
            this.radPanel1.Controls.Add(this.txtChineseName);
            this.radPanel1.Controls.Add(this.lblChinese);
            this.radPanel1.Controls.Add(this.txtEnglishName);
            this.radPanel1.Controls.Add(this.lblEnglish);
            this.radPanel1.Controls.Add(this.txtCode);
            this.radPanel1.Controls.Add(this.lblCode);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(630, 353);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "Material";
            this.radPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel1_Paint);
            // 
            // dtDob
            // 
            this.dtDob.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtDob.CustomFormat = "yyyy-MM-dd";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(233, 208);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(164, 36);
            this.dtDob.TabIndex = 8;
            this.dtDob.TabStop = false;
            this.dtDob.Text = "2024-09-04";
            this.dtDob.ThemeName = "Material";
            this.dtDob.Value = new System.DateTime(2024, 9, 4, 14, 42, 36, 581);
            // 
            // ddGender
            // 
            this.ddGender.DropDownAnimationEnabled = true;
            this.ddGender.Location = new System.Drawing.Point(440, 207);
            this.ddGender.Name = "ddGender";
            this.ddGender.Size = new System.Drawing.Size(178, 36);
            this.ddGender.TabIndex = 9;
            this.ddGender.Text = "Gender";
            this.ddGender.ThemeName = "Material";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 52);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.ThemeName = "Material";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(440, 123);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(167, 36);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.ThemeName = "Material";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(440, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.ThemeName = "Material";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(28, 207);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(173, 36);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.ThemeName = "Material";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(440, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 21);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            this.lblGender.ThemeName = "Material";
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(28, 180);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 21);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            this.lblBalance.ThemeName = "Material";
            // 
            // lblDob
            // 
            this.lblDob.Location = new System.Drawing.Point(233, 180);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(36, 21);
            this.lblDob.TabIndex = 0;
            this.lblDob.Text = "DOB";
            this.lblDob.ThemeName = "Material";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(233, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 36);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.ThemeName = "Material";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(233, 97);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 21);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            this.lblPhone.ThemeName = "Material";
            // 
            // txtKhmerName
            // 
            this.txtKhmerName.Location = new System.Drawing.Point(28, 124);
            this.txtKhmerName.Name = "txtKhmerName";
            this.txtKhmerName.Size = new System.Drawing.Size(167, 36);
            this.txtKhmerName.TabIndex = 4;
            this.txtKhmerName.ThemeName = "Material";
            this.txtKhmerName.Enter += new System.EventHandler(this.txtKhmerName_Enter);
            this.txtKhmerName.Leave += new System.EventHandler(this.txtKhmerName_Leave);
            // 
            // lblKhmer
            // 
            this.lblKhmer.Location = new System.Drawing.Point(28, 97);
            this.lblKhmer.Name = "lblKhmer";
            this.lblKhmer.Size = new System.Drawing.Size(50, 21);
            this.lblKhmer.TabIndex = 0;
            this.lblKhmer.Text = "Khmer";
            this.lblKhmer.ThemeName = "Material";
            // 
            // txtChineseName
            // 
            this.txtChineseName.Location = new System.Drawing.Point(440, 39);
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(173, 36);
            this.txtChineseName.TabIndex = 3;
            this.txtChineseName.ThemeName = "Material";
            this.txtChineseName.Enter += new System.EventHandler(this.txtChineseName_Enter);
            this.txtChineseName.Leave += new System.EventHandler(this.txtChineseName_Leave);
            // 
            // lblChinese
            // 
            this.lblChinese.Location = new System.Drawing.Point(440, 12);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(59, 21);
            this.lblChinese.TabIndex = 0;
            this.lblChinese.Text = "Chinese";
            this.lblChinese.ThemeName = "Material";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(233, 39);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(167, 36);
            this.txtEnglishName.TabIndex = 2;
            this.txtEnglishName.ThemeName = "Material";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Location = new System.Drawing.Point(233, 12);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(54, 21);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "English";
            this.lblEnglish.ThemeName = "Material";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(28, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(173, 36);
            this.txtCode.TabIndex = 1;
            this.txtCode.ThemeName = "Material";
            // 
            // CustomerCUForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 353);
            this.Controls.Add(this.radPanel1);
            this.Name = "CustomerCUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer CU";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CustomerCUForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhmerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKhmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChineseName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblCode;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadTextBox txtCode;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadTextBox txtKhmerName;
        private Telerik.WinControls.UI.RadLabel lblKhmer;
        private Telerik.WinControls.UI.RadTextBox txtChineseName;
        private Telerik.WinControls.UI.RadLabel lblChinese;
        private Telerik.WinControls.UI.RadTextBox txtEnglishName;
        private Telerik.WinControls.UI.RadLabel lblEnglish;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadLabel lblAddress;
        private Telerik.WinControls.UI.RadLabel lblDob;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadLabel lblPhone;
        private Telerik.WinControls.UI.RadDropDownList ddGender;
        private Telerik.WinControls.UI.RadTextBox txtBalance;
        private Telerik.WinControls.UI.RadLabel lblGender;
        private Telerik.WinControls.UI.RadLabel lblBalance;
        private Telerik.WinControls.UI.RadDateTimePicker dtDob;
    }
}
