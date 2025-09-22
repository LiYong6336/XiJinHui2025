using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class HasNameLanguages
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; }

        [JsonPropertyName("chinese_name")]
        public string ChineseName { get; set; }

        [JsonPropertyName("khmer_name")]
        public string KhmerName { get; set; }

        public string FullName
        {
            get
            {
                return GetNameConcat(" - ");
            }
        }

        public string GetNameConcat(string separator = "-")
        {
            var l = new List<string> { EnglishName, ChineseName, KhmerName };
            var filtered = l.Where(e => !string.IsNullOrEmpty(e)).ToList();
            return string.Join(separator, filtered);
        }
    }
}
