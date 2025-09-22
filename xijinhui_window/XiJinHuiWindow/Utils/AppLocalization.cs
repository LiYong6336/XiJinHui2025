using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;
using System.Reflection;
using System.Windows.Markup;
using System.Runtime.CompilerServices;

namespace XiJinHuiWindow.Utils
{
    public static class AppLocalization
    {
        private static Dictionary<string, string> translations;

        public static void Load(string language)
        {
            //string filePath = $"Locale/{language}.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Locale", $"{language}.json");

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                translations = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading JSON file: " + ex.Message);
                Debug.WriteLine("Error loading JSON file: " + ex.Message);
                translations = new Dictionary<string, string>();
            }
        }

        public static string Translate(string key)
        {
            var key1 = key.Replace(" ", "_");
            string snakeKey = ConvertPascalToSnakeCase(key1).Replace("__", "_").ToLower();
            if (translations != null)
            {
                if (translations.ContainsKey(snakeKey))
                    return translations[snakeKey];
                if (translations.ContainsKey(key))
                    return translations[key];
            }
            return key;
        }
        public static void TranslateObjects<T>(List<T> items)
        {
            foreach (T item in items)
            {
                PropertyInfo textProperty = typeof(T).GetProperty("Text");
                if (textProperty != null)
                {
                    // Property exists, get its value
                    object value = textProperty.GetValue(item);
                    GeneralFunction.SetPropertyValue(item, "Text", Translate((string)value));
                }
            }

        }

        public static void TranslateGridView(RadGridView gd)
        {
            foreach (GridViewDataColumn col in gd.Columns)
            {
                col.HeaderText = Translate(col.HeaderText);
            }
        }
        public static string ConvertPascalToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string snakeCase = Regex.Replace(input, "([a-z])([A-Z])", "$1_$2").ToLower();
            return snakeCase;
        }

    }
}
