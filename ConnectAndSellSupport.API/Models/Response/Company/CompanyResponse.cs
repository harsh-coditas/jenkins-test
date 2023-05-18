using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.Company
{
    public class CompanyResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string CompanyName { get; set; }
    }
}
