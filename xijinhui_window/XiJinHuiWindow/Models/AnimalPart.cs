using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XiJinHuiWindow.Models
{
    public class AnimalPart : HasNameLanguages
    {
        public static readonly Dictionary<string, string> TypeNames = new Dictionary<string, string>{
            { "h" , "Head" },
            { "w" , "Whole" },
            { "t" , "Tail" },
            { "m" , "Mix" },
            };
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("food_dish_id")]
        public int? FoodDishId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        public string TypeName
        {
            get
            {
                return TypeNames[Type];
            }
        }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
    }


}
