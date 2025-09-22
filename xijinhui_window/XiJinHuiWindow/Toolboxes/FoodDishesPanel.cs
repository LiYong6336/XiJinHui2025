using XiJinHuiWindow.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiJinHuiWindow.Toolboxes
{
    public class FoodDishesPanel : Panel
    {
        public List<FoodDish> Items { get;  set; }  // List of items to render
        private int itemWidth = 100;  // Width of each item (adjusted for image and text)
        private int itemHeight = 100;  // Height of each item (adjusted for image and text)
        private int padding = 10;     // Padding between the items
        private int columns = 6;      // Number of items per row

        public FoodDishesPanel()
        {
            this.DoubleBuffered = true;  // Helps reduce flicker when rendering
            Items = new List<FoodDish>();    // Initialize the list of items
            this.MouseDown += CustomPanel_MouseDown;  // Subscribe to the MouseDown event
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Loop through items and render them in a grid
            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];

                // Calculate the item's row and column
                int row = i / columns;
                int col = i % columns;

                // Calculate the position of the item
                int x = col * (itemWidth + padding) + padding;
                int y = row * (itemHeight + padding) + padding;

                // Calculate the position of the image
                Rectangle imageRect = new Rectangle(x, y, itemWidth - padding, itemHeight - padding);

                // Draw the image if it has been loaded
                //if (item.Image != null)
                //{
                //    e.Graphics.DrawImage(item.Image, imageRect);
                //}
                //else
                //{
                //    // Optionally draw a placeholder or loading text
                //    e.Graphics.DrawString("Loading...", this.Font, Brushes.Gray, imageRect.Location);
                //}

                // Calculate the position of the text
                Point textPosition = new Point(x, y + itemHeight - padding - 20);  // Adjust text position under the image
                                                                                   // Draw the item name
                e.Graphics.DrawString(item.GetNameConcat("-"), this.Font, Brushes.Black, textPosition);
            }
        }

        // Handle MouseDown event to detect clicks
        private void CustomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Calculate which item was clicked based on its row and column
            int col = e.X / (itemWidth + padding);  // Determine which column
            int row = e.Y / (itemHeight + padding);  // Determine which row
            int clickedIndex = row * columns + col;

            // Ensure clickedIndex is within bounds of items
            if (clickedIndex >= 0 && clickedIndex < Items.Count)
            {
                FoodDish clickedItem = Items[clickedIndex];

                // Calculate the image bounds for the clicked item
                int x = col * (itemWidth + padding) + padding;
                int y = row * (itemHeight + padding) + padding;
                Rectangle imageRect = new Rectangle(x, y, itemWidth - padding, itemHeight - padding);

                // Check if the click was on the image
                if (imageRect.Contains(e.Location))
                {
                    MessageBox.Show($"Image clicked on item: {clickedItem.FullName}");
                }
                else
                {
                    // Perform action for the text or other parts of the item
                    MessageBox.Show($"Text clicked on item: {clickedItem.FullName}");
                }
            }
        }

        // Method to load all item images asynchronously
        public async Task LoadImagesAsync()
        {
            foreach (var item in Items)
            {
                //await item.DownloadImageAsync();
                this.Invalidate();  // Redraw the panel to update with the new image
            }
        }
    }
}
