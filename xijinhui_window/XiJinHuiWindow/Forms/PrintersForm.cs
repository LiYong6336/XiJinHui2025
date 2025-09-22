using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class PrintersForm : Telerik.WinControls.UI.RadForm
    {
        Printer printer = new Printer();
        List<Printer> printers = new List<Printer>();

        public PrintersForm()
        {
            InitializeComponent();
        }

        private void frmPrinter_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            TranslateText();
            foreach (string pt in Printer.PrinterTypes)
                ddType.Items.Add(new RadListDataItem { Text = pt, Value = pt });
        }

        private async void BindData()
        {
            Response<List<Printer>> res = await HttpClientHelper.GetAsync<List<Printer>>("printers");
            printers = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtBrand.Clear();
            txtDeviceName.Clear();
            txtIp.Clear();
            txtPort.Clear();
            txtLocation.Clear();

            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                printer = printers[e.RowIndex];

                txtBrand.Text = printer.PrinterBrand;
                txtDeviceName.Text = printer.DeviceName;
                txtIp.Text = printer.PrinterIpAddress;
                txtPort.Text = printer.Port.ToString();
                txtLocation.Text = printer.PrintLocation;
            ddType.SelectedValue = printer.PrinterType;
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtDeviceName.Text.Length > 0)
            {
                try
                {
                    printer.PrinterBrand = txtBrand.Text;
                    printer.DeviceName = txtDeviceName.Text;
                    printer.Port = txtPort.Text;
                    printer.PrinterIpAddress = txtIp.Text;
                    printer.PrinterType = ddType.SelectedValue.ToString();
                    printer.PrintLocation = txtLocation.Text;

                    Response<Printer> res;
                    if (printer.Id > 0)
                    {
                        res = await HttpClientHelper.PutAsync<Printer>("printers/" + printer.Id, printer);
                    }
                    else
                    {
                        res = await HttpClientHelper.PostAsync<Printer>("printers", printer);
                    }

                    ClearData();
                    BindData();
                    MessageBox.Show("Sucessful Save Changed");
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Rate Cann't Empty");
                ClearData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void TranslateText()
        {
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblBrand,  lblDeviceName, lblPort, lblType, lblIp, lblLocation
            });
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateObjects<RadDropDownList>(new List<RadDropDownList> {
                ddType
            });
            AppLocalization.TranslateGridView(dgView);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("printers/" + printer.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
