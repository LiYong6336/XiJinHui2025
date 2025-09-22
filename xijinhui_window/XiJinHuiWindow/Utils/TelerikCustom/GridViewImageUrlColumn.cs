using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Drawing;

namespace XiJinHuiWindow.Utils.TelerikCustom
{
    public class GridViewImageUrlColumn : GridViewImageColumn
    {
        public override Type GetCellType(GridViewRowInfo row)
        {
            return typeof(GridViewImageUrlCellElement);
        }
    }
    public class GridViewImageUrlCellElement : GridImageCellElement
    {
        public GridViewImageUrlCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        protected override void SetContentCore(object value)
        {
            base.SetContentCore(value);

            string imageUrl = value as string;
            if (!string.IsNullOrEmpty(imageUrl))
            {
                LoadImageAsync(imageUrl);
            }
        }

        private async void LoadImageAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync(url);
                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        this.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.Image = image;
                    }
                }
            }
            catch
            {
                // Handle exceptions
            }
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(GridImageCellElement); }
        }
    }
}
