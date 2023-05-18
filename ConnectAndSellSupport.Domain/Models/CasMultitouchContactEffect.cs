using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMultitouchContactEffect
    {
        public int MultitouchEffectId { get; set; }
        public int RuleId { get; set; }
        public int ContactId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionId { get; set; }

        public virtual CasMultitouchAction Action { get; set; }
        public virtual CasMultitouchRule Rule { get; set; }
    }
}
