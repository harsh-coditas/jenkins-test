using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class RepCount
    {
        public int Id { get; set; }
        public int? LeadTransitId { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string CampaignUserName { get; set; }
        public int? CampaignUserId { get; set; }
        public string ListName { get; set; }
        public int? ListId { get; set; }
        public byte? SessionType { get; set; }
        public string Text { get; set; }
        public bool? IsvalidConnect { get; set; }
        public byte? CallType { get; set; }
        public bool? IsConversation { get; set; }
        public bool? IsMeetingSet { get; set; }
        public bool? IsFollowUpMarked { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ThrowTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public bool? CallSentiment { get; set; }
        public int? TalkTime { get; set; }
        public int? CallId { get; set; }
        public bool? IsReferral { get; set; }
    }
}
