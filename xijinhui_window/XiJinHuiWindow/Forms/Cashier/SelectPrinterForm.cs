using XiJinHuiWindow.Forms.Cashier;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PorkeiCashier
{
    public partial class SelectPrinterForm : RadForm
    {
        public static string public_tableName = "";
        public static string public_Sale_Id = "0";

        public static string reportName = "";
        public static string personCount="";
        public static decimal room_service = 0;
        public static decimal vat_tax = 0;


        private SaleForm saleForm;
        private List<Printer> printers;
        private Telerik.Reporting.Report report;

      

        public SelectPrinterForm(SaleForm saleForm, List<Printer> printers, Telerik.Reporting.Report rpt)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.printers = printers;
            this.report = rpt;

            CreatePrinterButtons();
        }

        private void CreatePrinterButtons()
        {
            int totalButtons = printers.Count;
            int columns = 4;
            int rows = (int)Math.Ceiling((double)totalButtons / columns); // Calculate the required rows

            // Define button size and spacing
            int buttonWidth = 80;
            int buttonHeight = 70;
            int spacing = 10;
            int startX = 20;
            int startY = 20;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int index = i * columns + j;
                    if (index >= totalButtons) break; // Stop if we've added all buttons
                    Printer printer = printers[index];

                    // Create a new RadButton
                    RadButton button = new RadButton
                    {
                        Text = printer.Id.ToString(),
                        Size = new Size(buttonWidth, buttonHeight),
                        Location = new Point(startX + (buttonWidth + spacing) * j, startY + (buttonHeight + spacing) * i),
                        BackColor = Color.White,
                        Font = new Font("Arial", 16, FontStyle.Bold),
                        TextAlignment = ContentAlignment.MiddleCenter,
                        Tag = printer,
                    };

                    // Optional: add a click event handler
                    button.Click += new EventHandler(OnClickPrinter);

                    // Add the button to the form
                    pnlContent.Controls.Add(button);
                }
            }
        }

        private void OnClickPrinter(object sender, EventArgs e)
        {
            RadButton btn = (RadButton)sender;
            Printer printer = btn.Tag as Printer;
            GeneralFunction.PrintReporting(report, printer.DeviceName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getPritner(object sender)
        {
            int printer = 0;
            Button btn = (Button)sender;
            //  MessageBox.Show(btn.Text);
            return 1;
        }

        private bool PrintReport(int printerNumber)
        {

            return true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }

        private void btn14_Click(object sender, EventArgs e)
        {
          
        }

        private void btn15_Click(object sender, EventArgs e)
        {
          
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            PrintReport(getPritner(sender));
        }
    }
}
