using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerCondition
    {
        public CasTriggerCondition()
        {
            CasTriggerGroupConditionMappings = new HashSet<CasTriggerGroupConditionMapping>();
        }

        public int TriggerConditionId { get; set; }
        public int TriggerId { get; set; }
        public string TriggerConditionVariable { get; set; }
        public string ConditionEvaluationType { get; set; }
        public string ComparisonValue { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string ObjectType { get; set; }

        public virtual CasTrigger Trigger { get; set; }
        public virtual ICollection<CasTriggerGroupConditionMapping> CasTriggerGroupConditionMappings { get; set; }
    }
}
