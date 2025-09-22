using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
    {
        public class StockItem
        {
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            [JsonPropertyName("quantity"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? Quantity { get; set; }

            [JsonPropertyName("before_quantity"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? BeforeQuantity { get; set; }

            [JsonPropertyName("after_quantity"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? AfterQuantity { get; set; }

            [JsonPropertyName("price"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? Price { get; set; }

            [JsonPropertyName("note")]
            public string Note { get; set; }

            [JsonPropertyName("created_at")]
            public string CreatedAt { get; set; }

            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }

            [JsonPropertyName("mfp_date")]
            public string MfpDate { get; set; }

            [JsonPropertyName("exp_date")]
            public string ExpDate { get; set; }

            [JsonPropertyName("item_id")]
            public int? ItemId { get; set; }

            [JsonPropertyName("item")]
            public Ingredient Item { get; set; }
        }
}
