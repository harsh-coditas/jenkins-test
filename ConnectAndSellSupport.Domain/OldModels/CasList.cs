using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasList
    {
        public CasList()
        {
            CasListContacts = new HashSet<CasListContact>();
        }

        public int ListId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public byte Type { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte AssignmentType { get; set; }
        public int? ListTypeId { get; set; }
        public bool EnrichmentActive { get; set; }
        public string SettingMetaData { get; set; }
        public string CallStarterText { get; set; }
        public bool IsFollowUpList { get; set; }
        public bool? IsSmartList { get; set; }
        public bool? IsLeadInjectAllowed { get; set; }
        public int MaxAttempts { get; set; }
        public int Delay { get; set; }
        public int? DialingMode { get; set; }
        public string SfReportPath { get; set; }
        public int? BadDataCount { get; set; }
        public int? CompanyId { get; set; }
        public bool? IsOodlist { get; set; }
        public int MaxAttemptsList { get; set; }
        public bool IsConnectOnHello { get; set; }
        public int LeadPoolCheckoutSize { get; set; }
        public int? LeadPoolSize { get; set; }
        public bool? IsDialingModeRecommended { get; set; }
        public string ListCampaignId { get; set; }
        public int? MlPredictionAccuracy { get; set; }
        public decimal? DialToConnectRatio { get; set; }
        public int? TotalPredictedAttempts { get; set; }
        public bool? DoNotUpdateLeadOwner { get; set; }
        public bool? IsDeleted { get; set; }
        public string DefaultCallerId { get; set; }
        public bool AutoRefreshEnabled { get; set; }

        public virtual TUser User { get; set; }
        public virtual ICollection<CasListContact> CasListContacts { get; set; }
    }
}
