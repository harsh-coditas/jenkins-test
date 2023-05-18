using System;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.Call
{
    public class AgentCallRecordResponse
    {
        [JsonPropertyName("lead_transit_id")]
        public int? LeadTransitId { get; set; }

        [JsonPropertyName("client_name")]
        public string ClientName { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        [JsonPropertyName("contact_first_name")]
        public string ContactFirstName { get; set; }

        [JsonPropertyName("contact_last_name")]
        public string ContactLastName { get; set; }

        [JsonPropertyName("contact_job_title")]
        public string ContactJobTitle { get; set; }

        [JsonPropertyName("contact_tel1")]
        public string ContactTel1 { get; set; }

        [JsonPropertyName("contact_tel2")]
        public string ContactTel2 { get; set; }

        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        [JsonPropertyName("created_date")]
        public DateTime CreatedDate { get; set; }
    }
}
