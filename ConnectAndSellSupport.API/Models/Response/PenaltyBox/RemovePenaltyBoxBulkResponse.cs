using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.PenaltyBox
{
    public class RemovePenaltyBoxBulkResponse
    {
        [JsonPropertyName("entities")]
        public Dictionary<PenaltyBoxEntityType, RemovePenaltyBoxResponse> Entities { get; set; }
    }
}
