using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.PenaltyBox
{
    public class RemovePenaltyBoxEntityPayload : BasePayload
    {
        [JsonPropertyName("entity_type")]
        public PenaltyBoxEntityType Type { get; set; }

        [JsonPropertyName("company_id")]
        public int CompanyId { get; set; }

        [JsonPropertyName("user_ids")]
        public HashSet<int> UserIds { get; set; }

        [JsonPropertyName("list_ids")]
        public HashSet<int> ListIds { get; set; }

        [JsonPropertyName("from_date")]
        public DateTime FromDate { get; set; }

        [JsonPropertyName("to_date")]
        public DateTime ToDate { get; set; }
    }
}
