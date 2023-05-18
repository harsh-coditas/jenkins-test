using System;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.Data
{
    public class GetReplenishmentPayload : BasePayload
    {
        [JsonPropertyName("company_id")]
        public int CompanyId { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }        

        [JsonPropertyName("from_date")]
        public DateTime FromDate { get; set; }

        [JsonPropertyName("to_date")]
        public DateTime ToDate { get; set; }
    }
}
