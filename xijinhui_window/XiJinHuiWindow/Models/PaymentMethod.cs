using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class PaymentMethod : HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("payment_code")]
        public string PaymentCode { get; set; }

        [JsonPropertyName("payment_url")]
        public string PaymentUrl { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
