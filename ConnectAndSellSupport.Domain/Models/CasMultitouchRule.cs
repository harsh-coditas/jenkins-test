using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMultitouchRule
    {
        public CasMultitouchRule()
        {
            CasMultitouchActions = new HashSet<CasMultitouchAction>();
            CasMultitouchContactEffects = new HashSet<CasMultitouchContactEffect>();
        }

        public int RuleId { get; set; }
        public int ListId { get; set; }
        public int StepCount { get; set; }
        public bool IsDayRule { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RuleStartDate { get; set; }

        public virtual CasList List { get; set; }
        public virtual ICollection<CasMultitouchAction> CasMultitouchActions { get; set; }
        public virtual ICollection<CasMultitouchContactEffect> CasMultitouchContactEffects { get; set; }
    }
}
