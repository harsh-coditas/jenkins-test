using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasSfOpportunityLatest
    {
        public int Id { get; set; }
        public string OpportunityCrmId { get; set; }
        public string OpportunityName { get; set; }
        public int CompanyId { get; set; }
        public string ObjectResponsible { get; set; }
        public string CrmId { get; set; }
        public string AccountCrmId { get; set; }
        public DateTime OpportunityCreatedate { get; set; }
        public DateTime? ConnectDate { get; set; }
        public DateTime? MeetingDate { get; set; }
        public bool? IsMeetingBooked { get; set; }
        public string UserName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string DispositionText { get; set; }
        public string AccountName { get; set; }
        public int DispositionType { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public DateTime? PositiveConnectDate { get; set; }
        public int ConnectCount { get; set; }
        public string Type { get; set; }
    }
}
