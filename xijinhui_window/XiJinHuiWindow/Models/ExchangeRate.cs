using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class ExchangeRate
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("exchange_date")]
        public string ExchangeDate { get; set; }

        [JsonPropertyName("exchange_year")]
        public int? ExchangeYear { get; set; }

        [JsonPropertyName("exchange_month")]
        public int? ExchangeMonth { get; set; }

        [JsonPropertyName("exchange_year_month")]
        public string ExchangeYearMonth { get; set; }

        [JsonPropertyName("exchange_days")]
        public int? ExchangeDays { get; set; }

        [JsonPropertyName("rate_standard"), JsonConverter(typeof(StringToDoubleConverter)) ]
        public double? RateStandard { get; set; }

        [JsonPropertyName("rate_returned"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? RateReturned { get; set; }

        [JsonPropertyName("rate_nssf"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? RateNssf { get; set; }

        [JsonPropertyName("rate_taxation"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? RateTaxation { get; set; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
