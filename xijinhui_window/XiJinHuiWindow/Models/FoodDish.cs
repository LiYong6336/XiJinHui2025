using XiJinHuiWindow.Utils;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Properties;

namespace XiJinHuiWindow.Models
{
    public class FoodDish : HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("category_id")]
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }

        [JsonPropertyName("food_code")]
        public string FoodCode { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("food_price"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? FoodPrice { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("food_photo")]
        public string FoodPhoto { get; set; }

        [JsonPropertyName("food_photo_url")]
        public string FoodPhotoUrl { get; set; }

        [JsonPropertyName("english_keyword")]
        public string EnglishKeyword { get; set; }

        [JsonPropertyName("chinese_keyword")]
        public string ChineseKeyword { get; set; }

        [JsonPropertyName("khmer_keyword")]
        public string KhmerKeyword { get; set; }

        [JsonPropertyName("display_order")]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("is_enable")]
        public bool? IsEnable { get; set; }

        [JsonPropertyName("can_change_price")]
        public bool? CanChangePrice { get; set; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("food_dish_details")]
        public List<FoodDishDetail> FoodDishDetails { get; set; }

        [JsonPropertyName("food_ingredients")]
        public List<FoodIngredient> FoodIngredients { get; set; }

        [JsonPropertyName("animal_parts")]
        public List<AnimalPart> AnimalParts { get; set; }
    }

}
