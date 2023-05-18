using ConnectAndSellSupport.Domain.Models.Custom.Company;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.Company
{
    public class CompanyDispositionResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public DispositionType Type { get; set; }

        [JsonPropertyName("mode")]
        public DispositionMode Mode { get; set; }

        [JsonPropertyName("sort_order")]
        public int SortOrder { get; set; }
    }
}
