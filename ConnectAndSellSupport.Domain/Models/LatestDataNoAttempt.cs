using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class LatestDataNoAttempt
    {
        public string LeadId { get; set; }
        public string LightningListStatus { get; set; }
        public DateTime? LastAttemptedDateCas { get; set; }
        public DateTime? LastAttemptedDateSfdc { get; set; }
        public string CampaignListName { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string DirectPhone { get; set; }
        public string Email { get; set; }
        public int? ListId { get; set; }
        public int? ContactId { get; set; }
        public DateTime? LastAttemptDate { get; set; }
    }
}
