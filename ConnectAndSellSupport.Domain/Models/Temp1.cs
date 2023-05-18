using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Temp1
    {
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public int TotalWaitTime { get; set; }
        public int TotalPauseTime { get; set; }
        public long? TalkTimeOrder { get; set; }
    }
}
