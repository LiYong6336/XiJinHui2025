using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class SetInvoice
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        [JsonPropertyName("invoice_start")]
        public int? InvoiceStart { get; set; }

        [JsonPropertyName("invoice_count")]
        public int? InvoiceCount { get; set; }

        [JsonPropertyName("invoice_end")]
        public int? InvoiceEnd { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

    }
}
