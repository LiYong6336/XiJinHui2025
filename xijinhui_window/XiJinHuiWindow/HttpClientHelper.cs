using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using XiJinHuiWindow.Models.Responses;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using XiJinHuiWindow.Models.Requests;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Net;

namespace XiJinHuiWindow
{
    public static class HttpClientHelper
    {
        private static readonly HttpClient _client = new HttpClient();
        private static string _baseUrl;
        private static string _token;

        public static string Token
        {
            get => _token;
            set
            {
                _token = value;
                if (!string.IsNullOrEmpty(_token))
                {
                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                }
                else
                {
                    _client.DefaultRequestHeaders.Authorization = null;
                }
            }
        }

        public static void Initialize(string baseUrl)
        {
            //_baseUrl = baseUrl;

            _baseUrl = baseUrl + (baseUrl.EndsWith("/") ? "api/" : "/api/");
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();

            //_client.BaseAddress = new Uri(_baseUrl);
            //_client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Response<T>> GetAsync<T>(string endpoint, Dictionary<string, string> queryParams = null)
        {
            // Build the URL with query parameters
            var builder = new UriBuilder(_baseUrl + endpoint);
            if (queryParams != null)
                builder.Query = new FormUrlEncodedContent(queryParams).ReadAsStringAsync().GetAwaiter().GetResult();
            string finalUrl = builder.ToString();
            HttpResponseMessage res = await _client.GetAsync(finalUrl);
            var responseData = await res.Content.ReadAsStringAsync();
            Debug.WriteLine("Enpoint: " + endpoint);
            Debug.WriteLine("Log response: ");
            Debug.WriteLine(responseData);
            if (res.IsSuccessStatusCode)
            {
                Response<T> resData = JsonSerializer.Deserialize<Response<T>>(responseData);
                return resData;
            }
            else if (IsUnauthorized(res))
            {
                Logout();
            }
            throw new Exception(responseData);
        }
        public static async Task<PaginationResponse<T>> GetPaginateAsync<T>(string endpoint, Dictionary<string, string> queryParams = null)
        {
            // Build the URL with query parameters
            var builder = new UriBuilder(_baseUrl + endpoint);
            if (queryParams != null)
                builder.Query = new FormUrlEncodedContent(queryParams).ReadAsStringAsync().GetAwaiter().GetResult();
            string finalUrl = builder.ToString();
            HttpResponseMessage res = await _client.GetAsync(finalUrl);
            var responseData = await res.Content.ReadAsStringAsync();
            Debug.WriteLine("Enpoint: " + endpoint);
            Debug.WriteLine("Log response: ");
            Debug.WriteLine(responseData);
            if (res.IsSuccessStatusCode)
            {
                PaginationResponse<T> resData = JsonSerializer.Deserialize<PaginationResponse<T>>(responseData);
                return resData;
            }
            else if (IsUnauthorized(res))
            {
                Logout();
            }
            throw new Exception(responseData);
        }

        public static async Task<Response<T>> PostAsync<T>(string endpoint, object data, List<FileField> fileFields = null)
        {
            Debug.WriteLine("Post Data: " + JsonSerializer.Serialize(data));

            using (MultipartFormDataContent content = new MultipartFormDataContent())
            {
                // Add the JSON data part
                string jsonData = JsonSerializer.Serialize(data);
                var dataDict = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData);
                foreach (var kvp in dataDict)
                {
                    //var v = kvp.Value?.ToString();
                    //var stringContent = new StringContent(v == "True" ? "1" : v == "False" ? "0" : v ?? string.Empty);
                    //content.Add(stringContent, kvp.Key);

                    if (kvp.Value is JsonElement jsonElement)
                    {
                        switch (jsonElement.ValueKind)
                        {
                            case JsonValueKind.String:
                                content.Add(new StringContent(jsonElement.GetString()), kvp.Key);
                                break;
                            case JsonValueKind.Number:
                                content.Add(new StringContent(jsonElement.GetRawText()), kvp.Key);
                                break;
                            case JsonValueKind.Array:
                                int index = 0;
                                foreach (var item in jsonElement.EnumerateArray())
                                {
                                    content.Add(new StringContent(item.GetRawText()), $"{kvp.Key}[{index}]");
                                    index++;
                                }
                                break;
                            case JsonValueKind.True:
                            case JsonValueKind.False:
                                content.Add(new StringContent(jsonElement.GetBoolean() ? "1" : "0"), kvp.Key);
                                break;
                            default:
                                content.Add(new StringContent(jsonElement.GetRawText()), kvp.Key);
                                break;
                        }
                    }
                    else
                    {
                        content.Add(new StringContent(kvp.Value?.ToString() ?? string.Empty), kvp.Key);
                    }


                }
                //StringContent jsonContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                //content.Add(jsonContent, "json");

                // Add each file part
                if (fileFields != null)
                {
                    foreach (var fileField in fileFields)
                    {
                        byte[] fileData = File.ReadAllBytes(fileField.FilePath);
                        ByteArrayContent fileContent = new ByteArrayContent(fileData);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                        content.Add(fileContent, fileField.FieldName, Path.GetFileName(fileField.FilePath));
                    }
                }

                // Send the POST request
                HttpResponseMessage res = await _client.PostAsync(endpoint, content);
                string responseData = await res.Content.ReadAsStringAsync();
                Debug.WriteLine("Post Response: " + responseData);

                if (res.IsSuccessStatusCode)
                {
                    Response<T> resData = JsonSerializer.Deserialize<Response<T>>(responseData);
                    return resData;
                }
                else if ((int)res.StatusCode == 422 || (IsUnauthorized(res) && endpoint.Contains("login")))
                {
                    var jsonDoc = JsonDocument.Parse(responseData);

                    // Extract the "message" property
                    if (jsonDoc.RootElement.TryGetProperty("message", out JsonElement messageElement))
                    {
                        string message = messageElement.GetString();
                        MessageBox.Show(message);
                    }
                }
                else if (IsUnauthorized(res))
                {
                    Logout();
                }

                throw new Exception(responseData);
            }
        }

