using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class Category: HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("category_photo")]
        public string CategoryPhoto { get; set; }

        [JsonPropertyName("printer_id")]
        public int? PrinterId { get; set; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("printer")]
        public Printer Printer { get; set; }

        [JsonPropertyName("is_animal_part")]
        public bool IsAnimalPart { get; set; }

        [JsonPropertyName("is_drink")]
        public bool IsDrink { get; set; }
    }

}
