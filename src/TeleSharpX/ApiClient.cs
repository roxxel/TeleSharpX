using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TeleSharpX
{
    internal class ApiClient
    {
        private readonly string _token;
        private readonly HttpClient _client;
        public string _endpoint => $"https://api.telegram.org/bot{_token}/";
        
        public ApiClient(string token)
        {
            _token = token;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<ApiResponse<T>> Send<T>(string methodName, HttpMethod method, object body)
        {
            var message = new HttpRequestMessage();
            message.RequestUri = new Uri($"{_endpoint}{methodName}");
            message.Method = method;
            var bodyStr = JsonConvert.SerializeObject(body, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            if (method != HttpMethod.Get) 
                message.Content = new StringContent(
                    bodyStr, 
                    Encoding.UTF8, 
                    "application/json");
            var response = await _client.SendAsync(message);
            var respText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(respText);
        }
    }
}