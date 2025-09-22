using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class RolesForm : Telerik.WinControls.UI.RadForm
    {
        Role role = new Role();
        List<Role> roles = new List<Role>();

        public RolesForm()
        {
            InitializeComponent();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            ClearData();
            BindData();
            LoadMenu();
            TranslateText();
        }

        private void LoadMenu()
        {
            cklMenu.Items.Clear();
            List<SettingMenu> menus = JsonSerializer.Deserialize<List<SettingMenu>>(Settings.Default.Menus);
            BuildNestMenu(menus);
            //foreach (SettingMenu menu in menus)
            //{
            //    var item = new ListViewDataItem { Value = menu.Id, Text = menu.GetNameConcat(" - "), Tag = menu };
            //    cklMenu.Items.Add(item);
            //}
        }

        private void BuildNestMenu(List<SettingMenu> menus, string spacer = "")
        {
            foreach (SettingMenu menu in menus)
            {
                var item = new ListViewDataItem { Value = menu.Id, Text = spacer+ menu.GetNameConcat(" - "), Tag = menu };
                cklMenu.Items.Add(item);
                if(menu.ChineseName.Length > 0)
                {
                    BuildNestMenu(menu.Children, spacer + "--");
                }
            }
        }

        private async void BindData()
        {
            roles.Clear();
            Response<List<Role>> res = await HttpClientHelper.GetAsync<List<Role>>("roles");
            foreach (Role r in res.Data)
            {
                foreach (SettingMenu sm in r.SettingMenus)
                {
                    r.MenusText += GeneralFunction.GetPropertyValue(sm, PublicVariable.LanguageField()) + ", ";
                }
                roles.Add(r);
            }
            dgView.DataSource = res.Data;
        }

        private void ClearData()
        {
            txtName.Clear();
            SetSelectedMenus(null);
            btnDelete.Visible = false;
        }

        private void dgView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                role = roles[e.RowIndex];
                txtName.Text = role.Name;
                SetSelectedMenus(role.SettingMenus);
                btnDelete.Visible = true;
            }
        }

        private void SetSelectedMenus(List<SettingMenu> settingMenus)
        {
            // Set "Permission 1" and "Permission 3" as selected by default
            for (int i = 0; i < cklMenu.Items.Count; i++)
            {
                var item = cklMenu.Items[i];
                item.CheckState = ToggleState.Off;
                if (settingMenus != null)
                {
                    foreach (var menu in settingMenus)
                    {
                        if (menu.Id == (item.Tag as SettingMenu).Id)
                        {
                            item.CheckState = ToggleState.On;
                        }
                    }
                }
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {

                try
                {
                    List<int> menuIds = new List<int>();
                    foreach (var ckItem in cklMenu.Items)
                    {
                        if (ckItem.CheckState == ToggleState.On)
                        {
                            menuIds.Add((ckItem.Tag as SettingMenu).Id);
                            Debug.WriteLine(ckItem.Value);
                        }
                    }
                    role.MenuIds = menuIds;

                    role.Name = txtName.Text;
                    Response<Role> res;
                    if (role.Id > 0)
                    {
                        res = await HttpClientHelper.PutAsync<Role>("roles/" + role.Id, role);
                    }
                    else
                    {
                        res = await HttpClientHelper.PostAsync<Role>("roles", role);
                    }

                    ClearData();
                    BindData();
                    MessageBox.Show("Sucessful Save Changed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Name Can't Empty");
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
                  lblName, lblMenu,
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
                bool res = await HttpClientHelper.DeleteAsync("roles/" + role.Id);

                ClearData();
                BindData();
            }
            catch (Exception ex)
            {
            }
        }

    }
}
