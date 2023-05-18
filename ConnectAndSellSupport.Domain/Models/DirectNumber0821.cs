using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class DirectNumber0821
    {
        public DateTime? AttemptDate { get; set; }
        public string User { get; set; }
        public string TeamName { get; set; }
        public string ListName { get; set; }
        public string Category { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public double? Phone2 { get; set; }
        public string CrmId { get; set; }
        public string Disposition { get; set; }
        public string CrmUrl { get; set; }
        public double? LeadTransitId { get; set; }
        public string TimeZone { get; set; }
        public double? ActualAttemptedNumber { get; set; }
        public string OriginListName { get; set; }
        public string Phone2New { get; set; }
        public bool? IsDirect { get; set; }
    }
}
