using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using XiJinHuiWindow.Utils;
using System.Linq;
using System.Diagnostics;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class PersonCountForm : Telerik.WinControls.UI.RadForm
    {
        private int selectedPersonCount = 0;
        private TableForm tableForm;
        private DiningTable diningTable;
        public PersonCountForm()
        {
            InitializeComponent();
        }
        public PersonCountForm(TableForm tableForm, DiningTable diningTable)
        {
            InitializeComponent();
            this.tableForm = tableForm;
            this.diningTable = diningTable;
        }
        private void CreateButtons()
        {
            pnlContent.Controls.Clear();

            int buttonWidth = 80;
            int buttonHeight = 50;
            int padding = 10;
            int currentX = padding;
            int currentY = padding;

            int formWidth = this.ClientSize.Width;


            foreach (int i in Enumerable.Range(1, 25).ToList())
            {
                RadButton button = new RadButton();
                button.Tag = i;
                button.Text = i.ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.BackColor = i == selectedPersonCount ? Color.DarkRed : Color.LightBlue;
                button.ForeColor = i == selectedPersonCount ? Color.White : Color.Black;
                button.Font = PublicVariable.fontStyleByLanguage();
                button.ThemeName = "Material";

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                button.Location = new System.Drawing.Point(currentX, currentY);
                button.Click += new EventHandler(Btn_Click);
                pnlContent.Controls.Add(button);

                currentX += buttonWidth + padding;
            }
        }

        private async void Btn_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            selectedPersonCount = (int)btn.Tag;
            try
            {

                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("getSaleTableAndSaleDetailByTableId", new
                {
                    dining_table_id = diningTable.Id,
                    person_count = btn.Text,
                });
                this.Dispose();
                SaleForm saleForm = new SaleForm(tableForm, res.Data);
                saleForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void TableForm1_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

    }
}
