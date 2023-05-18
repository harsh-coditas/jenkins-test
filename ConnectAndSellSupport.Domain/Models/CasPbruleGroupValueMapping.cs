using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbruleGroupValueMapping
    {
        public int PbruleGroupValueMappingId { get; set; }
        public int? RuleId { get; set; }
        public int? RuleParentGroupId { get; set; }
        public int? RuleGroupId { get; set; }
        public int? RuleValueId { get; set; }
        public string MappingType { get; set; }

        public virtual CasPbrule Rule { get; set; }
        public virtual CasPbruleGroup RuleGroup { get; set; }
        public virtual CasPbruleGroup RuleParentGroup { get; set; }
        public virtual CasPbruleValue RuleValue { get; set; }
    }
}
