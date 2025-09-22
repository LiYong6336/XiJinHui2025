using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models.Responses
{
    public class Response<T>
    {

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        [JsonPropertyName("total_amount2")]
        public string TotalAmount2 { get; set; }

        [JsonPropertyName("total_by_methods")]
        public List<string> TotalByMethods { get; set; }
        [JsonPropertyName("customer_topup"), JsonConverter(typeof(StringToDoubleConverter))]
        public double CustomerTopup { get; set; }

        [JsonPropertyName("pay_owed"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? PayOwed { get; set; }
    }

}
