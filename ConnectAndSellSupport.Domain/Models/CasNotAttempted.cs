using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasNotAttempted
    {
        public string LeadId { get; set; }
        public string LightningListStatus { get; set; }
        public DateTime LastAttemptedDateAttemptsHistory { get; set; }
        public DateTime LastAttemptedDateSfdc { get; set; }
        public string CampaignListName { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string DirectPhone { get; set; }
        public string Email { get; set; }
        public int? ContactId { get; set; }
        public int? ListId { get; set; }
        public DateTime? LastAttemptDateCas { get; set; }
        public int? AttemptCount { get; set; }
        public string Status { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? LastInvalidDate { get; set; }
        public string ContactStatus { get; set; }
    }
}
