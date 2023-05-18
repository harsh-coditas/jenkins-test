using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TCampaign
    {
        public TCampaign()
        {
            TDispositions = new HashSet<TDisposition>();
            TNames = new HashSet<TName>();
        }

        public int Id { get; set; }
        public string Identifier { get; set; }
        public string CompanyName { get; set; }
        public string CampaignName { get; set; }
        public string UserIdentifier { get; set; }
        public string ScriptName { get; set; }
        public string SessionName { get; set; }
        public bool KeepingScore { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int Status { get; set; }
        public int CompanyId { get; set; }
        public bool? Recording { get; set; }
        public bool? DialerSession { get; set; }
        public int? SessionId { get; set; }
        public int SessionType { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ScheduledEnd { get; set; }
        public int PitcherId { get; set; }
        public string PitcherIdentifier { get; set; }
        public int LanguageRequirements { get; set; }
        public int LocationRequirements { get; set; }
        public string SpecialInstructions { get; set; }
        public bool LockAgentsOnConnect { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<TDisposition> TDispositions { get; set; }
        public virtual ICollection<TName> TNames { get; set; }
    }
}
