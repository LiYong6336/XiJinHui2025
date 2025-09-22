using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models
{
    public class User
    {

        public static Dictionary<string, string> Languages = new Dictionary<string, string>
        {
            { "en" ,"English" },
            { "zh" ,"Chinese" },
            { "kh" ,"Khmer" },
        };

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("is_admin")]
        public int? IsAdmin { get; set; }

        [JsonPropertyName("user_locale")]
        public string UserLocale { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("roles")]
        public List<Role> Roles { get; set; }

        [JsonPropertyName("role_id")]
        public int? RoleId { get; set; }
    }
}
