using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
        public class DiningFloor: HasNameLanguages
        {
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            [JsonPropertyName("floor_code")]
            public string FloorCode { get; set; }

            [JsonPropertyName("remark")]
            public string Remark { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("created_at")]
            public string CreatedAt { get; set; }

            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }


    }
}
