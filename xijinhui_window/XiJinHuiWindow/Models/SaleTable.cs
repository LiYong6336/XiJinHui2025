using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class SaleTable
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("dining_table_id")]
        public int? DiningTableId { get; set; }

        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        [JsonPropertyName("sale_order_number")]
        public string SaleOrderNumber { get; set; }

        [JsonPropertyName("showing_invoice_number")]
        public string ShowingInvoiceNumber { get; set; }

        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("sale_date")]
        public string SaleDate { get; set; }

        [JsonPropertyName("exchange_rate"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? ExchangeRate { get; set; }

        [JsonPropertyName("person_count")]
        public int? PersonCount { get; set; }

        [JsonPropertyName("total_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? TotalAmount { get; set; }

        [JsonPropertyName("discount_percentage"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? DiscountPercentage { get; set; }

        [JsonPropertyName("discount_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? DiscountAmount { get; set; }

        [JsonPropertyName("tax_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? TaxAmount { get; set; }

        [JsonPropertyName("room_service_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? RoomServiceAmount { get; set; }

        [JsonPropertyName("grand_total"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? GrandTotal { get; set; }

        [JsonPropertyName("received_dollar"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? ReceivedDollar { get; set; }

        [JsonPropertyName("received_riel"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? ReceivedRiel { get; set; }

        [JsonPropertyName("return_dollars"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? ReturnDollars { get; set; }

        [JsonPropertyName("return_riels"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? ReturnRiels { get; set; }

        [JsonPropertyName("balance_dollars"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? BalanceDollars { get; set; }

        [JsonPropertyName("owed_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? OwedAmount { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("finished_dining_date")]
        public string FinishedDiningDate { get; set; }

        [JsonPropertyName("take_time")]
        public int? TakeTime { get; set; }

        [JsonPropertyName("pre_receipt_print_time")]
        public int? PreReceiptPrintTime { get; set; }

        [JsonPropertyName("receipt_print_time")]
        public int? ReceiptPrintTime { get; set; }

        [JsonPropertyName("making_status")]
        public int? MakingStatus { get; set; }

        [JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        [JsonPropertyName("tax_declaration")]
        public int? TaxDeclaration { get; set; }

        [JsonPropertyName("clearing_user_id")]
        public int? ClearingUserId { get; set; }

        [JsonPropertyName("clearing_datetime")]
        public string ClearingDatetime { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("sale_detail")]
        public List<SaleDetail> SaleDetails { get; set; }

        [JsonPropertyName("dining_table")]
        public DiningTable DiningTable { get; set; }

        [JsonPropertyName("payments")]
        public List<Payment> Payments { get; set; }

        public string PaymentNameAndAmount
        {
            get
            {
                var str = "";
                var pMents = Payments ?? new List<Payment> { };
                foreach (var p in pMents)
                {
                    str += p.PaymentMethod.EnglishName + ":" + p.AmountDollar + "|" + p.AmountRiel + " ";
                }

                return str;
            }
        }

    }
}
