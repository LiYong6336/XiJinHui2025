using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class SaleDetail
    {
        private string _FoodDishJson;
        private string _FoodDishDetailJson;

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("sale_table_id")]
        public string SaleTableId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("qty"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? Qty { get; set; }

        [JsonPropertyName("old_qty"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? OldQty { get; set; }

        [JsonPropertyName("food_price"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? FoodPrice { get; set; }

        [JsonPropertyName("total_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? TotalAmount { get; set; }

        [JsonPropertyName("discount_percentage"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? DiscountPercentage { get; set; }

        [JsonPropertyName("discount_amount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? DiscountAmount { get; set; }

        [JsonPropertyName("total_amount_after_discount"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? TotalAmountAfterDiscount { get; set; }

        [JsonPropertyName("food_dish_json")]
        public string FoodDishJson
        {
            get
            {
                return _FoodDishJson;
            }
            set
            {
                _FoodDishJson = value;
                FoodDish = JsonSerializer.Deserialize<FoodDish>(value);
            }
        }

        [JsonPropertyName("food_dish_detail_json")]
        public string FoodDishDetailJson
        {
            get
            {
                return _FoodDishDetailJson;
            }
            set
            {
                _FoodDishDetailJson = value;
                if (FoodDishDetailJson != null)
                {
                    FoodDishDetail = JsonSerializer.Deserialize<FoodDishDetail>(value);
                }
            }
        }
        public FoodDish FoodDish { get; set; }
        public FoodDishDetail FoodDishDetail { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        // cart
        public string QtyPrice { get; set; }
        public int? NO { get; set; } // N.O
        public string LangDescription
        {
            get
            {
                //var str = (string)GeneralFunction.GetPropertyValue(this.FoodDish);
                var str = (string)this.FoodDish.FullName;
                if (this.FoodDishDetail != null)
                {
                    //str = str + " ("+ GeneralFunction.GetPropertyValue(this.FoodDishDetail ) +")";
                    str = str + " (" + this.FoodDishDetail.FullName + ")";
                }
                if (Remark != null && Remark != "")
                {
                    str = str + " (" + Remark + ")";
                }
                return str;
            }
        }
    }
}
