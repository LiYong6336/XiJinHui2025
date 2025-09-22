using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class FoodIngredient
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("food_dish_id")]
        public int? FoodDishId { get; set; }

        [JsonPropertyName("food_dish_detail_id")]
        public int? FoodDishDetailId { get; set; }

        [JsonPropertyName("ingredient_id")]
        public int? IngredientId { get; set; }

        [JsonPropertyName("usage") , JsonConverter(typeof(StringToDoubleConverter)) ]
        public double? Usage { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("food_dish")]
        public FoodDish FoodDish { get; set; }

        [JsonPropertyName("food_dish_detail")]
        public FoodDishDetail FoodDishDetail { get; set; }

        [JsonPropertyName("ingredient")]
        public Ingredient Ingredient { get; set; }
    }
}
