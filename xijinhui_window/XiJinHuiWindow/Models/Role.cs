using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class Role
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("guard_name")]
        public string GuardName { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("setting_menus")]
        public List<SettingMenu> SettingMenus { get; set; }

        public string MenusText { get; set; }

        [JsonPropertyName("menu_ids")]
        public List<int> MenuIds { get; set; }
    }
}
