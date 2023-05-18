using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerGroupConditionMapping
    {
        public int TriggerGroupConditionMappingId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerParentGroupId { get; set; }
        public int? TriggerGroupId { get; set; }
        public int? TriggerConditionId { get; set; }
        public string MappingType { get; set; }

        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerCondition TriggerCondition { get; set; }
        public virtual CasTriggerGroup TriggerGroup { get; set; }
        public virtual CasTriggerGroup TriggerParentGroup { get; set; }
    }
}
