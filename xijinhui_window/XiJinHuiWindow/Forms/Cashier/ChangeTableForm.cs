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
    public partial class ChangeTableForm : Telerik.WinControls.UI.RadForm
    {
        private SaleForm saleForm;
        private InvoiceSettingForm invoiceSettingForm;
        public List<DiningFloor> diningFloors;
        public List<DiningTable> diningTables;
        public List<SaleTable> busyTables;
        public List<int?> busyTablesId;

        public ChangeTableForm()
        {
            InitializeComponent();
        }
        public ChangeTableForm(SaleForm saleForm, InvoiceSettingForm invSettingForm)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.invoiceSettingForm = invSettingForm;
        }
        private void LoadData()
        {
            LoadDiningFloors();
            LoadDiningTables();
        }


        public async void LoadDiningFloors()
        {
            Response<List<DiningFloor>> resFloors = await HttpClientHelper.GetAsync<List<DiningFloor>>("dining_floor");
            diningFloors = resFloors.Data;
            CreateDiningFloorsButtons(diningFloors);

        }

        public async void LoadDiningTables()
        {

            Response<DiningTablesResponse> resTables = await HttpClientHelper.GetAsync<DiningTablesResponse>("dining_table", new Dictionary<string, string> {
                { "is_enable", "1"}
            });

            diningTables = resTables.Data.Dining;
            busyTables = resTables.Data.BusyTables;
            busyTablesId = busyTables.Select(s => s.DiningTableId).ToList();

            CreateDiningTablesButtons(diningTables);
        }


        private void CreateDiningTablesButtons(List<DiningTable> diningTables)
        {
            pnlContent.Controls.Clear();

            int buttonWidth = 150;
            int buttonHeight = 70;
            int padding = 10;
            int currentX = padding;
            int currentY = padding;

            int formWidth = this.ClientSize.Width;


            foreach (DiningTable df in diningTables)
            {
                int filteredBusyTablesCount = busyTables.Where(bt => bt.DiningTableId == df.Id).Count();

                RadButton button = new RadButton();
                button.Text = GeneralFunction.GetPropertyValue(df).ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.BackColor = filteredBusyTablesCount > 1 ? Color.Purple : busyTablesId.Contains(df.Id) ? Color.DarkRed : Color.LightBlue;
                button.ForeColor = busyTablesId.Contains(df.Id) ? Color.White : Color.Black;
                button.Font = PublicVariable.fontStyleByLanguage();
                button.ThemeName = "Material";
                button.Tag = df;

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                button.Location = new System.Drawing.Point(currentX, currentY);
                button.Click += new EventHandler(BtnTable_Click);
                pnlContent.Controls.Add(button);

                currentX += buttonWidth + padding;
            }
        }

        private async void BtnTable_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            DiningTable diningTable = btn.Tag as DiningTable;

            if (busyTablesId.Contains(diningTable.Id))
            {
                MessageBox.Show(AppLocalization.Translate("table_is_being_busy"));
                return;
            }
            try
            {


                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("change_table", new
                {
                    sale_table_id = saleForm.saleTable.Id,
                    dining_table_id = diningTable.Id,
                });
                saleForm.SetSaleTableResponseData(res);
                saleForm.CreateCartItems();
                saleForm.tableForm.LoadDiningTables();

                MessageBox.Show("Table have been change to: " + diningTable.EnglishName);
                this.Dispose();
                invoiceSettingForm.Dispose();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void CreateDiningFloorsButtons(List<DiningFloor> diningFloors)
        {
            int buttonWidth = 100;
            int buttonHeight = 50;
            int padding = 10;
            int currentX = padding;
            int currentY = padding;

            int formWidth = this.ClientSize.Width;

            List<DiningFloor> dFloors = diningFloors;
            dFloors.Insert(0, new DiningFloor { EnglishName = "All", ChineseName = "全部", KhmerName = "ទាំងអស់" });

            foreach (DiningFloor df in diningFloors)
            {
                RadButton button = new RadButton();
                button.Text = GeneralFunction.GetPropertyValue(df).ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.Font = PublicVariable.fontStyleByLanguage();
                button.ThemeName = "Material";
                button.Tag = df;
                button.Click += new EventHandler(BtnDiningFloor_Click);

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                button.Location = new System.Drawing.Point(currentX, currentY);
                pnlTop.Controls.Add(button);

                currentX += buttonWidth + padding;
            }
        }

        private void BtnDiningFloor_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            DiningFloor diningFloor = btn.Tag as DiningFloor;
            List<DiningTable> tables = diningTables;
            if (diningFloor.Id > 0) tables = diningTables.Where(t => t.DiningFloorId == diningFloor.Id).ToList();
            CreateDiningTablesButtons(tables);
        }

        private void TableForm1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            RadPanel panel = sender as RadPanel;
            if (panel != null)
            {
                int borderWidth = 2; // Thickness of the border
                Color borderColor = Color.Gray; // Color of the border

                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawLine(pen, 0, panel.Height - borderWidth, panel.Width, panel.Height - borderWidth);
                }
            }
        }
    }
}
