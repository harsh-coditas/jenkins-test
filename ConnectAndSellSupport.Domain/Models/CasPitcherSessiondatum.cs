using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPitcherSessiondatum
    {
        public string UserName { get; set; }
        public string ClientName { get; set; }
        public string GoalDuration { get; set; }
        public int? TotalWaitTime { get; set; }
        public int? TotalPauseTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
