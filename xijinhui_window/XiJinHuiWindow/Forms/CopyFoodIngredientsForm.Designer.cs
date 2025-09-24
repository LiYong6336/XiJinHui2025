namespace XiJinHuiWindow.Forms
{
    partial class CopyFoodIngredientsForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyFoodIngredientsForm));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.dgView = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.pnlList = new Telerik.WinControls.UI.RadPanel();
            this.ckFoodDish = new Telerik.WinControls.UI.RadCheckedListBox();
            this.pnlActions = new Telerik.WinControls.UI.RadPanel();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.tooltipBtnSubmit = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckFoodDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EnableGestures = false;
            this.dgView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgView.MasterTemplate.AllowCellContextMenu = false;
            this.dgView.MasterTemplate.AllowColumnChooser = false;
            this.dgView.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.dgView.MasterTemplate.AllowColumnReorder = false;
            this.dgView.MasterTemplate.AllowColumnResize = false;
            this.dgView.MasterTemplate.AllowDragToGroup = false;
            this.dgView.MasterTemplate.AllowRowResize = false;
            this.dgView.MasterTemplate.AutoGenerateColumns = false;
            this.dgView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgView.MasterTemplate.EnableGrouping = false;
            this.dgView.MasterTemplate.EnableSorting = false;
            this.dgView.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(471, 611);
            this.dgView.TabIndex = 5;
            this.dgView.ThemeName = "MaterialPink";
            this.dgView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgView_CellDoubleClick);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dgView);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(471, 611);
            this.radPanel1.TabIndex = 6;
            this.radPanel1.ThemeName = "MaterialPink";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.pnlList);
            this.radPanel2.Controls.Add(this.pnlActions);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(471, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(372, 611);
            this.radPanel2.TabIndex = 7;
            this.radPanel2.ThemeName = "MaterialPink";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.ckFoodDish);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(372, 552);
            this.pnlList.TabIndex = 8;
            this.pnlList.ThemeName = "MaterialPink";
            // 
            // ckFoodDish
            // 
            this.ckFoodDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckFoodDish.GroupItemSize = new System.Drawing.Size(200, 36);
            this.ckFoodDish.ItemSize = new System.Drawing.Size(200, 36);
            this.ckFoodDish.Location = new System.Drawing.Point(0, 0);
            this.ckFoodDish.Name = "ckFoodDish";
            this.ckFoodDish.Size = new System.Drawing.Size(372, 552);
            this.ckFoodDish.TabIndex = 0;
            this.ckFoodDish.ThemeName = "MaterialPink";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnSubmit);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 552);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(372, 59);
            this.pnlActions.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSubmit.IconColor = System.Drawing.Color.Blue;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.IconSize = 32;
            this.btnSubmit.Location = new System.Drawing.Point(308, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(54, 41);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CopyFoodIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CopyFoodIngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Food Ingredients";
            this.ThemeName = "MaterialPink";
            this.Load += new System.EventHandler(this.FormIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckFoodDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).EndInit();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.MaterialPinkTheme materialTheme1;
        private Telerik.WinControls.UI.RadGridView dgView;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadCheckedListBox ckFoodDish;
        private Telerik.WinControls.UI.RadPanel pnlList;
        private Telerik.WinControls.UI.RadPanel pnlActions;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private System.Windows.Forms.ToolTip tooltipBtnSubmit;
    }
}
