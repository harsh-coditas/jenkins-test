using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.PenaltyBox
{
    public class RemovePenaltyBoxEntity : BasePayload
    {



        [JsonPropertyName("company_id")]
        public int CompanyId { get; set; }

        [JsonPropertyName("from_date")]
        public DateTime FromDate { get; set; }


        [JsonPropertyName("list_ids")]
        public int?[] ListIds { get; set; }

        [JsonPropertyName("entity_type")]
        public string StatusType { get; set; }

        [JsonPropertyName("to_date")]
        public DateTime ToDate { get; set; }
        [JsonPropertyName("user_ids")]
        public int?[] UserIds { get; set; }
    }
}
