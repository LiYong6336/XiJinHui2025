using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SettingMenu : HasNameLanguages
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("icons_path")]
        public string IconsPath { get; set; }

        [JsonPropertyName("route_path")]
        public string RoutePath { get; set; }

        [JsonPropertyName("sort")]
        public int? Sort { get; set; }

        [JsonPropertyName("type")]
        public int? Type { get; set; }

        [JsonPropertyName("is_system")]
        public int? IsSystem { get; set; }

        [JsonPropertyName("component")]
        public string Component { get; set; }

        [JsonPropertyName("_lft")]
        public int? Lft { get; set; }

        [JsonPropertyName("_rgt")]
        public int? Rgt { get; set; }

        [JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("children")]
        public List<SettingMenu> Children { get; set; } = new List<SettingMenu>();
    }

}
