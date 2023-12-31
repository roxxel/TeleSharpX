using System;
using System.Collections;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeleSharpX.Types;
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

        public bool IsPropertyACollection(PropertyInfo property)
        {
            return (!typeof(String).Equals(property.PropertyType) && 
                    typeof(IEnumerable).IsAssignableFrom(property.PropertyType));
        }
        
        public async Task<ApiResponse<T>> Send<T>(string methodName, HttpMethod method, object body)
        {
            var message = new HttpRequestMessage();
            message.RequestUri = new Uri($"{_endpoint}{methodName}");
            message.Method = method;
            if (method != HttpMethod.Get)
            {
                var containsFiles = body.GetType().GetProperties().Any(x => x.PropertyType == typeof(InputFile));
                if (containsFiles)
                {
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    var fields = body.GetType().GetProperties();
                    foreach (var field in fields)
                    {
                        var name = field.Name;
                        if (field.GetValue(body) == null) continue;
                        if (field.PropertyType == typeof(InputFile))
                        {
                            var value = field.GetValue(body) as InputFile;
                            if (value.Type == InputFileType.Id)
                            {
                                form.Add(new StringContent(value._id), name);
                            }
                            else if (value.Type == InputFileType.File)
                            {
                                form.Add(new ByteArrayContent(value._file, 0, value._file.Length), name, value._name);
                            }
                        }
                        else
                        {
                            if (IsPropertyACollection(field))
                            {
                                var js = JsonConvert.SerializeObject(field.GetValue(body), Formatting.None, new JsonSerializerSettings()
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                                form.Add(new StringContent(js), name);
                            }
                            else
                            {
                                form.Add(new StringContent(field.GetValue(body).ToString()), name);
                            }
                        }
                    }

                    message.Content = form;
                }
                else
                {
                    var json = JsonConvert.SerializeObject(body, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    message.Content = new StringContent(json, Encoding.UTF8,
                        "application/json");
                    
                }
            }

            var response = await _client.SendAsync(message);
            var respText = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ApiResponse<T>>(respText);
            if (resp.Ok)
                return resp;
            throw new ApiException(resp.Description, resp.ErrorCode);
        }
    }
}