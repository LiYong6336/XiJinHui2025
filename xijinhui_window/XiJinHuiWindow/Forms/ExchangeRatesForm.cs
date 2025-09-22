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
    public partial class ExchangeRatesForm : Telerik.WinControls.UI.RadForm
    {
        ExchangeRate exchangeRate = new ExchangeRate();
        List<ExchangeRate> exchangeRates = new List<ExchangeRate>();

        public ExchangeRatesForm()
        {
            InitializeComponent();
        }

        private void frmExchangeRate_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            TranslateText();
        }

        private async void BindData()
        {
            Response<List<ExchangeRate>> res = await HttpClientHelper.GetAsync<List<ExchangeRate>>("exchange_rate");
            exchangeRates = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtRate.Clear();
            txtRateReturn.Clear();
            txtTax.Clear();
            txtNssf.Clear();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                exchangeRate = exchangeRates[e.RowIndex];
                string[] splDate = exchangeRate.ExchangeDate.Split('-');
                dtpDate.Value = new DateTime(
                    int.TryParse(splDate[0], out int y) ? y : 0,
                    int.TryParse(splDate[1], out int m) ? m : 0,
                    int.TryParse(splDate[2], out int d) ? d : 0
                    );
                txtRate.Text = exchangeRate.RateStandard.ToString();
                txtRateReturn.Text = exchangeRate.RateReturned.ToString();
                txtTax.Text = exchangeRate.RateTaxation.ToString();
                txtNssf.Text = exchangeRate.RateNssf.ToString();
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtRate.Text.Length > 0)
            {

                try
                {
                    exchangeRate.ExchangeDate = dtpDate.Value.ToString("yyyy-MM-dd");
                    exchangeRate.RateStandard = double.TryParse(txtRate.Text, out double r) ? r : 0;
                    exchangeRate.RateReturned = double.TryParse(txtRateReturn.Text, out double rr) ? rr : 0;
                    exchangeRate.RateTaxation = double.TryParse(txtTax.Text, out double t) ? t : 0;
                    exchangeRate.RateNssf = double.TryParse(txtNssf.Text, out double nssf) ? nssf : 0;
                    Response<ExchangeRate> res;
                    if (exchangeRate.Id > 0)
                    {
                        res = await HttpClientHelper.PutAsync<ExchangeRate>("exchange_rate/" + exchangeRate.Id, exchangeRate);
                    }
                    else
                    {
                        res = await HttpClientHelper.PostAsync<ExchangeRate>("exchange_rate", exchangeRate);
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
                lblDate,  lblRate, lblTax, lblNssf, lblRateReturn
            });
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
                bool res = await HttpClientHelper.DeleteAsync("exchange_rate/" + exchangeRate.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
