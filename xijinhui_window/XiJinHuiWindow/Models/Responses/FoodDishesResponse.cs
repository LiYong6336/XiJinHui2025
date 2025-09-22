using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models.Responses
{
    public class FoodDishesResponse
    {
        [JsonPropertyName("food_dish")]
        public List<FoodDish> FoodDishes { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

    }
}
