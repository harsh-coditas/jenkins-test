using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerGroup
    {
        public CasTriggerGroup()
        {
            CasTriggerGroupConditionMappingTriggerGroups = new HashSet<CasTriggerGroupConditionMapping>();
            CasTriggerGroupConditionMappingTriggerParentGroups = new HashSet<CasTriggerGroupConditionMapping>();
        }

        public int TriggerGroupId { get; set; }
        public int TriggerId { get; set; }
        public string GroupCondition { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Active { get; set; }

        public virtual CasTrigger Trigger { get; set; }
        public virtual ICollection<CasTriggerGroupConditionMapping> CasTriggerGroupConditionMappingTriggerGroups { get; set; }
        public virtual ICollection<CasTriggerGroupConditionMapping> CasTriggerGroupConditionMappingTriggerParentGroups { get; set; }
    }
}
