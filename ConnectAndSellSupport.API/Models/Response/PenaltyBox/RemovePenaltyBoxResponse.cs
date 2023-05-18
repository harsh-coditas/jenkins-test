using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.PenaltyBox
{
    public class RemovePenaltyBoxResponse
    {
        [JsonPropertyName("updated_count")]
        public int UpdatedCount { get; set; }

        [JsonPropertyName("numbers_not_found")]
        public IEnumerable<string> NumbersNotFound { get; set; }
    }
}
