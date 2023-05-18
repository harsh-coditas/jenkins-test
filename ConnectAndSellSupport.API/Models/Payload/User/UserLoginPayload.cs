using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.User
{
    public class UserLoginPayload : BasePayload
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
