using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGoalDataDailyDatum
    {
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public string GoalDuration { get; set; }
        public int? AttemptDaily { get; set; }
        public int? ConversationDaily { get; set; }
        public int? MeetingDaily { get; set; }
        public int? FollowUpDaily { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PauseTimeDaily { get; set; }
        public int? WaitTimeDaily { get; set; }
        public int? PitcherLeadTimeDaily { get; set; }
    }
}
