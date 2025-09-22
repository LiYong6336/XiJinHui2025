using XiJinHuiWindow.Forms.Cashier;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace XiJinHuiWindow.Forms
{
    public partial class AdminChooseForm : Telerik.WinControls.UI.RadForm
    {
        public AdminChooseForm()
        {
            InitializeComponent();
        }

        private void AdminChooseForm_Load(object sender, EventArgs e)
        {
            AppLocalization.TranslateObjects<IconButton>(new List<IconButton>
            {
                btnDashboard, btnCashier,
            });
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Dispose();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            tableForm.Show();
            this.Dispose();
        }
    }
}
