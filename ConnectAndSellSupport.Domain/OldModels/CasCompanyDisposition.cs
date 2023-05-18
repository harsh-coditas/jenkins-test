#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCompanyDisposition
    {
        public int CompanyDispositionId { get; set; }
        public int CompanyId { get; set; }
        public string DispositionText { get; set; }
        public string DispositionType { get; set; }
        public bool Active { get; set; }
        public byte DispositionMode { get; set; }
        public bool IsConversation { get; set; }
        public bool CountAsConversion { get; set; }
        public bool IsFollowUpMandatory { get; set; }
        public string LeadStatus { get; set; }
        public string ContactStatus { get; set; }
        public string Csvstatus { get; set; }
        public int? SortOrder { get; set; }
        public string LeadSubStatus { get; set; }
        public string ContactSubStatus { get; set; }
        public bool IsReferral { get; set; }
        public bool KeepInSalesloft { get; set; }
        public string SecondaryDispositionId { get; set; }
        public string SecondaryQuickListId { get; set; }
        public bool IsFollowupQuickListEnabled { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
