using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class TimeAllocation
    {
        public int Id { get; set; }
        public int? LeadTransitId { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public int? CampaignUserId { get; set; }
        public string CampaignUserName { get; set; }
        public int? CallListId { get; set; }
        public string DispositionText { get; set; }
        public DateTime? ThrowTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? PitcherLeadTime { get; set; }
        public int? TalkTime { get; set; }
        public int? Attempts { get; set; }
        public int? Connects { get; set; }
        public int? Conversations { get; set; }
        public int? Meetings { get; set; }
        public int? FollowUp { get; set; }
        public int? Transfer { get; set; }
        public int? Referral { get; set; }
        public int? IenumbersCount { get; set; }
        public int? CallType { get; set; }
        public byte? SessionType { get; set; }
        public int? ContactId { get; set; }
        public int? CallId { get; set; }
        public bool? DeletedList { get; set; }
        public bool? DeletedUser { get; set; }
        public byte? AssignmentId { get; set; }
        public byte? IsFollowUp { get; set; }
        public bool? Ienumber { get; set; }
    }
}
