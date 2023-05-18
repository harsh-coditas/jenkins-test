using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.User
{
    public class RefreshTokenPayload
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
