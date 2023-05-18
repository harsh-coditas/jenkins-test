using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class AttemptedNumber
    {
        public int LeadTransitId { get; set; }
        public string DialedNumber { get; set; }
        public bool IsDirect { get; set; }
    }
}
