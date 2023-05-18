using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMultitouchAction
    {
        public CasMultitouchAction()
        {
            CasMultitouchContactEffects = new HashSet<CasMultitouchContactEffect>();
        }

        public int ActionId { get; set; }
        public int RuleId { get; set; }
        public int ActionType { get; set; }
        public string Data { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? UserId { get; set; }

        public virtual CasMultitouchRule Rule { get; set; }
        public virtual ICollection<CasMultitouchContactEffect> CasMultitouchContactEffects { get; set; }
    }
}
