using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasLog
    {
        public int Id { get; set; }
        public int LeadTransitId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Activity { get; set; }
    }
}
