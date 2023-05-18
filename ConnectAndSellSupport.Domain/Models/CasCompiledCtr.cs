using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCompiledCtr
    {
        public int CompiledCtrid { get; set; }
        public string ProductType { get; set; }
        public string ClientName { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? TotalHoursForDisposition { get; set; }
        public string CampaignName { get; set; }
        public string PitcherName { get; set; }
        public string SyatemAccountName { get; set; }
        public string ListName { get; set; }
        public int? LeadId { get; set; }
        public DateTime? ConnectTime { get; set; }
        public string Active { get; set; }
        public string ContactCompanyName { get; set; }
        public string ContactName { get; set; }
        public string JobTitle { get; set; }
        public string Phone1 { get; set; }
        public string ContactAddress { get; set; }
        public string ContactCity { get; set; }
        public string Stat { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Crmid { get; set; }
        public string DispositionText { get; set; }
        public string DispositionType { get; set; }
        public int? MeetingCount { get; set; }
        public int? NextSteps { get; set; }
        public string Problems { get; set; }
        public string Notes { get; set; }
    }
}
