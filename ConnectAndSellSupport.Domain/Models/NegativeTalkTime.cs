using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class NegativeTalkTime
    {
        public int? SessionId { get; set; }
        public int? TalkTime { get; set; }
    }
}
