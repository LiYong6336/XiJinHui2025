
//using ChuanMaPo.Reporting;
//using CMP.Reporting;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using XiJinHuiWindow.Utils;
using System.Diagnostics;
using XiJinHuiWindow.Reports.Cashier;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using XiJinHuiWindow.Properties;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class PaymentForm : Telerik.WinControls.UI.RadForm
    {
        //CLASS_CUSTOMER_SPEND cls = new CLASS_CUSTOMER_SPEND();
        int paymentType = 1;
        public static string public_tableName = "0";
        public static string public_vat_tax = "0";

        private decimal total = 0;
        private decimal exchangeRate = 1;
        private decimal totalPay = 0;

        private SaleForm saleForm;
        private SaleTable saleTable;
        private Printer printer;

        private List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        private Dictionary<int?, Dictionary<string, string>> amounts = new Dictionary<int?, Dictionary<string, string>>();

        object o_cus_id = 0;
        public PaymentForm()
        {
            InitializeComponent();
        }
        public PaymentForm(SaleForm saleForm, SaleTable saleTable, Printer printer)
        {
            InitializeComponent();

            this.saleForm = saleForm;
            this.saleTable = saleTable;
            this.printer = printer;
            this.total = Convert.ToDecimal(saleTable.GrandTotal);
            this.exchangeRate = Convert.ToDecimal(saleTable.ExchangeRate);
            //this.totalPay = Convert.ToDecimal(saleTable.GrandTotal);
        }

        #region "Declaration"

        RadTextBox activeTextBox;
        Int32 activeCursor;

        Boolean b_pay_invalid;
        #endregion
        Control lblCustomerNumber;
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            ApplyTranslations();
            try
            {
                var exchangeRate = GeneralFunction.ConvertNumber(saleTable.ExchangeRate);// Convert.ToDecimal(Utilities.GerneralFunction.GetSingleValue("SELECT TOP 1 exr_rate FROM dbo.EXCHANGE_RATE_TABLE ORDER BY exr_id DESC"));


                txtTotalDollar.Text = total.ToString("F2", CultureInfo.InvariantCulture);
                txtTotalRial.Text = (total * exchangeRate).ToString("F2", CultureInfo.InvariantCulture);
                txtPayRial.Text = (total * exchangeRate).ToString("F0", CultureInfo.InvariantCulture);


                //txtPayDollar.GotFocus += new EventHandler(activeTxt);
                //txtPayRial.GotFocus += new EventHandler(activeTxt);
                //txtReturnDollar.GotFocus += new EventHandler(activeTxt);

                //txtTotalDollar.GotFocus += new EventHandler(SetFucusToActiveTextbox);
                //txtTotalRial.GotFocus += new EventHandler(SetFucusToActiveTextbox);
                //txtReturnRial.GotFocus += new EventHandler(SetFucusToActiveTextbox);

                //lblCustomerNumber = Utilities.GerneralFunction.GetControlAcrossForm("frmRestaurent", "lblCustomerNumber");

               // txtPayDollar.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LoadPaymentMehoths();

        }

        private async void LoadPaymentMehoths()
        {
            cddPaymentMethods.Items.Clear();
            Response<List<PaymentMethod>> res = await HttpClientHelper.GetAsync<List<PaymentMethod>>("payment_methods");
            paymentMethods = res.Data;
            foreach (PaymentMethod pm in paymentMethods)
            {
                cddPaymentMethods.Items.Add(new RadCheckedListDataItem
                {
                    Text = GeneralFunction.GetPropertyValue(pm).ToString(),
                    Value = pm.Id,
                    Tag = pm,
                });
            }
        }

        void SetFucusToActiveTextbox(object sender, EventArgs e)
        {
            activeTextBox.Focus();
            
            activeTextBox.SelectionStart = activeCursor;
            activeTextBox.SelectionLength = 0;
        }
        void activeTxt(object sender, EventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            //activeCursor = txt.SelectionStart;
            //HideCaret(txtPayDollar.Handle);
            //HideCaret(txtPayRial.Handle);
            //HideCaret(txtReturnDollar.Handle);
            //if (b_pay_invalid == true)
            //{
            //    txtPayDollar.BackColor = Color.Red;
            //    txtPayRial.BackColor = Color.Red;
                
            //}
            //else
            //{
            //    txtPayDollar.BackColor = Color.White;
            //    txtPayRial.BackColor = Color.White;
            //}

            //txtReturnDollar.BackColor = Color.White;
            //txtReturnDollar.Enabled=false;

            activeTextBox = (RadTextBox)sender;
            //activeTextBox.BackColor = Color.Green;
            //activeTextBox.BackColor = Color.FromArgb(240, 88, 12);
            activeTextBox.Select(0, activeTextBox.Text.Length);

        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            btn.Focus();

            if (activeTextBox.Text.Length < 10)
            {
                activeCursor = activeTextBox.SelectionStart + 1;
                string start;
                string end;
                start = activeTextBox.Text.Substring(0, activeTextBox.SelectionStart);
                end = activeTextBox.Text.Substring(activeTextBox.SelectionStart + activeTextBox.SelectionLength);
                activeTextBox.Text = start.ToString() + btn.Text + end.ToString();
                activeTextBox.Text = Convert.ToInt64(activeTextBox.Text).ToString();
            }
            activeTextBox.Focus();
            activeTextBox.SelectionStart = activeCursor;
            activeTextBox.SelectionLength = 0;
            //HideCaret(activeTextBox.Handle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.Dispose();
            btn.Focus();
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnBackSpace.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                btnClose.PerformClick();
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            activeCursor = activeTextBox.SelectionStart;
            if (activeTextBox.Text.Length > 0)
            {
                string start;
                string end;
                start = activeTextBox.Text.Substring(0, activeTextBox.SelectionStart);
                end = activeTextBox.Text.Substring(activeTextBox.SelectionStart + activeTextBox.SelectionLength);
                if (activeTextBox.SelectionLength > 0)
                {
                    activeTextBox.Text = start + end;
                }
                else
                {
                    if (activeTextBox.SelectionStart > 0)
                    {
                        activeCursor = activeTextBox.SelectionStart - 1;
                        activeTextBox.Text = start.Substring(0, start.Length - 1) + end;
                    }
                }
                //activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
                if (activeTextBox.Text.Trim() == "")
                {
                    activeTextBox.Text = "0";
                }
                activeTextBox.Text = Convert.ToInt64(activeTextBox.Text).ToString();
                if (Convert.ToInt64(activeTextBox.Text) == 0)
                {
                    activeCursor = 1;
                }
            }
            activeTextBox.Focus();
            activeTextBox.SelectionStart = activeCursor;
            activeTextBox.SelectionLength = 0;
            //Button btn = (Button)sender;
            //btn.Focus();
        }

        private async Task InsertData()
        {
            List<object> pments = new List<object>();
            foreach (RadCheckedListDataItem ctl in cddPaymentMethods.CheckedItems)
            {
                PaymentMethod pm = (PaymentMethod)ctl.Tag;
                if (amounts.TryGetValue(pm.Id, out Dictionary<string, string> result))
                {
                    object payment = new
                    {
                        amount_dollar = GeneralFunction.ConvertDouble( amounts[pm.Id]["usd"]),
                        amount_riel = GeneralFunction.ConvertDouble(amounts[pm.Id]["riel"]),
                        payment_method_id = pm.Id,
                    };
                    pments.Add(payment);
                }
            }
            try
            {
                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("salePayment", new
                {
                    sale_table_id = saleTable.Id,
                    payments = pments,
                    invoice_number = txtInvoiceNumber.Text,
                    remark = txtRemark.Text,

                });

                saleTable = res.Data;

                //frmRestaurent.b_payment_complete = true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                throw e;
            }

        }

        private async void btnPrintInvoice_Click(object sender, EventArgs e)
        {

            if (b_pay_invalid == false)
            {
                btnPrintInvoice.Enabled = false;

                try
                {
                    await InsertData();
                    PrintInvoice();
                    PrintInvoice();
                    this.Dispose();

                    //frmTable.status = 1;
                    saleForm.CloseForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnPrintInvoice.Enabled = true;
                }

            }
            else
            {
                //ATControl.ShowDialogBox.Show("ការបង់ប្រាក់មិនគ្រប់គ្រាន់ សូមធ្វើការពិនិត្យម្តងទៀត។", "បញ្ចក់", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //POSmessageBox message = new POSmessageBox();
                //message.message = "ការបង់ប្រាក់មិនគ្រប់គ្រាន់ សូមធ្វើការពិនិត្យម្តងទៀត។";
                //message.is_yes = false;
                //message.ShowDialog();
                MessageBox.Show("Not Enought");
            }
        }

        private void PrintInvoice()
        {
            ReportInvoice rpt = new ReportInvoice();
            rpt.ReportParameters["tableName"].Value = saleTable.DiningTable.EnglishName;
            rpt.ReportParameters["userName"].Value = PublicVariable.User.Name;
            rpt.ReportParameters["invoiceNumber"].Value = saleTable.ShowingInvoiceNumber ?? "-";
            rpt.ReportParameters["saleDate"].Value = saleTable.SaleDate.Split(' ')[0];
            rpt.ReportParameters["totalAmount"].Value = saleTable.TotalAmount;
            rpt.ReportParameters["discountAmount"].Value = saleTable.DiscountAmount;
            rpt.ReportParameters["discountPercentage"].Value = saleTable.DiscountPercentage;
            rpt.ReportParameters["roomServiceAmount"].Value = saleTable.RoomServiceAmount;
            rpt.ReportParameters["taxAmount"].Value = saleTable.TaxAmount;

            rpt.ReportParameters["grandTotal"].Value = Convert.ToDecimal(saleTable.GrandTotal).ToString("N2");
            rpt.ReportParameters["grandTotalRiel"].Value = Convert.ToDecimal((saleTable.GrandTotal ?? 0) * (saleTable.ExchangeRate ?? 0)).ToString("N2");
            rpt.ReportParameters["received"].Value = Convert.ToDecimal(saleTable.ReceivedDollar + (saleTable.ReceivedRiel / saleTable.ExchangeRate)).ToString("N2");
            rpt.ReportParameters["returnDollar"].Value = Convert.ToDecimal(saleTable.ReturnDollars + (saleTable.ReturnRiels / saleTable.ExchangeRate)).ToString("N2");
            rpt.ReportParameters["returnRiel"].Value = Convert.ToDecimal((saleTable.ReturnDollars * saleTable.ExchangeRate) + saleTable.ReturnRiels).ToString("N2");
            rpt.DataSource = saleTable.SaleDetails;

            GeneralFunction.PrintReporting(rpt, printer.DeviceName);
        }

        private async void btnNoInvoice_Click(object sender, EventArgs e)
        {
            btnNoInvoice.Enabled = false;
            try
            {
                await InsertData();
                MessageBox.Show("Payment success");
                this.Dispose();
                saleForm.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                btnNoInvoice.Enabled = true;
            }
        }

        private void cddPaymentMethods_ItemCheckedChanged(object sender, RadCheckedListDataItemEventArgs e)
        {
            pnlPaymentMethodsTxt.Controls.Clear();

            foreach (RadCheckedListDataItem ctl in cddPaymentMethods.CheckedItems)
            {


                PaymentMethod pm = (PaymentMethod)ctl.Tag;
                if (!amounts.TryGetValue(pm.Id, out Dictionary<string, string> result))
                {
                    amounts.Add(pm.Id, new Dictionary<string, string>
                    {
                        { "usd",  ""},
                        { "riel",  ""},
                    });
                }


                RadPanel pnl = new RadPanel
                {
                    Height = 100,
                    Dock = DockStyle.Top,
                    //Padding = new Padding(20, 0, 20, 0),
                };
                pnlPaymentMethodsTxt.Controls.Add(pnl);
                RadPanel pnlUsd = new RadPanel
                {
                    Width = pnl.Width / 2,
                    Dock = DockStyle.Left,
                };
                RadPanel pnlRiel = new RadPanel
                {
                    Width = pnl.Width / 2,
                    Dock = DockStyle.Left,
                };
                RadLabel lblUsd = new RadLabel
                {
                    Text = GeneralFunction.GetPropertyValue(pm).ToString() + "(USD)",
                };
                RadLabel lblRiel = new RadLabel
                {
                    Text = GeneralFunction.GetPropertyValue(pm).ToString() + "(Riel)",
                };

                RadTextBox txtUsd = new RadTextBox
                {
                    Top = 40,
                    Width = pnlUsd.Width - 20,
                    Name = "usd_" + pm.Id,
                    Tag = pm,
                    Text = amounts[pm.Id]["usd"].ToString()
                };


                RadTextBox txtRiel = new RadTextBox
                {
                    Top = 40,
                    Width = pnlRiel.Width - 20,
                    Name = "riel_" + pm.Id,
                    Tag = pm,
                    Text = amounts[pm.Id]["riel"].ToString()
                };


                txtUsd.TextChanged += new System.EventHandler(TxtUsd_TextChanged);
                txtRiel.TextChanged += new System.EventHandler(TxtRiel_TextChanged);
                //txtUsd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
                //txtRiel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
                txtUsd.GotFocus += new EventHandler(activeTxt);
                txtRiel.GotFocus += new EventHandler(activeTxt);

                txtUsd.Enter += new EventHandler(TxtAmount_Enter);
                txtRiel.Enter += new EventHandler(TxtAmount_Enter);


                pnlUsd.Controls.Add(lblUsd);
                pnlUsd.Controls.Add(txtUsd);
                pnlRiel.Controls.Add(lblRiel);
                pnlRiel.Controls.Add(txtRiel);
                pnl.Controls.Add(pnlUsd);
                pnl.Controls.Add(pnlRiel);
                pnl.ThemeName = pnlUsd.ThemeName = pnlRiel.ThemeName
                    = lblRiel.ThemeName = lblUsd.ThemeName
                    = txtRiel.ThemeName = txtUsd.ThemeName
                    = "MaterialPink";
            }

            GeneralFunction.ApplyFontToAllControls(pnlPaymentMethodsTxt);
            CalculateTotalPay("usd");
        }
        private void TxtAmount_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }


        private void TxtRiel_TextChanged(object sender, EventArgs e)
        {
            RadTextBox txtRiel = (RadTextBox)sender;
            PaymentMethod pm = txtRiel.Tag as PaymentMethod;
            amounts[pm.Id]["riel"] = txtRiel.Text;
            CalculateTotalPay("riel");
        }

        private void TxtUsd_TextChanged(object sender, EventArgs e)
        {
            RadTextBox txtUsd = (RadTextBox)sender;
            PaymentMethod pm = txtUsd.Tag as PaymentMethod;
            amounts[pm.Id]["usd"] = txtUsd.Text;
            CalculateTotalPay("usd");
        }

        private void CalculateTotalPay(string field)
        {
            decimal usd = 0;
            decimal riel = 0;
            foreach (RadCheckedListDataItem ctl in cddPaymentMethods.CheckedItems)
            {
                usd += GeneralFunction.ConvertNumber( amounts[(int)ctl.Value]["usd"]);
                riel += GeneralFunction.ConvertNumber(amounts[(int)ctl.Value]["riel"]);
            }
            txtPayDollar.Text = usd.ToString();
            txtPayRial.Text = riel.ToString();


            if (usd > total)
            {
                txtPayRial.Text = "0";
            }
            else if (field == "usd")
            {
                txtPayRial.Text = ((total - usd) * exchangeRate).ToString("F0", CultureInfo.InvariantCulture);
            }

            totalPay = usd + (riel / exchangeRate);
            if (totalPay >= total)
            {
                b_pay_invalid = false;
                txtReturnDollar.Text = ((totalPay - total) - ((totalPay - total) % 1)).ToString("F0", CultureInfo.InvariantCulture);
                txtReturnRial.Text = (((totalPay - total) % 1) * exchangeRate).ToString("F0", CultureInfo.InvariantCulture);
                txtReturnDollar.BackColor = Color.LightBlue;
                txtReturnRial.BackColor = Color.LightBlue;
            }
            else
            {
                b_pay_invalid = true;
                txtReturnDollar.Text = "0";
                txtReturnRial.Text = "0";
                txtReturnDollar.BackColor = Color.White;
                txtReturnRial.BackColor= Color.White;
            }


        }

        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>() {
                lblTotalInDollar, lblTotalInRiel, lblPaymentInDollar, lblPaymentInRiel,
                lblChangeInDollar, lblChangeInRiel, lblPaymentMethod
            });
            AppLocalization.TranslateObjects<IconButton>(new List<IconButton>() {
                btnPrintInvoice, btnNoInvoice, btnClose
            });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void btnClearInvoiceText_Click(object sender, EventArgs e)
        {
            txtInvoiceNumber.Text = string.Empty;
        }

        private async void btnPayCashPrint_Click(object sender, EventArgs e)
        {
            SubmitPayment(1);
        }

        private void btnPayAba_Click(object sender, EventArgs e)
        {
            SubmitPayment(2);
        }

        private void btnPayHuione_Click(object sender, EventArgs e)
        {
            SubmitPayment(3);
        }

        private async void SubmitPayment(int paymentMethodId)
        {
            btnPayCashPrint.Enabled = false;
            btnPayAba.Enabled = false;
            btnPayHuione.Enabled = false;

            List<object> pments = new List<object>();
            object payment = new
            {
                amount_dollar = total,
                amount_riel = 0,
                payment_method_id = paymentMethodId,
            };
            pments.Add(payment);
            try
            {
                Response<SaleTable> res = await HttpClientHelper.PostAsync<SaleTable>("salePayment", new
                {
                    sale_table_id = saleTable.Id,
                    payments = pments,
                    invoice_number = txtInvoiceNumber.Text,
                    remark = txtRemark.Text,

                });

                saleTable = res.Data;

                //frmRestaurent.b_payment_complete = true;

                PrintInvoice();
                PrintInvoice();
                this.Dispose();

                //frmTable.status = 1;
                saleForm.CloseForm();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(e.Message);
                throw ex;
            } finally
            {
                btnPayCashPrint.Enabled = true;
                btnPayAba.Enabled = true;
                btnPayHuione.Enabled = true;
            }
        }

    }
}