        public static async Task<Response<T>> PutAsync<T>(string endpoint, object data, List<FileField> fileFields = null)
        {
            Debug.WriteLine(endpoint);
            Debug.WriteLine("Post Data: " + JsonSerializer.Serialize(data));
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            {
                content.Add(new StringContent("PUT"), "_method");
                // Add the JSON data part
                string jsonData = JsonSerializer.Serialize(data);
                var dataDict = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData);
                foreach (var kvp in dataDict)
                {
                    //var v = kvp.Value?.ToString();
                    //var stringContent = new StringContent(v == "True" ? "1" : v == "False" ? "0" : v ?? string.Empty);
                    //content.Add(stringContent, kvp.Key);

                    if (kvp.Value is JsonElement jsonElement)
                    {
                        switch (jsonElement.ValueKind)
                        {
                            case JsonValueKind.String:
                                content.Add(new StringContent(jsonElement.GetString()), kvp.Key);
                                break;
                            case JsonValueKind.Number:
                                content.Add(new StringContent(jsonElement.GetRawText()), kvp.Key);
                                break;
                            case JsonValueKind.Array:
                                int index = 0;
                                foreach (var item in jsonElement.EnumerateArray())
                                {
                                    content.Add(new StringContent(item.GetRawText()), $"{kvp.Key}[{index}]");
                                    index++;
                                }
                                break;
                            case JsonValueKind.True:
                            case JsonValueKind.False:
                                content.Add(new StringContent(jsonElement.GetBoolean() ? "1" : "0"), kvp.Key);
                                break;
                            default:
                                content.Add(new StringContent(jsonElement.GetRawText()), kvp.Key);
                                break;
                        }
                    }
                    else
                    {
                        content.Add(new StringContent(kvp.Value?.ToString() ?? string.Empty), kvp.Key);
                    }
                }
                //StringContent jsonContent = new StringContent(jsonData);
                ////jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //content.Add(jsonContent, "json");
                //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Add each file part
                if (fileFields != null)
                {
                    foreach (var fileField in fileFields)
                    {
                        byte[] fileData = File.ReadAllBytes(fileField.FilePath);
                        ByteArrayContent fileContent = new ByteArrayContent(fileData);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                        content.Add(fileContent, fileField.FieldName, Path.GetFileName(fileField.FilePath));
                    }
                }

                // Send the PUT request
                HttpResponseMessage res = await _client.PostAsync(endpoint, content);
                string responseData = await res.Content.ReadAsStringAsync();
                Debug.WriteLine(responseData);

                if (res.IsSuccessStatusCode)
                {
                    Response<T> resData = JsonSerializer.Deserialize<Response<T>>(responseData);
                    return resData;
                }
                else if (IsUnauthorized(res))
                {
                    Logout();
                }
                else if((int) res.StatusCode == 422)
                {
                    var jsonDoc = JsonDocument.Parse(responseData);

                    // Extract the "message" property
                    if (jsonDoc.RootElement.TryGetProperty("message", out JsonElement messageElement))
                    {
                        string message = messageElement.GetString();
                        MessageBox.Show(message);
                    }
                }

                throw new Exception(responseData);
            }
        }
        public static async Task<bool> DeleteAsync(string endpoint)
        {
            Debug.WriteLine("delete: " + endpoint);
            HttpResponseMessage res = await _client.DeleteAsync(endpoint);
            var responseData = await res.Content.ReadAsStringAsync();
            Debug.WriteLine(responseData);
            if (res.IsSuccessStatusCode)
            {
                return true;
            }
            else if (IsUnauthorized(res))
            {
                Logout();
            }
            throw new Exception(res.ToString());
        }
        public static bool IsUnauthorized(HttpResponseMessage res)
        {
            return res.StatusCode == System.Net.HttpStatusCode.Unauthorized;
        }

        public static void Logout()
        {
            Settings.Default.Token = null;
            Settings.Default.Menus = null;
            Settings.Default.User = null;
            Settings.Default.Save();
            Application.Restart();
        }
    }
}

