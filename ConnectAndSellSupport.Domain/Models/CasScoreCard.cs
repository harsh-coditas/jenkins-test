using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasScoreCard
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int RepId { get; set; }
        public int AttemptsTarget { get; set; }
        public int ConversationsTarget { get; set; }
        public double SessionTarget { get; set; }
        public int MeetingTarget { get; set; }
        public double? TargetSessionDialTimePerDay { get; set; }
        public double? TargetSessionDialTimePerWeek { get; set; }
        public double? TargetSessionDialTimePerMonth { get; set; }
        public int TargetConversationsPerDay { get; set; }
        public int TargetConversationsPerWeek { get; set; }
        public int TargetConversationsPerMonth { get; set; }
        public int? TargetAttemptPerDay { get; set; }
        public int? TargetAttemptPerWeek { get; set; }
        public int? TargetAttemptPerMonth { get; set; }
        public int? TargetMeetingPerDay { get; set; }
        public int? TargetMeetingPerWeek { get; set; }
        public int? TargetMeetingPerMonth { get; set; }
    }
}
