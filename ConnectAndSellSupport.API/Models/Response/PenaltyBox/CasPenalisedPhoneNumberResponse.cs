using System;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.PenaltyBox
{
    public class CasPenalisedPhoneNumberResponse
    {
        [JsonPropertyName("RecordId")]
        public int RecordId { get; set; }
        [JsonPropertyName("ClientId")]
        public int ClientId { get; set; }
        [JsonPropertyName("ClientName")]
        public string ClientName { get; set; }
        [JsonPropertyName("ContactId")]
        public int ContactId { get; set; }
        [JsonPropertyName("CampaignUserId")]
        public int CampaignUserId { get; set; }
        [JsonPropertyName("CampaignName")]
        public string CampaignName { get; set; }
        [JsonPropertyName("ListId")]
        public int ListId { get; set; }
        [JsonPropertyName("Listname")]
        public string Listname { get; set; }
        [JsonPropertyName("SessionId")]
        public int? SessionId { get; set; }
        [JsonPropertyName("LeadTransitId")]
        public int? LeadTransitId { get; set; }
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("PhoneIndex")]
        public int? PhoneIndex { get; set; }
        [JsonPropertyName("BadNumber")]
        public bool? BadNumber { get; set; }
        [JsonPropertyName("MalformedNumber")]
        public bool? MalformedNumber { get; set; }
        [JsonPropertyName("WrongNumber")]
        public int? WrongNumber { get; set; }
        [JsonPropertyName("Dnc")]
        public bool? Dnc { get; set; }
        [JsonPropertyName("DispositionId")]
        public int DispositionId { get; set; }
        [JsonPropertyName("AgentDisposition")]
        public string AgentDisposition { get; set; }
        [JsonPropertyName("Disposition")]
        public string Disposition { get; set; }
        [JsonPropertyName("LastPenalizedDate")]
        public DateTime? LastPenalizedDate { get; set; }
        [JsonPropertyName("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [JsonPropertyName("DeletedDate")]
        public DateTime? DeletedDate { get; set; }
        [JsonPropertyName("Country")]
        public string Country { get; set; }
        [JsonPropertyName("ContactCountry")]
        public string ContactCountry { get; set; }
        [JsonPropertyName("Dncexpires")]
        public DateTime? Dncexpires { get; set; }
        [JsonPropertyName("Dnctype")]
        public int? Dnctype { get; set; }
        [JsonPropertyName("Pitcher")]
        public string Pitcher { get; set; }
        [JsonPropertyName("Agent")]
        public string Agent { get; set; }
        [JsonPropertyName("ReasonMessage")]
        public string ReasonMessage { get; set; }
        [JsonPropertyName("CrmId")]
        public string CrmId { get; set; }
    }
}
