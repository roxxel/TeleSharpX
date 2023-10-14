using System.Text.Json.Serialization;

namespace TeleSharpX
{
    public class ApiResponse<T>
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
        [JsonPropertyName("result")]
        public T Result { get; set; }
        [JsonPropertyName("error_code")]
        public int ErrorCode { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}