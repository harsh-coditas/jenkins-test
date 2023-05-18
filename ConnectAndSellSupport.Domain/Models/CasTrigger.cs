using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTrigger
    {
        public CasTrigger()
        {
            CasTriggerActions = new HashSet<CasTriggerAction>();
            CasTriggerConditions = new HashSet<CasTriggerCondition>();
            CasTriggerContactEffects = new HashSet<CasTriggerContactEffect>();
            CasTriggerGroupConditionMappings = new HashSet<CasTriggerGroupConditionMapping>();
            CasTriggerGroups = new HashSet<CasTriggerGroup>();
            CasTriggerProspectRemovedFromLists = new HashSet<CasTriggerProspectRemovedFromList>();
            CasTriggerTaskConfigs = new HashSet<CasTriggerTaskConfig>();
            CasTriggerVoicemails = new HashSet<CasTriggerVoicemail>();
            TTriggerLogs = new HashSet<TTriggerLog>();
        }

        public int TriggerId { get; set; }
        public string TriggerName { get; set; }
        public int CompanyId { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<CasTriggerAction> CasTriggerActions { get; set; }
        public virtual ICollection<CasTriggerCondition> CasTriggerConditions { get; set; }
        public virtual ICollection<CasTriggerContactEffect> CasTriggerContactEffects { get; set; }
        public virtual ICollection<CasTriggerGroupConditionMapping> CasTriggerGroupConditionMappings { get; set; }
        public virtual ICollection<CasTriggerGroup> CasTriggerGroups { get; set; }
        public virtual ICollection<CasTriggerProspectRemovedFromList> CasTriggerProspectRemovedFromLists { get; set; }
        public virtual ICollection<CasTriggerTaskConfig> CasTriggerTaskConfigs { get; set; }
        public virtual ICollection<CasTriggerVoicemail> CasTriggerVoicemails { get; set; }
        public virtual ICollection<TTriggerLog> TTriggerLogs { get; set; }
    }
}
