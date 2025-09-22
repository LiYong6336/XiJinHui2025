using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class SetInvoicesForm : Telerik.WinControls.UI.RadForm
    {
        //object ctt_id = null;
        SetInvoice setInvoice = new SetInvoice();
        List<SetInvoice> setInvoices = new List<SetInvoice>();

        public SetInvoicesForm()
        {
            InitializeComponent();
        }

        private void frmSetInvoice_Load(object sender, EventArgs e)
        {
            dtpInvoiceDate.Text = GeneralFunction.FormatStandardDate(DateTime.Now);

            ClearData();
            BindData();
            TranslateText();
        }

        private async void BindData()
        {
            Response<List<SetInvoice>> res = await HttpClientHelper.GetAsync<List<SetInvoice>>("set_invoice");
            setInvoices = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtInvoiceCount.Clear();
            txtInvoiceStart.Clear();
            setInvoice = new SetInvoice();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                setInvoice = setInvoices[e.RowIndex];
                txtInvoiceCount.Text = setInvoice.InvoiceCount.ToString();
                txtInvoiceStart.Text = setInvoice.InvoiceStart.ToString();
                dtpInvoiceDate.Text = setInvoice.InvoiceDate.ToString();

                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtInvoiceCount.Text.Length > 0)
            {

                try
                {
                    setInvoice.InvoiceCount = GeneralFunction.ConvertInt(txtInvoiceCount.Text);
                    setInvoice.InvoiceStart = GeneralFunction.ConvertInt(txtInvoiceStart.Text);
                    setInvoice.InvoiceDate = dtpInvoiceDate.Text;
                    if (setInvoice.Id > 0)
                    {
                        await HttpClientHelper.PutAsync<SetInvoice>("set_invoice/" + setInvoice.Id, setInvoice);
                    }
                    else
                    {
                        await HttpClientHelper.PostAsync<SetInvoice>("set_invoice", setInvoice);
                    }

                    ClearData();
                    BindData();
                    //MessageBox.Show("Sucessful SaveChanged");
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Invoice count Can't Empty");
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

        private void txtKhmer_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchKhmerKeyboard();
        }

        private void txtKhmer_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtChinese_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtChinese_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchChineseKeyboard();
        }
        private void TranslateText()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel> {
                lblCode, lblEnglish,
            });
            //AppLocalization.TranslateObjects<RadCheckBox>(new List<RadCheckBox> {
            //    ckIsAnimalPart
            //});
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateGridView(dgView);

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("set_invoice/" + setInvoice.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
