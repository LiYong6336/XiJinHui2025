using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class FoodDishDetail: HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("price"), JsonConverter(typeof(StringToDoubleConverter))]
        public double? Price { get; set; }

        [JsonPropertyName("food_dish_id")]
        public int? FoodDishId { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("food_ingredients")]
        public List<FoodIngredient> FoodIngredients { get; set; }

    }
}
