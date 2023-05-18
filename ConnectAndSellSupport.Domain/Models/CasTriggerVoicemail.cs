using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerVoicemail
    {
        public int TriggerVoicemailId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerActionId { get; set; }
        public string VoicemailName { get; set; }
        public int ListId { get; set; }
        public int UserId { get; set; }

        public virtual CasList List { get; set; }
        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerAction TriggerAction { get; set; }
        public virtual TUser User { get; set; }
    }
}
