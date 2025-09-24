namespace XiJinHuiWindow.Forms.Cashier
{
    partial class ChooseAnimalPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAnimalPartsForm));
            this.lbHead = new Telerik.WinControls.UI.RadCheckedListBox();
            this.lbTail = new Telerik.WinControls.UI.RadCheckedListBox();
            this.lbWhole = new Telerik.WinControls.UI.RadCheckedListBox();
            this.lbMix = new Telerik.WinControls.UI.RadCheckedListBox();
            this.lblHead = new Telerik.WinControls.UI.RadLabel();
            this.lblTail = new Telerik.WinControls.UI.RadLabel();
            this.lblWhole = new Telerik.WinControls.UI.RadLabel();
            this.lblMix = new Telerik.WinControls.UI.RadLabel();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbWhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.GroupItemSize = new System.Drawing.Size(200, 36);
            this.lbHead.ItemSize = new System.Drawing.Size(200, 36);
            this.lbHead.Location = new System.Drawing.Point(12, 68);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(275, 439);
            this.lbHead.TabIndex = 0;
            this.lbHead.ThemeName = "MaterialPink";
            this.lbHead.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lb_ItemCheckedChanged);
            // 
            // lbTail
            // 
            this.lbTail.GroupItemSize = new System.Drawing.Size(200, 28);
            this.lbTail.ItemSize = new System.Drawing.Size(200, 28);
            this.lbTail.Location = new System.Drawing.Point(293, 68);
            this.lbTail.Name = "lbTail";
            this.lbTail.Size = new System.Drawing.Size(275, 439);
            this.lbTail.TabIndex = 0;
            this.lbTail.ThemeName = "MaterialPink";
            this.lbTail.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lb_ItemCheckedChanged);
            // 
            // lbWhole
            // 
            this.lbWhole.GroupItemSize = new System.Drawing.Size(200, 28);
            this.lbWhole.ItemSize = new System.Drawing.Size(200, 28);
            this.lbWhole.Location = new System.Drawing.Point(574, 68);
            this.lbWhole.Name = "lbWhole";
            this.lbWhole.Size = new System.Drawing.Size(275, 439);
            this.lbWhole.TabIndex = 0;
            this.lbWhole.ThemeName = "MaterialPink";
            this.lbWhole.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lb_ItemCheckedChanged);
            // 
            // lbMix
            // 
            this.lbMix.GroupItemSize = new System.Drawing.Size(200, 28);
            this.lbMix.ItemSize = new System.Drawing.Size(200, 28);
            this.lbMix.Location = new System.Drawing.Point(855, 68);
            this.lbMix.Name = "lbMix";
            this.lbMix.Size = new System.Drawing.Size(275, 439);
            this.lbMix.TabIndex = 0;
            this.lbMix.ThemeName = "MaterialPink";
            this.lbMix.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lb_ItemCheckedChanged);
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(136, 27);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(41, 21);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Head";
            this.lblHead.ThemeName = "MaterialPink";
            // 
            // lblTail
            // 
            this.lblTail.Location = new System.Drawing.Point(407, 27);
            this.lblTail.Name = "lblTail";
            this.lblTail.Size = new System.Drawing.Size(31, 21);
            this.lblTail.TabIndex = 1;
            this.lblTail.Text = "Tail";
            this.lblTail.ThemeName = "MaterialPink";
            // 
            // lblWhole
            // 
            this.lblWhole.Location = new System.Drawing.Point(701, 26);
            this.lblWhole.Name = "lblWhole";
            this.lblWhole.Size = new System.Drawing.Size(47, 21);
            this.lblWhole.TabIndex = 1;
            this.lblWhole.Text = "Whole";
            this.lblWhole.ThemeName = "MaterialPink";
            // 
            // lblMix
            // 
            this.lblMix.Location = new System.Drawing.Point(976, 27);
            this.lblMix.Name = "lblMix";
            this.lblMix.Size = new System.Drawing.Size(31, 21);
            this.lblMix.TabIndex = 1;
            this.lblMix.Text = "Mix";
            this.lblMix.ThemeName = "MaterialPink";
            // 
            // btnSubmit
            // 
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSubmit.IconColor = System.Drawing.Color.Blue;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.IconSize = 32;
            this.btnSubmit.Location = new System.Drawing.Point(525, 525);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 54);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ChooseAnimalPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 591);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMix);
            this.Controls.Add(this.lblWhole);
            this.Controls.Add(this.lblTail);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lbMix);
            this.Controls.Add(this.lbWhole);
            this.Controls.Add(this.lbTail);
            this.Controls.Add(this.lbHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseAnimalPartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Part";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.ChooseAnimalPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbWhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckedListBox lbHead;
        private Telerik.WinControls.UI.RadCheckedListBox lbTail;
        private Telerik.WinControls.UI.RadCheckedListBox lbWhole;
        private Telerik.WinControls.UI.RadCheckedListBox lbMix;
        private Telerik.WinControls.UI.RadLabel lblHead;
        private Telerik.WinControls.UI.RadLabel lblTail;
        private Telerik.WinControls.UI.RadLabel lblWhole;
        private Telerik.WinControls.UI.RadLabel lblMix;
        private FontAwesome.Sharp.IconButton btnSubmit;
    }
}
