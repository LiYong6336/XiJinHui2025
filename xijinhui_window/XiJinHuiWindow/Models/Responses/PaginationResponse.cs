using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XiJinHuiWindow.Models.Responses
{
    public class Link
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }

    public class PaginationResponse<T>
    {
        [JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonPropertyName("from")]
        public int? From { get; set; }

        [JsonPropertyName("last_page")]
        public int? LastPage { get; set; }

        [JsonPropertyName("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }

        [JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("per_page")]
        public int? PerPage { get; set; }

        [JsonPropertyName("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonPropertyName("to")]
        public int? To { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }

}
