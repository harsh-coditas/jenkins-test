using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class AgentCallSendTime
    {
        public int? ContactId { get; set; }
        public int? LeadTransitId { get; set; }
        public DateTime? CallSendTime { get; set; }
        public DateTime? PopUpTime { get; set; }
        public int? DifferenceCount { get; set; }
    }
}
