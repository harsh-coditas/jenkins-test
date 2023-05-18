using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGoalTarhet
    {
        public string GoalType { get; set; }
        public string GoalDuration { get; set; }
        public int? GoalTarget { get; set; }
    }
}
