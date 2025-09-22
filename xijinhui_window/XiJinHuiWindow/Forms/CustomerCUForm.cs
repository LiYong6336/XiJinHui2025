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
using XiJinHuiWindow.Models.Requests;


namespace XiJinHuiWindow.Forms
{
    public partial class CustomerCUForm : Telerik.WinControls.UI.RadForm
    {
        private CustomersForm customersForm;
        public Customer customer;

        private string foodPhotoPath;
        public CustomerCUForm( CustomersForm dtForm)
        {
            InitializeComponent();
            customersForm = dtForm;
            customer = new Customer();

            var genders = new List<Gender>
            {
                new Gender{Name="Male", Value="m" },
                new Gender{Name="Female", Value="f" },
            };

            foreach (Gender g in genders) {
                var item = new RadListDataItem { 
                    Value =  g.Value,
                    Text = g.Name,
                };
                ddGender.Items.Add(item);
            }
        }

        private void CustomerCUForm_Load(object sender, EventArgs e)
        {
            ApplyTranslation();
        }
        

        public void SetFormData(Customer dt)
        {
            customer = dt;
            txtCode.Text = dt.Code;
            txtEnglishName.Text = dt.EnglishName;
            txtChineseName.Text = dt.ChineseName;
            txtKhmerName.Text = dt.KhmerName;
            txtAddress.Text = dt.Address;
            txtPhone.Text = dt.Phone;
            dtDob.Text = dt.Dob;
            ddGender.SelectedValue = dt.Gender;
            txtBalance.Text = dt.Balance.ToString();

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            customer.Code = txtCode.Text;
            customer.EnglishName = txtEnglishName.Text;
            customer.ChineseName = txtChineseName.Text;
            customer.KhmerName = txtKhmerName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;
            customer.Dob = dtDob.Text;
            customer.Gender =(string) ddGender.SelectedValue;
            customer.Balance = double.TryParse( txtBalance.Text, out double bl) ? bl :0;

            List<FileField> files = new List<FileField>();
            if (!string.IsNullOrEmpty(foodPhotoPath))
            {
                files.Add(new FileField { FieldName="food_photo_upload", FilePath=foodPhotoPath });
            }

            try
            { 
                Response<Customer> res;
                if(customer.Id > 0)
                {
                    res= await HttpClientHelper.PutAsync<Customer>("customers/"+ customer.Id, customer, files);
                } else
                {
                    res = await HttpClientHelper.PostAsync<Customer>("customers", customer, files);
                }
                this.Close();
                customersForm.LoadItems();
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
            this.Text = AppLocalization.Translate(customer.Id>0 ? "update_customer": "create_customer");
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>
            {
                lblCode, lblChinese, lblEnglish, lblKhmer, lblAddress,
                 lblDob, lblBalance, lblPhone,
            });
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private void txtKhmerName_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();
        }

        private void txtKhmerName_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchKhmerKeyboard();
        }

        private void txtChineseName_Leave(object sender, EventArgs e)
        {
            GeneralFunction.SwitchEnglishKeyboard();

        }

        private void txtChineseName_Enter(object sender, EventArgs e)
        {
            GeneralFunction.SwitchChineseKeyboard();
        }
    }
}
