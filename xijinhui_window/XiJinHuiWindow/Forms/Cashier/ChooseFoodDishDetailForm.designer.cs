namespace XiJinHuiWindow.Forms.Cashier
{
    partial class ChooseFoodDishDetailForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdDishDetails = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDishDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDishDetails.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gdDishDetails);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(651, 473);
            this.radPanel1.TabIndex = 16;
            // 
            // gdDishDetails
            // 
            this.gdDishDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDishDetails.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdDishDetails.MasterTemplate.AllowAddNewRow = false;
            this.gdDishDetails.MasterTemplate.AllowColumnReorder = false;
            this.gdDishDetails.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FullName";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.Name = "FullName";
            gridViewTextBoxColumn1.Width = 521;
            gridViewTextBoxColumn2.DataType = typeof(decimal);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.None;
            gridViewTextBoxColumn2.FieldName = "Price";
            gridViewTextBoxColumn2.HeaderText = "Price";
            gridViewTextBoxColumn2.Name = "Price";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 130;
            this.gdDishDetails.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gdDishDetails.MasterTemplate.EnableGrouping = false;
            this.gdDishDetails.MasterTemplate.ShowRowHeaderColumn = false;
            this.gdDishDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdDishDetails.Name = "gdDishDetails";
            this.gdDishDetails.ReadOnly = true;
            this.gdDishDetails.Size = new System.Drawing.Size(651, 473);
            this.gdDishDetails.TabIndex = 15;
            this.gdDishDetails.ThemeName = "Material";
            this.gdDishDetails.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gdDishDetails_CellDoubleClick);
            // 
            // ChooseFoodDishDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 473);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFoodDishDetailForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Detail";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.ChooseFoodDishDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDishDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDishDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdDishDetails;
    }
}