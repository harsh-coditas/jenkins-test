using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerTaskConfig
    {
        public int TriggerTaskConfigId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerActionId { get; set; }
        public string TaskType { get; set; }
        public string TaskSubject { get; set; }
        public string TaskComments { get; set; }
        public int? DueDate { get; set; }
        public string TaskStatus { get; set; }
        public bool? Active { get; set; }

        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerAction TriggerAction { get; set; }
    }
}
