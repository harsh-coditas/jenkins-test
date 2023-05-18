using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TempAttemptcount
    {
        public int? ContactId { get; set; }
        public DateTime? FirstDialDate { get; set; }
        public DateTime? FirstConnectTime { get; set; }
    }
}
