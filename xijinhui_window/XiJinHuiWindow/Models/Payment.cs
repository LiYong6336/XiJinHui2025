using System.Text.Json.Serialization;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class Payment
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("sale_table_id")]
        public string SaleTableId { get; set; }

        [JsonPropertyName("payment_method_id")]
        public int? PaymentMethodId { get; set; }

        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        [JsonPropertyName("amount_dollar"),  JsonConverter(typeof(StringToDoubleConverter))]
        public double? AmountDollar { get; set; }

        [JsonPropertyName("amount_riel"),  JsonConverter(typeof(StringToDoubleConverter))]
        public double? AmountRiel { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

    }
}
