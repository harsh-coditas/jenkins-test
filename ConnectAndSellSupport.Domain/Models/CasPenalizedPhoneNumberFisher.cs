using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPenalizedPhoneNumberFisher
    {
        public int RecordId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ContactId { get; set; }
        public int CampaignUserId { get; set; }
        public string CampaignName { get; set; }
        public int ListId { get; set; }
        public string Listname { get; set; }
        public int? SessionId { get; set; }
        public int? LeadTransitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public int? PhoneIndex { get; set; }
        public bool? BadNumber { get; set; }
        public bool? MalformedNumber { get; set; }
        public int? WrongNumber { get; set; }
        public bool? Dnc { get; set; }
        public int DispositionId { get; set; }
        public string AgentDisposition { get; set; }
        public string Disposition { get; set; }
        public DateTime? LastPenalizedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Country { get; set; }
        public string ContactCountry { get; set; }
        public DateTime? Dncexpires { get; set; }
        public int? Dnctype { get; set; }
        public string Pitcher { get; set; }
        public string Agent { get; set; }
        public string ReasonMessage { get; set; }
    }
}
