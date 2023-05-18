using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response
{
    public class Response
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public object Data { get; set; }

        public Response(string version, int statusCode, string message, object data)
        {
            Version = version;
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }
    }
}
