using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerContactEffect
    {
        public int TriggerContactEffectsId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerActionId { get; set; }
        public int ContactId { get; set; }
        public DateTime? ActionDate { get; set; }

        public virtual CasContact Contact { get; set; }
        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerAction TriggerAction { get; set; }
    }
}
