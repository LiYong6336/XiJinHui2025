using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using XiJinHuiWindow.Utils;

namespace XiJinHuiWindow.Models
{
    public class DiningTable
    {
        public static Dictionary<int, string> FlagStatuses = new Dictionary<int, string>
        {
            //状态 1:空闲 2:使用中 3:预定 4:清洁 5:维修
            //1: Idle 2: In use 3: Reserved 4: Cleaning 5: Repair
             { 1, "Idle"},
             { 2, "InUse"},
             { 3, "Reserved"},
             { 4, "Cleaning"},
             { 5, "Repair"},
        };
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            [JsonPropertyName("dining_table_code")]
            public string DiningTableCode { get; set; }
        
            public string DiningFloorName { get; set; }

            [JsonPropertyName("english_name")]
            public string EnglishName { get; set; }

            [JsonPropertyName("chinese_name")]
            public string ChineseName { get; set; }

            [JsonPropertyName("khmer_name")]
            public string KhmerName { get; set; }

            [JsonPropertyName("remark")]
            public string Remark { get; set; }

            [JsonPropertyName("person_count")]
            public int? PersonCount { get; set; }

            [JsonPropertyName("tax_percentage"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? TaxPercentage { get; set; }

            [JsonPropertyName("tax_fixPrice"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? TaxFixPrice { get; set; }

            [JsonPropertyName("room_service_percentage"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? RoomServicePercentage { get; set; }

            [JsonPropertyName("room_service_fixPrice"), JsonConverter(typeof(StringToDoubleConverter))]
            public double? RoomServiceFixPrice { get; set; }

            [JsonPropertyName("is_broken")]
            public bool? IsBroken { get; set; }

            [JsonPropertyName("is_enable")]
            public bool? IsEnable { get; set; }

            [JsonPropertyName("flag_status")]
            public int? FlagStatus { get; set; }

            [JsonPropertyName("created_at")]
            public string CreatedAt { get; set; }

            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }

            [JsonPropertyName("dining_floor_id")]
            public int? DiningFloorId { get; set; }

            [JsonPropertyName("dining_floor")]
            public DiningFloor DiningFloor { get; set; }

    }
}
