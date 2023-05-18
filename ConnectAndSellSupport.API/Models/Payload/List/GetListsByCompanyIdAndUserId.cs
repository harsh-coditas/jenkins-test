using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.List
{
    public class GetListsByCompanyIdAndUserId : BasePayload
    {
        [JsonPropertyName("user_ids")]
        public HashSet<int> UserIds { get; set; }
    }
}
