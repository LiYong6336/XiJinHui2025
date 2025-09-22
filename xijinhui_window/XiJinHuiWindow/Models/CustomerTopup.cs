using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    internal class CustomerTopup
    {
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            [JsonPropertyName("before_balance"),  JsonConverter(typeof(StringToDoubleConverter))]
            public double? BeforeBalance { get; set; }

            [JsonPropertyName("topup_amount"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? TopupAmount { get; set; }

            [JsonPropertyName("after_balance"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? AfterBalance { get; set; }

            [JsonPropertyName("customer_id")]
            public int? CustomerId { get; set; }

            [JsonPropertyName("user_id")]
            public int? UserId { get; set; }

            [JsonPropertyName("created_at")]
            public string CreatedAt { get; set; }

            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }

            [JsonPropertyName("customer")]
            public Customer Customer { get; set; }

    }
}
