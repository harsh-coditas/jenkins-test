using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class HubspotObjectRecord
    {
        public int RecordId { get; set; }
        public string CrmownerId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? DueDate { get; set; }
        public string Comments { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string TimeZone { get; set; }
        public string Email { get; set; }
        public string CrmUrl { get; set; }
        public short? Priority { get; set; }
        public string Status { get; set; }
        public string CrmId { get; set; }
        public string CrmId2 { get; set; }
        public string CrmId3 { get; set; }
        public string Custom { get; set; }
        public string CrmObject { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string Country { get; set; }
        public bool? Active { get; set; }
        public string LeadSource { get; set; }
        public string State { get; set; }
        public string ContactCountry { get; set; }
        public string CompanyUrl { get; set; }
        public string ReferralCustom { get; set; }
        public string ContactNotes { get; set; }
        public string CrmtimeZone { get; set; }
        public string LinkedInUrl { get; set; }
    }
}
