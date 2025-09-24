using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.Reporting;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Text.Json;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Utils;
using System.Windows.Controls;
using System.Diagnostics;

namespace XiJinHuiWindow
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        Telerik.WinControls.UI.RadForm form;

        public MainForm()
        {
            string computerName = "Computer Name: " + Environment.MachineName;
            //string ipAddress = "IP Add: " + Dns.GetHostAddresses(Environment.MachineName)[0].ToString();
            var ips = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            string ipAddress = "IP Addr: " + ips[ips.Length - 1];

            //System.Threading.Thread.CurrentThread.CurrentCulture =
            //System.Globalization.CultureInfo.GetCultureInfo((PublicVariable.User).user_language.ToString());
            //System.Threading.Thread.CurrentThread.CurrentUICulture =
            //    System.Globalization.CultureInfo.GetCultureInfo((PublicVariable.User).user_language.ToString());

            InitializeComponent();

            //this.Text= "Human Resource Management" + Application.ProductVersion.ToString();
            //this.Text = XiJinHuiWindow.Properties.Resources.HumanResourceManagement + ' ' + computerName + ' ' + ipAddress;



            //this.Font = PublicVariable.fontStyleByLanguage();
        }




        private void RadForm1_Load(object sender, EventArgs e)
        {
            List<SettingMenu> jsonObj = JsonSerializer.Deserialize<List<SettingMenu>>(Settings.Default.Menus);

            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(899, 37);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Font = PublicVariable.fontStyleByLanguage();
            this.MenuMain.ThemeName = "MaterialPink";

            // 
            // radMenuItem
            // 

            foreach (SettingMenu item in jsonObj)
            {
                var radItem = new Telerik.WinControls.UI.RadMenuItem();
                radItem.Name = item.RoutePath;

                //radItem.Text = item[PublicVariable.LanguageField()];
                radItem.Text = GeneralFunction.GetPropertyValue(item, PublicVariable.LanguageField()).ToString();

                if (item.RoutePath != null)
                {
                    radItem.Click += new EventHandler(this.RadItem_Click);
                }

                //foreach(var sub in item["children"])
                //{
                //    var radSubItem = new Telerik.WinControls.UI.RadMenuItem();
                //    radSubItem.Name = sub["id"];
                //    radSubItem.Font = PublicVariable.fontStyleByLanguage(fontSize:10);
                //    radSubItem.Text = sub[PublicVariable.languageField()];
                //    radItem.Items.AddRange(new Telerik.WinControls.RadItem[]
                //    {
                //    radSubItem});

                //    radSubItem.Click += new EventHandler(this.RadItem_Click);
                //}
                BuildNestedMenu(item.Children, radItem);

                this.MenuMain.Items.AddRange(new Telerik.WinControls.RadItem[]
                {
                    radItem
                });
            }
        }

        private void BuildNestedMenu(List<SettingMenu> jsonObj, Telerik.WinControls.UI.RadMenuItem radItem)
        {
            foreach (var sub in jsonObj)
            {
                var radSubItem = new Telerik.WinControls.UI.RadMenuItem();
                radSubItem.Name = sub.RoutePath;
                radSubItem.Font = PublicVariable.fontStyleByLanguage(fontSize: 10);
                radSubItem.Text = GeneralFunction.GetPropertyValue(sub, PublicVariable.LanguageField()).ToString();
                radItem.Items.AddRange(new Telerik.WinControls.RadItem[] { radSubItem });

                if (sub.RoutePath != null)
                {
                    radSubItem.Click += new EventHandler(this.RadItem_Click);

                }
                else
                {
                    BuildNestedMenu(sub.Children, radSubItem);
                }
            }
        }

        private void RadItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((RadMenuItem)sender).Name);

            //switch (int.Parse(((RadMenuItem)sender).Name))
            //SettingMenu t = e.Tag as SettingMenu;
            //var mName = int.Parse(((RadMenuItem)sender).Name);
            var mName = ((RadMenuItem)sender).Name;
            if (!string.IsNullOrEmpty(mName.ToString()))
            {
                try
                {

                    var frm = GetFormFromString(mName + "Form");
                    frm.MdiParent = this;
                    //frm.TopLevel = false;
                    //frm.Dock = DockStyle.Fill;
                    //OpenChildForm(frm);
                    //ActivateButton(sender, isChild: t.ParentId > 0);
                    frm.Show();
                }
                catch (Exception ex) { }
            }
            else
            {
                MessageBox.Show($"You clicked {mName}!");
            }

        }

        private RadForm GetFormFromString(string formName)
        {
            try
            {
                // Get the type of the form
                Type formType = Type.GetType("XiJinHuiWindow.Forms." + formName);
                if (formType == null)
                {
                    MessageBox.Show($"Form {formName} not found.");
                    throw new Exception($"Form {formName} not found.");
                }

                // Create an instance of the form
                RadForm formInstance = (RadForm)Activator.CreateInstance(formType);

                // Show the form
                //formInstance.Show();
                return formInstance;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
