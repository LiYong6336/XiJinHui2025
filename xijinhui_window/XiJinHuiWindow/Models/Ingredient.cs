using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class Ingredient: HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("quantity"), JsonConverter(typeof(StringToDoubleConverter)) ]
        public double Quantity { get; set; }

        [JsonPropertyName("un_package"), JsonConverter(typeof(StringToDoubleConverter))]
        public double UnPackage { get; set; }

        [JsonPropertyName("unit_capacity"), JsonConverter(typeof(StringToDoubleConverter))]
        public double UnitCapacity { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("chinese_keyword")]
        public string ChineseKeyword { get; set; }

        public string FullNameWithKeyword {
            get => FullName + " - " + ChineseKeyword;
        }
    }
}
