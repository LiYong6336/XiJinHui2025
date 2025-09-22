using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Reports.Cashier;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class TableForm : Telerik.WinControls.UI.RadForm
    {
        public List<DiningFloor> diningFloors;
        public List<DiningTable> diningTables;
        public List<SaleTable> busyTables;
        public List<int?> busyTablesId;
        public List<Printer> printers = new List<Printer>();

        private Timer timer;

        public TableForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000 * 5; // Set interval to 1 second (1000 ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void LoadData()
        {
            LoadDiningFloors();
            LoadDiningTables();
            LoadPrinters();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadDiningTables();
        }

        private async void LoadPrinters()
        {
            Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
            printers = res.Data;
        }


        public async void LoadDiningFloors()
        {
            Response<List<DiningFloor>> resFloors = await HttpClientHelper.GetAsync<List<DiningFloor>>("dining_floor");
            diningFloors = resFloors.Data;
            CreateDiningFloorsButtons(diningFloors);

        }
        int counter = 0;

        public async void LoadDiningTables()
        {
            Debug.WriteLine(counter);
            counter++;
            Response<DiningTablesResponse> resTables = await HttpClientHelper.GetAsync<DiningTablesResponse>("dining_table", new Dictionary<string, string>
            {
                {"is_enable", "1" }
            });

            diningTables = resTables.Data.Dining;
            busyTables = resTables.Data.BusyTables;
            busyTablesId = busyTables.Select(s => s.DiningTableId).ToList();

            CreateDiningTablesButtons(diningTables);

            PrintCustomerOrder(busyTables);
        }

        private async void PrintCustomerOrder(List<SaleTable> saleTables)
        {
            if (printers.Count == 0)
            {
                return;
            }
            foreach (SaleTable saleTable in saleTables)
            {
                List<SaleDetail> sDetails = saleTable.SaleDetails.Where(sd => sd.Qty > sd.OldQty).ToList();

                if (sDetails.Count > 0)
                {
                    var groupSaleDetails = sDetails.GroupBy(sd => sd.FoodDish.Category.PrinterId);

                    if (groupSaleDetails.Count() > 0)
                    {
                        foreach (var group in groupSaleDetails)
                        {
                            if (group.Key != null)
                            {
                                var fPrinters = printers.Where(pt => pt.Id == group.Key).ToList();
                                Printer p = fPrinters.Count() > 0 ? fPrinters[0] : printers[0];
                                ReportKitchen rpt = new ReportKitchen();
                                rpt.ReportParameters["CategoriesName"].Value = group.First().FoodDish.Category.EnglishName ?? "";
                                rpt.ReportParameters["tableID"].Value = saleTable.DiningTable.EnglishName;
                                rpt.ReportParameters["PersonCount"].Value = saleTable.PersonCount;
                                rpt.ReportParameters["UserName"].Value = PublicVariable.User.Name;
                                rpt.DataSource = group;
                                GeneralFunction.PrintReporting(rpt, p.DeviceName);
                            }
                        }
                    }

                    Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("print_new_items", new
                    {
                        sale_table_id = saleTable.Id,
                    });

                }
            }
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
                var name = GeneralFunction.GetPropertyValue(df);
                button.Text = name == null ? "" : name.ToString();
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

        private void BtnTable_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            DiningTable table = btn.Tag as DiningTable;
            SaleTable busyTable = busyTables.FirstOrDefault(s => s.DiningTableId == table.Id);

            List<SaleTable> filteredBusyTables = busyTables.Where(bt => bt.DiningTableId == table.Id).ToList();
            int filteredBusyTablesCount = filteredBusyTables.Count();
            if (filteredBusyTablesCount > 1)
            {
                ChooseSpliteTableForm chooseSpliteTableForm = new ChooseSpliteTableForm(this, filteredBusyTables);
                chooseSpliteTableForm.ShowDialog();
            }
            else if (busyTablesId.Contains(table.Id))
            {
                // open sale form
                SaleForm saleForm = new SaleForm(this, busyTable);
                saleForm.ShowDialog();


            }
            else
            {
                // show select person count
                PersonCountForm frm = new PersonCountForm(this, table);
                frm.ShowDialog();
                LoadDiningTables();
            }

        }

        private void CreateDiningFloorsButtons(List<DiningFloor> diningFloors)
        {
            int buttonWidth = 200;
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

                //if (currentX + buttonWidth + padding > formWidth)
                //{
                //    currentX = padding;
                //    currentY += buttonHeight + padding;
                //}

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

        private async void btnPrintDailySale_Click(object sender, EventArgs e)
        {
            //if (printers.Count == 0)
            //{
            //    MessageBox.Show("No printer found");
            //    return;
            //}

            ////var sDate = GeneralFunction.FormatStandardDatetime( DateTime.Now);
            ////var eDt = DateTime.Now;
            ////var eDate =
            //var now = DateTime.Now;
            //var sDate = now.Date;
            //var eDate = now.Date.AddDays(1).AddTicks(-1);

            //Response<List<SaleTable>> res = await HttpClientHelper.GetAsync<List<SaleTable>>("sale_tables", new Dictionary<string, string>
            //{
            //    {"start_date", GeneralFunction.FormatStandardDatetime(sDate)},
            //    { "end_date", GeneralFunction.FormatStandardDatetime(eDate)},
            //    { "owned", "true" },
            //});

            //ReportTotalInvoice rpt = new ReportTotalInvoice();


            //rpt.ReportParameters["dStart"].Value = sDate.ToString();
            //rpt.ReportParameters["dEnd"].Value = eDate.ToString();
            //rpt.ReportParameters["grandTotal"].Value = res.TotalAmount;
            //rpt.ReportParameters["totalMethod"].Value = res.TotalAmount2;
            //rpt.DataSource = res.Data;

            //GeneralFunction.PrintReporting(rpt, printers[0].DeviceName);
            StartDateEndDateTimeForm startDateEndDateTimeForm = new StartDateEndDateTimeForm(this);
            startDateEndDateTimeForm.ShowDialog();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            ReprintInvoiceForm reprintInvoiceForm = new ReprintInvoiceForm(this);
            reprintInvoiceForm.ShowDialog();
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            LoadDiningTables();
        }
    }
}
