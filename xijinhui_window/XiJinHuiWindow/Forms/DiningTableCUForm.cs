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
using XiJinHuiWindow.Models.Responses;
using System.Diagnostics;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Forms
{
    public partial class DiningTableCUForm : Telerik.WinControls.UI.RadForm
    {
        private DiningTablesForm diningTablesForm;
        public DiningTable diningTable;
        public List<DiningFloor> diningFloors;
        public DiningTableCUForm( DiningTablesForm dtForm)
        {
            InitializeComponent();
            diningTablesForm = dtForm;
            diningTable = new DiningTable();

        }

        private void DiningTableCUForm_Load(object sender, EventArgs e)
        {

            foreach (var fs in DiningTable.FlagStatuses)
            {
                dropdownStatus.Items.Add(fs.Value);
            }
            //dropdownStatus.DataSource = DiningTable.FlagStatuses;
            LoadRelationship();
            ApplyTranslation();
        }
        
        private async void LoadRelationship()
        {
            Response<List<DiningFloor>> res =await HttpClientHelper.GetAsync<List<DiningFloor>>("dining_floor");
            diningFloors = res.Data;
            foreach (var ds in diningFloors) {
                var item = new RadListDataItem { 
                    Text = ds.EnglishName + " - " + ds.ChineseName + " - " + ds.KhmerName ,
                    Value = ds.Id,
                };
                dropdownDinigFloor.Items.Add(item);
            }
            dropdownDinigFloor.SelectedValue = diningTable.DiningFloorId;
        }

        public void SetFormData(DiningTable dt)
        {
            diningTable = dt;
            txtCode.Text = dt.DiningTableCode;
            txtEnglishName.Text = dt.EnglishName;
            txtChineseName.Text = dt.ChineseName;
            txtKhmerName.Text = dt.KhmerName;
            txtPersonCount.Text = dt.PersonCount.ToString();
            txtTaxPercentage.Text = dt.TaxPercentage.ToString();
            txtTaxFixPrice.Text = dt.TaxFixPrice.ToString();
            txtRoomServicePercentage.Text = dt.RoomServicePercentage.ToString();
            txtRoomServiceFixPrice.Text = dt.RoomServiceFixPrice.ToString();
            txtRemark.Text = dt.Remark;
            cbIsBroken.Checked = dt.IsBroken == true;
            cbIsEnable.Checked = dt.IsEnable == true;
            dropdownStatus.SelectedIndex = (dt.FlagStatus ?? 1) - 1;
            //dropdownDinigFloor.SelectedValue = dt.DiningFloorId;
            //Debug.WriteLine("Dinig: "+dt.DiningFloorId);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            diningTable.DiningTableCode = txtCode.Text;
            diningTable.EnglishName = txtEnglishName.Text;
            diningTable.ChineseName = txtChineseName.Text;
            diningTable.KhmerName = txtKhmerName.Text;
            diningTable.PersonCount = int.TryParse(txtPersonCount.Text, out int pcount) ? pcount : 0;
            diningTable.TaxPercentage = double.TryParse(txtTaxPercentage.Text, out double tPercentage)? tPercentage: 0;
            diningTable.TaxFixPrice = double.TryParse(txtTaxFixPrice.Text, out double tFixPrice) ? tFixPrice: 0;
            diningTable.RoomServicePercentage = double.TryParse(txtRoomServicePercentage.Text, out double rServicePercentage)? rServicePercentage: 0;
            diningTable.RoomServiceFixPrice = double.TryParse(txtRoomServiceFixPrice.Text, out double rServicePrice)? rServicePrice: 0;
            diningTable.Remark = txtRemark.Text;
            diningTable.IsBroken = cbIsBroken.Checked;
            diningTable.IsEnable = cbIsEnable.Checked;
            diningTable.FlagStatus = dropdownStatus.SelectedIndex + 1;
            diningTable.DiningFloorId =(int) dropdownDinigFloor.SelectedValue;

            try
            { 
                Response<DiningTable> res;
                if(diningTable.Id > 0)
                {
                    res= await HttpClientHelper.PutAsync<DiningTable>("dining_table/"+ diningTable.Id, diningTable);
                } else
                {
                    res = await HttpClientHelper.PostAsync<DiningTable>("dining_table", diningTable);
                }
                diningTablesForm.LoadItems();
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplyTranslation()
        {
            this.Text = AppLocalization.Translate(this.Text);
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>
            {
                lblCode, lblChinese, lblEnglish, lblKhmer, lblPersonCount, lblRemark,
                lblRoomServiceFixPrice, lblRoomServicePercentage, lblStatus, lblFloor, lblTaxFixPrice,
            });
            AppLocalization.TranslateObjects<RadCheckBox>(new List<RadCheckBox>
            {
                cbIsEnable, cbIsBroken
            });

            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void txtChineseName_MouseEnter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchChineseKeyboard();
        }

        private void txtChineseName_MouseLeave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtKhmerName_MouseEnter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchKhmerKeyboard();
        }

        private void txtKhmerName_MouseLeave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }
    }
}
