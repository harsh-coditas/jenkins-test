using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGoalDatum
    {
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public string GoalDuration { get; set; }
        public int? Attempt { get; set; }
        public int? Conversation { get; set; }
        public int? Meeting { get; set; }
        public int? FollowUp { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PauseTime { get; set; }
        public int? WaitTime { get; set; }
        public int? PitcherLeadTime { get; set; }
        public int? SessionTime { get; set; }
    }
}
