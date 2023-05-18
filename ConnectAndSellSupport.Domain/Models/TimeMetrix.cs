using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TimeMetrix
    {
        public int? SessionId { get; set; }
        public DateTime? MaxDate { get; set; }
        public DateTime? MinDate { get; set; }
    }
}
