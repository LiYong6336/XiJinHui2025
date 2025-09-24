using XiJinHuiWindow.Models;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class ChooseSpliteTableForm : Telerik.WinControls.UI.RadForm
    {
        private TableForm tableForm;
        private List<SaleTable> saleTables;
        public ChooseSpliteTableForm()
        {
            InitializeComponent();
        }

        public ChooseSpliteTableForm(TableForm tableForm, List<SaleTable> saleTables)
        {
            InitializeComponent();
            this.tableForm = tableForm;
            this.saleTables = saleTables;
        }
        private void ChooseSpliteTableForm_Load(object sender, EventArgs e)
        {
            CreateTableButtons(saleTables);
        }

        private void CreateTableButtons(List<SaleTable> saleTables)
        {
            pnlInvoice.Controls.Clear();

            int buttonWidth = 140;
            int buttonHeight = 70;
            int padding = 10;
            int currentX = padding;
            int currentY = padding;

            int formWidth = this.pnlInvoice.Width;

            Debug.WriteLine("SaleTable: " + saleTables.Count);

            int i = 1;
            foreach (SaleTable df in saleTables)
            {
                RadButton button = new RadButton();
                button.Text = AppLocalization.Translate("invoice") + " " + i;
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.BackColor = Color.LightBlue;
                button.ForeColor = Color.Black;
                button.Font = PublicVariable.fontStyleByLanguage();
                button.ThemeName = "MaterialPink";
                button.Tag = df;

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                button.Location = new System.Drawing.Point(currentX, currentY);
                button.Click += new EventHandler(BtnTable_Click);
                pnlInvoice.Controls.Add(button);

                currentX += buttonWidth + padding;
                i++;
            }
        }



        private void BtnTable_Click(object sender, EventArgs e)
        {
            // open sale form
            RadButton btn = (RadButton)sender;
            SaleTable st = (SaleTable)btn.Tag;
            SaleForm saleForm = new SaleForm(tableForm, st);
            saleForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
