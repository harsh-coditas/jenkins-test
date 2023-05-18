using System;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.PenaltyBox
{
    public class CasPenaltyBoxResponse
    {

        [JsonPropertyName("AuditId")]
        public int AuditId { get; set; }
        [JsonPropertyName("ClientId")]
        public int ClientId { get; set; }
        [JsonPropertyName("ClientName")]
        public string ClientName { get; set; }
        [JsonPropertyName("CampaignUserId")]
        public int CampaignUserId { get; set; }
        [JsonPropertyName("CampaignName")]
        public string CampaignName { get; set; }
        [JsonPropertyName("ListId")]
        public int ListId { get; set; }
        [JsonPropertyName("Listname")]
        public string Listname { get; set; }
        [JsonPropertyName("ContactId")]
        public int ContactId { get; set; }
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("CrmId")]
        public string CrmId { get; set; }
        [JsonPropertyName("Phone1")]
        public string Phone1 { get; set; }
        [JsonPropertyName("Phone2")]
        public string Phone2 { get; set; }
        [JsonPropertyName("Pbphone")]
        public string Pbphone { get; set; }
        [JsonPropertyName("SessionId")]
        public int SessionId { get; set; }
        [JsonPropertyName("Pbdisposition")]
        public string Pbdisposition { get; set; }
        [JsonPropertyName("AgentDisposition")]
        public string AgentDisposition { get; set; }
        [JsonPropertyName("ClientFacingDisposition")]
        public string ClientFacingDisposition { get; set; }
        [JsonPropertyName("Crmobject")]
        public string Crmobject { get; set; }
        [JsonPropertyName("Status")]
        public string Status { get; set; }
        [JsonPropertyName("CreatedDate")]
        public DateTime? CreatedDate { get; set; }
        [JsonPropertyName("RemovalDate")]
        public DateTime? RemovalDate { get; set; }
        [JsonPropertyName("RecordStatus")]
        public bool? RecordStatus { get; set; }
        [JsonPropertyName("Phone3")]
        public string Phone3 { get; set; }
        [JsonPropertyName("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [JsonPropertyName("StatusPhone1")]
        public string StatusPhone1 { get; set; }
        [JsonPropertyName("StatusPhone2")]
        public string StatusPhone2 { get; set; }
        [JsonPropertyName("StatusPhone3")]
        public string StatusPhone3 { get; set; }
        [JsonPropertyName("ReasonMessage")]
        public string ReasonMessage { get; set; }
    }
}
