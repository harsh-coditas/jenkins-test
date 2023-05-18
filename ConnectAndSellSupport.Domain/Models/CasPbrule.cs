using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbrule
    {
        public CasPbrule()
        {
            CasPbruleActions = new HashSet<CasPbruleAction>();
            CasPbruleGroupValueMappings = new HashSet<CasPbruleGroupValueMapping>();
            CasPbruleGroups = new HashSet<CasPbruleGroup>();
            CasPbruleValues = new HashSet<CasPbruleValue>();
        }

        public int PbruleId { get; set; }
        public string RuleName { get; set; }
        public int? CompanyId { get; set; }
        public bool? IsActive { get; set; }
        public bool? RuleStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string CreateUser { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<CasPbruleAction> CasPbruleActions { get; set; }
        public virtual ICollection<CasPbruleGroupValueMapping> CasPbruleGroupValueMappings { get; set; }
        public virtual ICollection<CasPbruleGroup> CasPbruleGroups { get; set; }
        public virtual ICollection<CasPbruleValue> CasPbruleValues { get; set; }
    }
}
