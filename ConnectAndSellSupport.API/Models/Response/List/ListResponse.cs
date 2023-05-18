using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.List
{
    public class ListResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
