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
    public partial class UsersForm : Telerik.WinControls.UI.RadForm
    {
        User user = new User();
        List<User> users = new List<User>();

        public UsersForm()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            LoadRelation();
            TranslateText();
            foreach(var lang in User.Languages.Keys)
            {
                ddLanguage.Items.Add(new RadListDataItem
                {
                    Text = User.Languages[lang],
                    Value = lang,
                });
            }
            ddLanguage.SelectedIndex = 0;
        }

        private async void LoadRelation()
        {
            Response<List<Role>> rolesRes = await HttpClientHelper.GetAsync<List<Role>>("roles");
            foreach (Role r in rolesRes.Data)
            {
                ddRole.Items.Add(new RadListDataItem { Text = r.Name, Value = r.Id });
            }
            ddRole.SelectedValue = 3;
        }

        private async void BindData()
        {
            Response<List<User>> res = await HttpClientHelper.GetAsync<List<User>>("users");
            users = res.Data;
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            //txtName.Clear();
            txtUsername.Clear();
            //txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                user = users[e.RowIndex];
                //txtName.Text = user.Name;
                txtUsername.Text = user.Username;
                //txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                cbIsAdmin.Checked = user.IsAdmin==1;
                ddLanguage.SelectedValue = user.UserLocale;
                if (user.Roles.Count > 0)
                {
                    ddRole.SelectedValue = user.Roles[0].Id;
                } else
                {
                    ddRole.SelectedValue = null;
                }
                btnDelete.Visible = true;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {

                try
                {
                    //user.Name = txtName.Text;
                    user.Username = txtUsername.Text;
                    //user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    user.Phone = txtPhone.Text;
                    user.IsAdmin = cbIsAdmin.Checked ? 1 : 0;
                    user.RoleId = (int?) ddRole.SelectedValue;
                    user.UserLocale = (string)ddLanguage.SelectedValue;
                    Response<User> res;
                    if (user.Id > 0)
                    {
                        res = await HttpClientHelper.PutAsync<User>("users/" + user.Id, user);
                    }
                    else
                    {
                        res = await HttpClientHelper.PostAsync<User>("users", user);
                    }

                    ClearData();
                    BindData();
                    MessageBox.Show("Sucessful Save Changed");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Data["message"].ToString());
                }

                //BindData();
            }
            else
            {
                MessageBox.Show("Username Cann't Empty");
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
                lblUsername, lblPassword, lblLocale, lblPhone,
            });
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> {
            //    btnModify, btnClear, btnCancel, btnDelete,
            //});
            AppLocalization.TranslateObjects<RadCheckBox>(new List<RadCheckBox> {
                cbIsAdmin
            });
            AppLocalization.TranslateGridView(dgView);
            GeneralFunction.ApplyFontToAllControls(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("users/" + user.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
