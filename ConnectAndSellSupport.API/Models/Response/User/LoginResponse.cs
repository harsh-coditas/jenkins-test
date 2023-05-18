using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.User
{
    public class LoginResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
