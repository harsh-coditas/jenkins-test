using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerProspectRemovedFromList
    {
        public int TriggerProspectRemovedFromListId { get; set; }
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerActionId { get; set; }
        public bool Active { get; set; }
        public DateTime TriggerExecutionDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual CasContact Contact { get; set; }
        public virtual CasList List { get; set; }
        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerAction TriggerAction { get; set; }
    }
}
