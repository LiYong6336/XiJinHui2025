using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Windows.Forms;
using System.Reflection;
using System.Net.Http;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Printing;
using Telerik.Reporting.Processing;
using static Telerik.WinControls.UI.ValueMapper;

namespace XiJinHuiWindow.Utils
{
    public class GeneralFunction
    {
        public static void BindCombobox<T>(RadDropDownList _cmb, List<T> items, string value, Func<T, string> textCb)
        {
            foreach (T ds in items) {
                var item = new RadListDataItem { 
                    Value = (int) GetPropertyValue(ds, value),
                    Text = textCb(ds),
                };
                _cmb.Items.Add(item);
            }
        }
        public static object GetPropertyValue(object obj, string propertyName=null)
        {
            propertyName = string.IsNullOrEmpty(propertyName)? PublicVariable.LanguageField(): propertyName;
            if(obj == null) return propertyName;
            var prop = obj.GetType().GetProperty(propertyName);
            if (prop != null)
            {
                return prop.GetValue(obj);
            }
            Debug.WriteLine("=================================:"+propertyName);
            throw new ArgumentException("Property not found", nameof(propertyName));
        }
        public static void SetPropertyValue(object obj, string propertyName, object value)
        {
            Type type = obj.GetType();

            PropertyInfo property = type.GetProperty(propertyName);

            if (property != null && property.CanWrite)
            {
                property.SetValue(obj, value);
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' not found or is not writable.");
            }
        }
        public static void SwitchKhmerKeyboard()
        {
            var CName = string.Empty;
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();

                if (CName.StartsWith("Khmer"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }
        public static void SwitchChineseKeyboard()
        {
            var CName = string.Empty;
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();

                if (CName.StartsWith("Chinese"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }
        public static void SwitchEnglishKeyboard()
        {
            var CName = string.Empty;
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();

                if (CName.StartsWith("English"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }

        public static async Task<Image> LoadImageFromUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                Debug.WriteLine(url + "=======================================");
                byte[] imageData = await client.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public static void ApplyFontToAllControls(Control parent, Font font = null)
        {
            foreach (Control control in parent.Controls)
            {
                if (font == null)
                {
                    control.Font = PublicVariable.fontStyleByLanguage();
                } else
                {
                    control.Font = font;
                }

                // If the control has children, apply the font recursively
                if (control.HasChildren)
                {
                    ApplyFontToAllControls(control, font);
                }
            }
        }
        public static decimal ConvertNumber(Object _obj)
        {
            try
            {
                return Convert.ToDecimal(_obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static double ConvertDouble(Object _obj)
        {
            try
            {
                return Convert.ToDouble(_obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static Image ResizeImageToFit(Image originalImage, Size targetSize)
        {
            // Calculate the aspect ratio
            float originalAspectRatio = (float)originalImage.Width / originalImage.Height;
            float targetAspectRatio = (float)targetSize.Width / targetSize.Height;

            int newWidth, newHeight;

            // Determine the new size based on the aspect ratio
            if (originalAspectRatio > targetAspectRatio)
            {
                // Fit to width
                newWidth = targetSize.Width;
                newHeight = (int)(targetSize.Width / originalAspectRatio);
            }
            else
            {
                // Fit to height
                newWidth = (int)(targetSize.Height * originalAspectRatio);
                newHeight = targetSize.Height;
            }

            // Create a new bitmap with the desired size
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            // Draw the original image onto the resized bitmap
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        public static Image ResizeAndCropImage(Image originalImage, Size targetSize)
        {
            // Calculate the aspect ratio
            float originalAspectRatio = (float)originalImage.Width / originalImage.Height;
            float targetAspectRatio = (float)targetSize.Width / targetSize.Height;

            int resizeWidth, resizeHeight;

            // Resize while maintaining aspect ratio
            if (originalAspectRatio > targetAspectRatio)
            {
                // The original image is wider, so fit to height
                resizeHeight = targetSize.Height;
                resizeWidth = (int)(targetSize.Height * originalAspectRatio);
            }
            else
            {
                // The original image is taller, so fit to width
                resizeWidth = targetSize.Width;
                resizeHeight = (int)(targetSize.Width / originalAspectRatio);
            }

            // Create a new bitmap for the resized image
            Bitmap resizedImage = new Bitmap(resizeWidth, resizeHeight);

            // Draw the original image onto the resized bitmap
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, resizeWidth, resizeHeight);
            }

            // Calculate the cropping rectangle
            int cropX = (resizeWidth - targetSize.Width) / 2;
            int cropY = (resizeHeight - targetSize.Height) / 2;
            Rectangle cropArea = new Rectangle(cropX, cropY, targetSize.Width, targetSize.Height);

            // Crop the resized image
            Bitmap croppedImage = resizedImage.Clone(cropArea, resizedImage.PixelFormat);

            // Dispose the resized image as it's no longer needed
            resizedImage.Dispose();

            return croppedImage;
        }
        // Debounce method takes an action and a delay (in milliseconds)
        public static Action Debounce(Action action, int delayMilliseconds)
        {
            Timer timer = new Timer();
            timer.Interval = delayMilliseconds;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                action(); // Execute the debounced action
            };

            return () =>
            {
                timer.Stop();
                timer.Start(); // Restart the timer on each invocation
            };
        }

        public static void PrintReporting(Telerik.Reporting.Report rpt, string printerName)
        {
            PrinterSettings pns = new PrinterSettings();
            pns.PrinterName = printerName;

            ReportProcessor reportProcessor = new ReportProcessor();

            reportProcessor.PrintReport(rpt, pns);
        }

        public static string FormatNumber(object value)
        {
            decimal myValue = Convert.ToDecimal(value);
            string formattedValue = myValue % 1 == 0 ? $"{myValue:N0}" : $"{myValue:N2}";
            return formattedValue;
        }

        public static string FormatStandardDatetime(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static string FormatStandardDate(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }
        public static int ConvertInt(Object _obj)
        {
            try
            {
                return int.Parse((string)_obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }


}
