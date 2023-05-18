using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbruleGroup
    {
        public CasPbruleGroup()
        {
            CasPbruleGroupValueMappingRuleGroups = new HashSet<CasPbruleGroupValueMapping>();
            CasPbruleGroupValueMappingRuleParentGroups = new HashSet<CasPbruleGroupValueMapping>();
        }

        public int PbruleGroupId { get; set; }
        public int? RuleId { get; set; }
        public string GroupCondition { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string CreateUser { get; set; }
        public string ModUser { get; set; }

        public virtual CasPbrule Rule { get; set; }
        public virtual ICollection<CasPbruleGroupValueMapping> CasPbruleGroupValueMappingRuleGroups { get; set; }
        public virtual ICollection<CasPbruleGroupValueMapping> CasPbruleGroupValueMappingRuleParentGroups { get; set; }
    }
}
