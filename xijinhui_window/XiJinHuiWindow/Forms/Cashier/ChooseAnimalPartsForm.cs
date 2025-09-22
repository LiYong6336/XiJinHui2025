using XiJinHuiWindow.Models;
using XiJinHuiWindow.Models.Responses;
using XiJinHuiWindow.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace XiJinHuiWindow.Forms.Cashier
{
    public partial class ChooseAnimalPartsForm : Telerik.WinControls.UI.RadForm
    {

        private SaleForm saleForm;
        private QuantityForm quantityForm;
        private FoodDish foodDish;
        private SaleTable saleTable;

        public ChooseAnimalPartsForm(SaleForm saleForm, QuantityForm quantityForm, SaleTable saleTable, FoodDish foodDish)
        {
            InitializeComponent();
            this.saleForm = saleForm;
            this.quantityForm = quantityForm;
            this.saleTable = saleTable;
            this.foodDish = foodDish;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            int? headId = null;
            foreach (var lbItem in lbHead.Items)
            {
                if (lbItem.CheckState == ToggleState.On)
                {
                    headId = (lbItem.Tag as AnimalPart).Id;
                }
            }
            int? tailId = null;
            foreach (var lbItem in lbTail.Items)
            {
                if (lbItem.CheckState == ToggleState.On)
                {
                    tailId = (lbItem.Tag as AnimalPart).Id;
                }
            }
            int? wholeId = null;
            foreach (var lbItem in lbWhole.Items)
            {
                if (lbItem.CheckState == ToggleState.On)
                {
                    wholeId = (lbItem.Tag as AnimalPart).Id;
                }
            }
            int? mixId = null;
            foreach (var lbItem in lbMix.Items)
            {
                if (lbItem.CheckState == ToggleState.On)
                {
                    mixId = (lbItem.Tag as AnimalPart).Id;
                }
            }

            quantityForm.headId = headId;
            quantityForm.tailId = tailId;
            quantityForm.wholeId = wholeId;
            quantityForm.mixId = mixId;

            this.Dispose();
            quantityForm.btnEnter_Click(sender, e);
        }
        private void ApplyTranslations()
        {
            AppLocalization.TranslateObjects<RadLabel>(new List<RadLabel>
            {
                lblHead, lblWhole, lblTail, lblMix
            });
            GeneralFunction.ApplyFontToAllControls(this);

        }

        private async void ChooseAnimalPartsForm_Load(object sender, EventArgs e)
        {
            Response<List<AnimalPart>> res = await HttpClientHelper.GetAsync<List<AnimalPart>>("animal-parts");
            var animalPartGroups = res.Data.GroupBy(ap => ap.Type);

            foreach (var g in animalPartGroups)
            {
                foreach (AnimalPart ap in g)
                {
                    var item = new ListViewDataItem { Value = ap.Id, Text = ap.GetNameConcat(" - "), Tag = ap };
                    if (g.Key == "h")
                    {
                        lbHead.Items.Add(item);
                    }
                    if (g.Key == "t")
                    {
                        lbTail.Items.Add(item);
                    }
                    if (g.Key == "w")
                    {
                        lbWhole.Items.Add(item);
                    }
                    if (g.Key == "m")
                    {
                        lbMix.Items.Add(item);
                    }
                }
            }

            ApplyTranslations();
        }

        private void lb_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            Debug.WriteLine(sender);
            RadListViewElement listBox = sender as RadListViewElement;

            // Uncheck all other items when one item is checked
            if (e.Item.CheckState == ToggleState.On)
            {
                foreach (ListViewDataItem item in listBox.Items)
                {
                    if (item != e.Item)
                    {
                        item.CheckState = ToggleState.Off;
                    }
                }
            }
        }
    }
}
