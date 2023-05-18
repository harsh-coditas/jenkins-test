using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerAction
    {
        public CasTriggerAction()
        {
            CasTriggerContactEffects = new HashSet<CasTriggerContactEffect>();
            CasTriggerProspectRemovedFromLists = new HashSet<CasTriggerProspectRemovedFromList>();
            CasTriggerTaskConfigs = new HashSet<CasTriggerTaskConfig>();
            CasTriggerVoicemails = new HashSet<CasTriggerVoicemail>();
            TTriggerLogs = new HashSet<TTriggerLog>();
        }

        public int TriggerActionId { get; set; }
        public int TriggerId { get; set; }
        public string ActionKey { get; set; }
        public string ActionValue { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string FieldValue { get; set; }
        public string FieldName { get; set; }

        public virtual CasTrigger Trigger { get; set; }
        public virtual ICollection<CasTriggerContactEffect> CasTriggerContactEffects { get; set; }
        public virtual ICollection<CasTriggerProspectRemovedFromList> CasTriggerProspectRemovedFromLists { get; set; }
        public virtual ICollection<CasTriggerTaskConfig> CasTriggerTaskConfigs { get; set; }
        public virtual ICollection<CasTriggerVoicemail> CasTriggerVoicemails { get; set; }
        public virtual ICollection<TTriggerLog> TTriggerLogs { get; set; }
    }
}
