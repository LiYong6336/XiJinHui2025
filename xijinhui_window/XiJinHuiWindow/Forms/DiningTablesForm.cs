using XiJinHuiWindow.Forms;
using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms
{
    public partial class DiningTablesForm : RadForm
    {
        private List<DiningTable> items = new List<DiningTable>();
        private DiningTable item = new DiningTable();
        public DiningTablesForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            //gridItems.BestFitColumns(BestFitColumnMode.DisplayedDataCells);

            TranslateTexts();
        }

        public async void LoadItems()
        {
            try
            {
                items.Clear();
                Response<DiningResponse> res = await HttpClientHelper.GetAsync<DiningResponse>("dining_table");
                foreach (DiningTable table in res.Data.Dining)
                {
                    table.DiningFloorName = table.DiningFloor.EnglishName + " - " + table.DiningFloor.ChineseName + " - " + table.DiningFloor.KhmerName;
                    items.Add(table);
                }
                gridItems.DataSource = items;
                gridItems.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void TranslateTexts()
        {
            this.Text = AppLocalization.Translate(this.Text);
            //AppLocalization.TranslateObjects<RadButton>(new List<RadButton> { btnDelete, btnNew  });
            AppLocalization.TranslateGridView(gridItems);
            GeneralFunction.ApplyFontToAllControls(this);
        }

 
        private void gridItems_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];
                btnDelete.Visible = true;
            }
        }

        private void gridItems_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                item = items[e.RowIndex];

                DiningTableCUForm frm = new DiningTableCUForm(this);
                frm.SetFormData(item);
                frm.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DiningTableCUForm frm = new DiningTableCUForm(this);
            frm.ShowDialog();
            LoadItems();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = await HttpClientHelper.DeleteAsync("dining_table/" + item.Id);
                LoadItems();
                item = new DiningTable();
                btnDelete.Visible = false;
            }
            catch (Exception ex)
            {
            }
        }

    }

    public class DiningResponse
    {
        [JsonPropertyName("dining")]
        public List<DiningTable> Dining { get; set; }

        //[JsonPropertyName("busyTable")]
        //public  BusyTable { get; set; } 

    }
}
