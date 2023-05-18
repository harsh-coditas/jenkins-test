using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Summary
    {
        public int? SessionId { get; set; }
        public DateTime? Maxdate { get; set; }
        public DateTime? Mindate { get; set; }
        public int? LeadTime { get; set; }
        public int? TalkTime { get; set; }
        public int? PauseTime { get; set; }
        public int? Datediff { get; set; }
        public int? WaitTime { get; set; }
    }
}
