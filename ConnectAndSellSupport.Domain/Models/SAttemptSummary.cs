using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SAttemptSummary
    {
        public int AttemptSummaryId { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public int? ListId { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public int DialerModeAttempts { get; set; }

        public virtual CasContact Contact { get; set; }
        public virtual CasList List { get; set; }
        public virtual TUser User { get; set; }
    }
}
