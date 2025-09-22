using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    internal class UsageReport
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity"), JsonConverter(typeof(StringToDoubleConverter))]
        public double Quantity { get; set; }

        [JsonPropertyName("total_sale_qty"), JsonConverter(typeof(StringToDoubleConverter))]
        public double TotalSaleQty { get; set; }

        [JsonPropertyName("stock_in"), JsonConverter(typeof(StringToDoubleConverter))]
        public double StockIn { get; set; }
        [JsonPropertyName("stock_out"), JsonConverter(typeof(StringToDoubleConverter))]
        public double StockOut { get; set; }
    }
}
