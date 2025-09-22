using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XiJinHuiWindow
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
        {
            var content = JsonContent.Create(value);
            return client.PutAsync(requestUri, content);
        }

        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
        {
            var content = JsonContent.Create(value);
            return client.PostAsync(requestUri, content);
        }
    }
}
