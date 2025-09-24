using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Properties;
using XiJinHuiWindow.Reports.Cashier;
using XiJinHuiWindow.Toolboxes;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using PorkeiCashier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class SaleForm : Telerik.WinControls.UI.RadForm
    {
        private Timer debounceTimer;
        private const int debounceInterval = 500;

        //private Action debouncedSizeChanged;
        public TableForm tableForm;

        private DiningFloor diningFloor;
        private DiningTable diningTable;
        public SaleTable saleTable;
        public List<SaleDetail> saleDetails;
        public List<Printer> printers = new List<Printer>();

        public List<FoodDish> foodDishes;
        public List<FoodDish> filteredFoodDishes;
        public List<Category> categories;

        private Category category;

        private int colCount = 0;
        private double foodItemWidth = 200.0;
        private double foodItemHeight = 100.0;

        private Dictionary<int?, Image> loadedImages = new Dictionary<int?, Image>();

        private bool isSearching = false;

        //DoubleBufferedPanel pnlItems;
        public SaleForm()
        {
            InitializeComponent();
        }
        public SaleForm(TableForm tableForm, SaleTable saleTable)
        {
            InitializeComponent();
            this.saleTable = saleTable;
            this.tableForm = tableForm;
            //SetDoubleBuffer(pnlItems, true);
            //this.CreateItemsPanel();
        }

        //private void CreateItemsPanel()
        //{
        //    pnlItems = new DoubleBufferedPanel();
        //    pnlItems.Dock = DockStyle.Fill;
        //    pnlItems.Name = "pnlItems";
        //    pnlItems.AutoSize = true;
        //    pnlItems.AutoScroll = true;
        //    pnlItems.MouseWheel += PnlItems_MouseWheel;
        //    pnlContent.Controls.Add(pnlItems);
        //}

        //private void PnlItems_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    var panel = sender as Panel;
        //    if (panel != null)
        //    {
        //        int scrollChange = e.Delta > 0 ? -20 : 20; // Adjust scroll increment
        //        panel.VerticalScroll.Value = Math.Max(0, Math.Min(panel.VerticalScroll.Maximum, panel.VerticalScroll.Value + scrollChange));
        //        panel.PerformLayout();
        //    }
        //}

        //static void SetDoubleBuffer(Control ctl, bool dblBuffer)
        //{
        //    try
        //    {
        //        typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
        //            null, ctl, new object[] { dblBuffer });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        public bool IsAdmin { get; set; }

        public async Task LoadSaleTable(object saleId)
        {
            Response<SaleTable> res = await HttpClientHelper.GetAsync<SaleTable>("sale_tables/" + saleId);
            SetSaleTableResponseData(res);
        }
        public async Task LoadPrinters()
        {
            Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
            printers = res.Data;
        }

        public void SetSaleTableResponseData(Response<SaleTable> res)
        {
            saleTable = res.Data;
            saleDetails = saleTable.SaleDetails;
            diningTable = saleTable.DiningTable;
            diningFloor = diningTable.DiningFloor;
        }

        private async Task LoadFoodDishes()
        {
            Response<FoodDishesResponse> res = await HttpClientHelper.GetAsync<FoodDishesResponse>("food_dish", new Dictionary<string, string>
            {
                { "with_categories" , "true"}
            });

            foodDishes = res.Data.FoodDishes;
            categories = res.Data.Categories;
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

        private void CreateCategoryButtons()
        {
            //pnlItems.Controls.Clear();
            int buttonWidth = 150;
            int buttonHeight = 50;
            int padding = 0;
            int currentX = padding;
            int currentY = padding;

            int formWidth = this.ClientSize.Width;

            List<Category> cats = categories;
            cats.Insert(0, new Category { EnglishName = "All", ChineseName = "全部", KhmerName = "ទាំងអស់" });

            foreach (Category df in cats)
            {
                RadButton button = new RadButton();
                button.Text = GeneralFunction.GetPropertyValue(df).ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.Font = PublicVariable.fontStyleByLanguage();
                button.ThemeName = "MaterialPink";
                button.Tag = df;
                button.Padding = new Padding(0);
                button.Click += new EventHandler(BtnCategory_Click);

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                button.Location = new System.Drawing.Point(currentX, currentY);
                gt.Controls.Add(button);

                currentX += buttonWidth + padding;
            }
        }

        public void CreateCartItems()
        {
            gdCart.Controls.Clear();
            List<SaleDetail> sDetails = new List<SaleDetail>();
            var i = 1;
            foreach (SaleDetail sd in saleDetails)
            {
                sd.QtyPrice = $"{sd.Qty} x {sd.FoodPrice}";
                //sd.Description = sd.Description + ""
                sd.NO = i;
                sDetails.Add(sd);
                i++;
            }
            gdCart.DataSource = sDetails;
            lblTotalValue.Text = Convert.ToDecimal(saleTable.TotalAmount).ToString("0.00");
            lblDiscountValue.Text = Convert.ToDecimal(saleTable.DiscountAmount).ToString("0.00");
            lblServiceValue.Text = Convert.ToDecimal(saleTable.RoomServiceAmount).ToString("0.00");
            lblVatValue.Text = Convert.ToDecimal(saleTable.TaxAmount).ToString("0.00");
            lblTotalPayValue.Text = Convert.ToDecimal(saleTable.GrandTotal).ToString("0.00");

            lblUserValue.Text = PublicVariable.User.Name;
            lblTableValue.Text = (string)GeneralFunction.GetPropertyValue(saleTable.DiningTable);
            lblDateValue.Text = DateTime.Parse(saleTable.CreatedAt).ToString();
            lblPeopleValue.Text = saleTable.PersonCount.ToString();

        }

        private bool searchString(string str, string search)
        {
            return str.ToLower().Contains(search.ToLower());
            //return str.ToLower().StartsWith(search.ToLower());
        }

        private void CreateFoodDishItems()
        {

            //pnlFoodDishes.Items = foodDishes;
            //await pnlFoodDishes.LoadImagesAsync();
            //pnlItems.SuspendLayout();
            pnlItems.Controls.Clear(); // DoubleBufferedPanel
            if (foodDishes == null) return;
            int buttonWidth = 150;
            int buttonHeight = 150;
            int padding = 10;
            int currentX = padding;
            int currentY = padding;

            int formWidth = pnlItems.ClientSize.Width;

            List<FoodDish> fDishes = foodDishes;
            if (txtSearch.Text.Length > 0)
            {


                var search = txtSearch.Text.Trim();
                if (chkAll.Checked == true)
                {
                    fDishes = fDishes.Where(fd => //searchString(fd.EnglishName ?? "", search) ||
                                                  //searchString(fd.ChineseName ?? "", search) ||
                                                  //searchString(fd.KhmerName ?? "", search) ||
                                                  //searchString(fd.EnglishKeyword ?? "", search) ||
                    searchString(fd.ChineseKeyword ?? "", search) ||
                   //searchString(fd.KhmerKeyword ?? "", search) ||
                   searchString(fd.FoodCode ?? "", search)
                   ).ToList();
                }
                else
                {
                    fDishes = fDishes.Where(fd => searchString(fd.ChineseKeyword ?? "", search) ||
                   searchString(fd.FoodCode ?? "", search)).ToList();
                }

            }

            if (category != null && category.Id != null)
            {
                fDishes = fDishes.Where(fd => fd.CategoryId == category.Id).ToList();
            }
            MouseEventHandler handleClick = this.FoodDish_Click;

            List<Control> fDishControls = new List<Control>();
            foreach (FoodDish fDish in fDishes)
            {
                if (isSearching) break;

                if (currentX + buttonWidth + padding > formWidth)
                {
                    currentX = padding;
                    currentY += buttonHeight + padding;
                }

                PanelExt pItem = new PanelExt();
                pItem.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                pItem.Location = new System.Drawing.Point(currentX, currentY);
                pItem.Tag = fDish;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Tag = fDish;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.BackColor = Color.White; // Placeholder background before loading image
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pItem.Controls.Add(pictureBox);

                Label lblName = new Label();
                lblName.Tag = fDish;
                lblName.Font = new System.Drawing.Font("Hanuman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblName.Text = fDish.ChineseName + "\n" + fDish.KhmerName;// fDish.GetNameConcat("\n");
                lblName.Height = 50;
                lblName.Dock = DockStyle.Bottom;
                lblName.BackColor = Color.White; // Color.FromArgb(128, Color.Black);
                lblName.ForeColor = Color.Black;
                lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                //lblName.Enabled = false;
                //lblName.Paint += LabelName_Paint;

                pictureBox.Controls.Add(lblName);

                Label lblPrice = new Label();
                lblPrice.Tag = fDish;
                lblPrice.Font = new System.Drawing.Font("Hanuman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblPrice.Text = fDish.FoodPrice.ToString();
                lblPrice.Height = 25;
                lblPrice.Dock = DockStyle.Bottom;
                lblPrice.BackColor = Color.White;// Color.FromArgb(128, Color.Black);
                lblPrice.ForeColor = Color.Black;
                lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                pictureBox.Controls.Add(lblPrice);

                pnlItems.Controls.Add(pItem);

                if (fDish.IsEnable == true)
                {
                    Application.DoEvents();
                    //lblName.MouseClick += handleClick;
                    //lblPrice.MouseClick += handleClick;
                    pictureBox.MouseClick += handleClick;
                    lblName.MouseClick += handleClick;
                }

                //Button pItem = new Button();
                //pItem.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                //pItem.Location = new System.Drawing.Point(currentX, currentY);
                //pItem.Tag = fDish;
                //pItem.Text = fDish.FullName + "\n" + fDish.FoodPrice;
                //if (fDish.IsEnable == true)
                //{
                //    Application.DoEvents();
                //    pItem.MouseClick += handleClick;
                //    pItem.MouseHover += FoodDish_MouseHover;
                //}



                //pItem.ForeColor = Color.White;
                //if (loadedImages.ContainsKey(fDish.Id))
                //{
                //    pItem.Image = loadedImages[fDish.Id];
                //}

                //if (fDish.FoodPhoto != null)
                //{
                //    var img = await GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
                //    Image resizedImage = GeneralFunction.ResizeAndCropImage(img, pItem.Size);
                //    pItem.Image = resizedImage;
                //    loadedImages[fDish.Id] = resizedImage;
                //}
                //else
                //{
                //    pItem.Image = new Bitmap(Resources.DRINK, pItem.Size); // Default image
                //    loadedImages[fDish.Id] = pItem.Image;
                //}

                currentX += buttonWidth + padding;
                fDishControls.Add(pItem);
            }
            pnlItems.Controls.AddRange(fDishControls.ToArray());
            //pnlItems.ResumeLayout();
            DrawImageOnVisible();
        }

        private void LabelName_Paint(object sender, PaintEventArgs e)
        {
            // Get the label control
            Label lbl = sender as Label;
            FoodDish fDish = lbl.Tag as FoodDish;

            // Set your custom color for the text
            Color customColor = Color.Black;
            SizeF textSize = e.Graphics.MeasureString(fDish.GetNameConcat("\n"), lbl.Font);

            float x = (lbl.Width - textSize.Width) / 2;
            float y = (lbl.Height - textSize.Height) / 2;
            // Use the Graphics object to draw the label text in the desired color
            e.Graphics.DrawString(fDish.GetNameConcat("\n"), lbl.Font, new SolidBrush(customColor), new PointF(x, y));
        }
        private void FoodDish_MouseHover(object sender, EventArgs e)
        {
            DrawImageOnVisible();
        }

        private async void FoodDish_Click(object sender, EventArgs e)
        {
            var ctl = (Control)sender;
            FoodDish fDish = ctl.Tag as FoodDish;
            List<SaleDetail> sDetails = saleDetails.Where(s => s.FoodDish.Id == fDish.Id).ToList();

            if (fDish.Category.IsAnimalPart)
            {
                QuantityForm qtyForm = new QuantityForm(this, saleTable, fDish);
                qtyForm.ShowDialog();
                return;
            }

            if (fDish.FoodDishDetails.Count > 0)
            {
                ChooseFoodDishDetailForm chooseFoodDishDetailForm = new ChooseFoodDishDetailForm(this, fDish);
                chooseFoodDishDetailForm.ShowDialog();
                return;
            }

            //if (sDetails.Count > 0)
            //{
            //    SaleDetail sDetail = sDetails[0];
            //    ChangeQty(sDetail, sDetail.Qty + 1);
            //    return;
            //}

            Response<SaleTable> res1 = await HttpClientHelper.PostAsync<SaleTable>("addSaleDetail", new
            {
                food_dish_id = fDish.Id,
                //food_dish_detail_id = null,
                sale_table_id = saleTable.Id,
                dining_table_id = saleTable.DiningTableId,

            });

            SetSaleTableResponseData(res1);
            CreateCartItems();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            category = btn.Tag as Category;
            CreateFoodDishItems();
        }

        public async void ChangeQty(SaleDetail sDetail, double? quantity)
        {
            Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("changeQty", new
            {
                sale_detail_id = sDetail.Id,
                dining_table_id = saleTable.DiningTableId,
                qty = quantity,
            });
            SetSaleTableResponseData(res);
            CreateCartItems();
        }

        private async void SaleForm_Load(object sender, EventArgs e)
        {
            // Initialize debounce timer
            //debounceTimer = new Timer();
            //debounceTimer.Interval = debounceInterval;
            //debounceTimer.Tick += DebounceTimer_Tick;

            ApplyTranslations();

            await LoadSaleTable(saleTable.Id);
            CreateCartItems();

            await LoadPrinters();
            await LoadFoodDishes();
            CreateCategoryButtons();
            CreateFoodDishItems();

        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            // When debounce interval passes without new key press, stop the timer and perform the action
            debounceTimer.Stop();
            PerformSearch(txtSearch.Text); // Example: Debounced search operation
        }

        private void PerformSearch(string query)
        {
            CreateFoodDishItems();
        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateGridView(gdCart);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblTotal,lblDiscount,lblService,lblVat, lblTotalPay,
            });
            AppLocalization.TranslateObjects<IconButton>(new List<IconButton> {
                btnClose, btnPayment,btnInvoice, btnPrintIn
            });

            lblUser.Text = AppLocalization.Translate("User") + ":";
            lblTable.Text = AppLocalization.Translate("Table") + ":";
            lblDate.Text = AppLocalization.Translate("Date") + ":";
            lblPeople.Text = AppLocalization.Translate("People") + ":";

            GeneralFunction.ApplyFontToAllControls(this, PublicVariable.fontStyleByLanguage(10f));
            GeneralFunction.ApplyFontToAllControls(pnlTotal);
        }

        private void gdCart_DoubleClick(object sender, EventArgs e)
        {
            SaleDetail sDetail = GetSelectedSaleDetail();
            UpdateSaleDetailForm discountItemForm = new UpdateSaleDetailForm(this, saleTable, sDetail);
            discountItemForm.ShowDialog();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SaleDetail sDetail = GetSelectedSaleDetail();
            ChangeQty(sDetail, sDetail.Qty + 1);

        }

        private SaleDetail GetSelectedSaleDetail()
        {
            int id = (int)gdCart.SelectedRows[0].Cells["Id"].Value;
            return saleDetails.FirstOrDefault(x => x.Id == id);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SaleDetail sDetail = GetSelectedSaleDetail();
            ChangeQty(sDetail, sDetail.Qty - 1);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountAllForm discountAllForm = new DiscountAllForm(this, saleTable);
            discountAllForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void CloseForm()
        {
            tableForm.LoadDiningTables();
            this.Dispose();
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            if (saleDetails.Count == 0)
            {
                MessageBox.Show(AppLocalization.Translate("no_item"));
                return;
            }

            await LoadSaleTable(saleTable.Id);

            Debug.Write("=============================");
            Debug.Write(saleTable.SaleDetails[0]);

            PaymentForm paymentForm = new PaymentForm(this, saleTable, printers[0]);
            paymentForm.ShowDialog();
        }

        private async void btnPrintIn_Click(object sender, EventArgs e)
        {
            if (printers.Count == 0)
            {
                MessageBox.Show("No printer found");
                return;
            }

            Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("getPrinterAndUpdateReceiptPrintTime", new
            {
                sale_table_id = saleTable.Id,
            });
            SetSaleTableResponseData(res);
            //await LoadSaleTable(saleTable.Id);

            ReportPreInvoice rpt = new ReportPreInvoice();

            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["invoiceNumber"].Value = saleTable.InvoiceNumber ?? "0";
            rpt.ReportParameters["totalAmount"].Value = saleTable.TotalAmount;
            rpt.ReportParameters["discountAmount"].Value = saleTable.DiscountAmount;
            rpt.ReportParameters["discountPercentage"].Value = saleTable.DiscountPercentage;
            rpt.ReportParameters["roomServiceAmount"].Value = saleTable.RoomServiceAmount;
            rpt.ReportParameters["taxAmount"].Value = saleTable.TaxAmount;
            rpt.ReportParameters["grandTotal"].Value = Convert.ToDecimal(saleTable.GrandTotal).ToString("N2");
            rpt.DataSource = saleTable.SaleDetails;

            GeneralFunction.PrintReporting(rpt, printers[0].DeviceName);
        }


        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceSettingForm frm = new InvoiceSettingForm(this);
            frm.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    CreateFoodDishItems();
            //}
            isSearching = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //debounceTimer.Stop();
            //debounceTimer.Start();
        }

        private void gdCart_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            // Apply padding to the "Description" column
            if (e.Column.Name == "Description")
            {
                // Set cell padding
                e.CellElement.Padding = new Padding(10); // Padding of 10 on all sides

                // Optionally, you can customize alignment and text wrapping
                e.CellElement.TextWrap = true;
            }
        }

        private void gdCart_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridHeaderCellElement)
            {
                e.CellElement.Padding = new Padding(10);
            }
        }

        private async void DrawImageOnVisible()
        {
            Image defaultImg = new Bitmap(Resources.white_bg, new Size(150, 150));
            foreach (Control control in pnlItems.Controls)
            {
                if (control is PanelExt btn && IsControlVisible(btn))
                {
                    foreach (PictureBox picBox in btn.Controls)
                    {

                        if (picBox.Image == null) // Image not loaded yet
                        {
                            FoodDish fDish = (FoodDish)btn.Tag;
                            if (loadedImages.ContainsKey(fDish.Id))
                            {
                                picBox.Image = loadedImages[fDish.Id];
                            }
                            else if (fDish.FoodPhoto != null)
                            {
                                try
                                {
                                    var img = await GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
                                    Image resizedImage = GeneralFunction.ResizeAndCropImage(img, btn.Size);
                                    picBox.Image = resizedImage;
                                    loadedImages[fDish.Id] = resizedImage;
                                }
                                catch (Exception ex)
                                {
                                    picBox.Image = defaultImg;
                                }
                            }
                            else
                            {
                                //picBox.Image = new Bitmap(Resources.DRINK, btn.Size); // Default image
                                picBox.Image = defaultImg; // Default image
                                loadedImages[fDish.Id] = picBox.Image;
                            }
                        }
                    }
                }


                //if (control is Button btn && IsControlVisible(btn))
                //{
                //    if (btn.Image == null) // Image not loaded yet
                //    {
                //        FoodDish fDish = (FoodDish)btn.Tag;
                //        if (fDish.FoodPhoto != null)
                //        {
                //            var img = await GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
                //            Image resizedImage = GeneralFunction.ResizeAndCropImage(img, btn.Size);
                //            btn.Image = resizedImage;
                //            loadedImages[fDish.Id] = resizedImage;
                //        }
                //        else
                //        {
                //            btn.Image = new Bitmap(Resources.DRINK, btn.Size); // Default image
                //            loadedImages[fDish.Id] = btn.Image;
                //        }
                //    }
                //}

                //    //if (control is PanelExt panel && IsControlVisible(panel))
                //    //{
                //    //    PictureBox pictureBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
                //    //    if (pictureBox != null && pictureBox.Image == null) // Image not loaded yet
                //    //    {
                //    //        FoodDish fDish = (FoodDish)panel.Tag;
                //    //        if (fDish.FoodPhoto != null)
                //    //        {
                //    //            var img = await GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
                //    //            Image resizedImage = GeneralFunction.ResizeAndCropImage(img, pictureBox.Size);
                //    //            pictureBox.Image = resizedImage;
                //    //        }
                //    //        else
                //    //        {
                //    //            pictureBox.Image = new Bitmap(Resources.DRINK, pictureBox.Size); // Default image
                //    //        }
                //    //    }
                //    //}
            }
        }

        private void pnlItems_Scroll(object sender, ScrollEventArgs e)
        {
            //Panel panel = sender as Panel;
            //foreach (Control control in panel.Controls)
            //{
            //    // Adjust control visibility based on whether it's in the visible area
            //    if (control.Bounds.Bottom < panel.DisplayRectangle.Top || control.Bounds.Top > panel.DisplayRectangle.Bottom)
            //    {
            //        control.Visible = false;  // Control is outside visible area
            //    }
            //    else
            //    {
            //        control.Visible = true;   // Control is inside visible area
            //    }
            //}
            DrawImageOnVisible();
        }

        private bool IsControlVisible(Control control)
        {
            try
            {
                Rectangle panelRect = pnlItems.ClientRectangle;
                Rectangle controlRect = pnlItems.RectangleToClient(control.Parent.RectangleToScreen(control.Bounds));
                return panelRect.IntersectsWith(controlRect);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void pnlItems_MouseHover(object sender, EventArgs e)
        {
            DrawImageOnVisible();
        }

        private async void SaleForm_Shown(object sender, EventArgs e)
        {
        }
        private async void btnPrintFood_Click(object sender, EventArgs e)
        {
            if (printers.Count == 0)
            {
                MessageBox.Show("No printer found");
                return;
            }

            await LoadSaleTable(saleTable.Id);

            List<SaleDetail> sDetails = saleDetails.Where(sd => sd.Qty > sd.OldQty).ToList();

            if (sDetails.Count == 0)
            {
                MessageBox.Show("No item to print");
                return;
            }

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
            SetSaleTableResponseData(res);

        }

        private void btnPrintStair_Click(object sender, EventArgs e)
        {
            if (saleTable.SaleDetails.Count == 0)
            {
                MessageBox.Show("No item to print");
                return;
            }
            //ReportCheckItem rpt = new ReportCheckItem();
            Report_Check_Item_Total rpt = new Report_Check_Item_Total();
            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["personCount"].Value = saleTable.PersonCount;
            rpt.DataSource = saleTable.SaleDetails;
            
            //GeneralFunction.PrintReporting(rpt, p.DeviceName);
            SelectPrinterForm frm = new SelectPrinterForm(this, printers, rpt);
            frm.ShowDialog();
        }

        private void btnPrintKitchen_Click(object sender, EventArgs e)
        {
            List<SaleDetail> sDetails = saleDetails.Where(sd => sd.FoodDish.Category.IsDrink == false).ToList();
            if (sDetails.Count == 0)
            {
                MessageBox.Show("No item to print");
                return;
            }

            //ReportCheckItem rpt = new ReportCheckItem();
            Report_Check_Item_Total rpt = new Report_Check_Item_Total();
            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["personCount"].Value = saleTable.PersonCount;
            rpt.DataSource = sDetails;
            //GeneralFunction.PrintReporting(rpt, p.DeviceName);
            SelectPrinterForm frm = new SelectPrinterForm(this, printers, rpt);
            frm.ShowDialog();
        }

        private void btnPrintWater_Click(object sender, EventArgs e)
        {
            List<SaleDetail> sDetails = saleDetails.Where(sd => sd.FoodDish.Category.IsDrink == true).ToList();

            if (sDetails.Count == 0)
            {
                MessageBox.Show("No item to print");
                return;
            }

            //ReportCheckItem rpt = new ReportCheckItem();
            Report_Check_Item_Total rpt = new Report_Check_Item_Total();
            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["personCount"].Value = saleTable.PersonCount;
            rpt.DataSource = sDetails;
            //GeneralFunction.PrintReporting(rpt, p.DeviceName);
            SelectPrinterForm frm = new SelectPrinterForm(this, printers, rpt);
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isSearching = false;
            CreateFoodDishItems();
        }


        //int pained = 0;
        //private void pnlItems_Paint(object sender, PaintEventArgs e)
        //{
        //    pained++;
        //    Debug.WriteLine(pained);
        //}

        //private void CreateFoodDishItems()
        //{
        //    if (foodDishes == null) return;

        //    List<FoodDish> fDishes = foodDishes;

        //    if (txtSearch.Text.Length > 0)
        //    {
        //        var search = txtSearch.Text.Trim();
        //        fDishes = fDishes.Where(fd =>
        //            searchString(fd.EnglishName ?? "", search) ||
        //            searchString(fd.ChineseName ?? "", search) ||
        //            searchString(fd.KhmerName ?? "", search) ||
        //            searchString(fd.EnglishKeyword ?? "", search) ||
        //            searchString(fd.ChineseKeyword ?? "", search) ||
        //            searchString(fd.KhmerKeyword ?? "", search) ||
        //            searchString(fd.FoodCode ?? "", search)).ToList();
        //    }

        //    if (category != null && category.Id != null)
        //    {
        //        fDishes = fDishes.Where(fd => fd.CategoryId == category.Id).ToList();
        //    }

        //    filteredFoodDishes = fDishes;
        //    // Setting up the grid to match the number of items
        //    colCount = (int)Math.Floor(GeneralFunction.ConvertNumber(radVirtualGrid.ClientSize.Width / foodItemWidth));

        //    radVirtualGrid.MasterViewInfo.RowHeight = (int)foodItemHeight;
        //    radVirtualGrid.RowCount = (int)Math.Ceiling(GeneralFunction.ConvertNumber(fDishes.Count / colCount));
        //    radVirtualGrid.ColumnCount = colCount; // Assuming a single-column grid for simplicity

        //    //radVirtualGrid.CellValueNeeded += (sender, args) =>
        //    //{
        //    //    if (args.RowIndex < 0 || args.RowIndex >= fDishes.Count) return;

        //    //    var fDish = fDishes[args.RowIndex];

        //    //    if (args.ColumnIndex == 0)
        //    //    {
        //    //        // This will trigger the cell to be drawn with the custom content
        //    //        args.Value = fDish;
        //    //    }
        //    //};

        //    //radVirtualGrid.CellFormatting += async (sender, args) =>
        //    //{
        //    //    // Ensure the formatting only applies to data rows
        //    //    if (args.CellElement.RowIndex >= 0 && args.CellElement.RowIndex < fDishes.Count)
        //    //    {
        //    //        var fDish = fDishes[args.CellElement.RowIndex];

        //    //        // Clear any existing children (this ensures the cell isn't overloaded with elements)
        //    //        args.CellElement.Children.Clear();

        //    //        // Load the dish image
        //    //        Image dishImage = Resources.DRINK; // default
        //    //        if (fDish.FoodPhoto != null)
        //    //        {
        //    //            var img = await GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
        //    //            dishImage = GeneralFunction.ResizeAndCropImage(img, new Size(100, 100));
        //    //        }

        //    //        // Create a LightVisualElement to hold the image
        //    //        LightVisualElement imgElement = new LightVisualElement
        //    //        {
        //    //            Image = dishImage,
        //    //            ImageLayout = ImageLayout.Stretch,
        //    //            MinSize = new Size(100, 100),
        //    //            MaxSize = new Size(100, 100),
        //    //            Alignment = ContentAlignment.MiddleCenter,
        //    //            DrawText = false
        //    //        };

        //    //        // Create a LightVisualElement for the name
        //    //        LightVisualElement lblName = new LightVisualElement
        //    //        {
        //    //            Text = fDish.GetNameConcat("\n"),
        //    //            Font = new Font("Hanuman", 8F, FontStyle.Bold),
        //    //            ForeColor = Color.White,
        //    //            TextAlignment = ContentAlignment.TopCenter,
        //    //            DrawFill = true,
        //    //            BackColor = Color.FromArgb(128, Color.Black),
        //    //            MinSize = new Size(100, 40),
        //    //            MaxSize = new Size(100, 40)
        //    //        };

        //    //        // Create a LightVisualElement for the price
        //    //        LightVisualElement lblPrice = new LightVisualElement
        //    //        {
        //    //            Text = fDish.FoodPrice.ToString(),
        //    //            Font = new Font("Hanuman", 12F, FontStyle.Bold),
        //    //            ForeColor = Color.GreenYellow,
        //    //            TextAlignment = ContentAlignment.MiddleCenter,
        //    //            DrawFill = true,
        //    //            BackColor = Color.FromArgb(128, Color.Black),
        //    //            MinSize = new Size(100, 20),
        //    //            MaxSize = new Size(100, 20)
        //    //        };

        //    //        // Add elements to the cell
        //    //        args.CellElement.Children.Add(imgElement);
        //    //        args.CellElement.Children.Add(lblName);
        //    //        args.CellElement.Children.Add(lblPrice);

        //    //        // Optionally force redraw
        //    //        args.CellElement.Invalidate();
        //    //    }
        //    //};
        //}

        //private void radVirtualGrid_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        //{
        //    if (e.RowIndex < 0 || e.RowIndex >= filteredFoodDishes.Count) return;

        //    var fDish = filteredFoodDishes[e.RowIndex];

        //    if (e.ColumnIndex == 0)
        //    {
        //        // This will trigger the cell to be drawn with the custom content
        //        e.Value = fDish;
        //    }
        //}

        //private void radVirtualGrid_CellFormatting(object sender, VirtualGridCellElementEventArgs args)
        //{
        //    // Ensure the formatting only applies to data rows
        //    if (args.CellElement.RowIndex >= 0 && args.CellElement.RowIndex < filteredFoodDishes.Count && args.CellElement.ColumnIndex >= 0)
        //    {
        //        int index = args.CellElement.RowIndex * colCount + args.CellElement.ColumnIndex; // 4 items per row
        //        var fDish = filteredFoodDishes[index];

        //        // Clear any existing children (this ensures the cell isn't overloaded with elements)
        //        args.CellElement.Children.Clear();
        //        //args.CellElement.Text = fDish.FullName;
        //        //return;

        //        // Load the dish image
        //        Image dishImage = Resources.DRINK; // default
        //        if (fDish.FoodPhoto != null)
        //        {
        //            // Load the image asynchronously
        //            var imgTask = GeneralFunction.LoadImageFromUrlAsync(fDish.FoodPhotoUrl);
        //            imgTask.ContinueWith(task =>
        //            {
        //                dishImage = GeneralFunction.ResizeAndCropImage(task.Result, new Size(100, 100));

        //                // Update the image in the UI thread
        //                radVirtualGrid.Invoke(new Action(() =>
        //                {
        //                    LightVisualElement imgElement = new LightVisualElement
        //                    {
        //                        Image = dishImage,
        //                        ImageLayout = ImageLayout.Stretch,
        //                        MinSize = new Size(100, 100),
        //                        MaxSize = new Size(100, 100),
        //                        Alignment = ContentAlignment.MiddleCenter,
        //                        DrawText = false
        //                    };

        //                    // Add the image to the cell
        //                    args.CellElement.Children.Add(imgElement);
        //                }));
        //            });
        //        }

        //        // Create a LightVisualElement to hold the image
        //        //LightVisualElement imgElement = new LightVisualElement
        //        //{
        //        //    Image = dishImage,
        //        //    ImageLayout = ImageLayout.Stretch,
        //        //    MinSize = new Size(100, 100),
        //        //    MaxSize = new Size(100, 100),
        //        //    Alignment = ContentAlignment.MiddleCenter,
        //        //    DrawText = false
        //        //};

        //        // Create a LightVisualElement for the name
        //        LightVisualElement lblName = new LightVisualElement
        //        {
        //            Text = fDish.GetNameConcat("\n"),
        //            //Font = new Font("Hanuman", 8F, FontStyle.Bold),
        //            //ForeColor = Color.Black,
        //            //TextAlignment = ContentAlignment.TopCenter,
        //            //DrawFill = true,
        //            //BackColor = Color.FromArgb(128, Color.Black),
        //            //MinSize = new Size(100, 40),
        //            //MaxSize = new Size(100, 40)
        //        };

        //        // Create a LightVisualElement for the price
        //        LightVisualElement lblPrice = new LightVisualElement
        //        {
        //            Text = fDish.FoodPrice.ToString(),
        //            //Font = new Font("Hanuman", 12F, FontStyle.Bold),
        //            //ForeColor = Color.GreenYellow,
        //            //TextAlignment = ContentAlignment.MiddleCenter,
        //            //DrawFill = true,
        //            //BackColor = Color.FromArgb(128, Color.Black),
        //            //MinSize = new Size(100, 20),
        //            //MaxSize = new Size(100, 20)
        //        };

        //        // Add elements to the cell
        //        //args.CellElement.Children.Add(imgElement);
        //        args.CellElement.Children.AddRange(new LightVisualElement[] { lblName, lblPrice });
        //        //args.CellElement.Children.Add(lblPrice);

        //        // Optionally force redraw
        //        //args.CellElement.Invalidate();

        //    }
        //}
    }
}
