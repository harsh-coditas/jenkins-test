using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class ProblemConnect
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int? CampaignUserId { get; set; }
        public int? CallListId { get; set; }
        public DateTime? SessionDate { get; set; }
        public string Text { get; set; }
        public short? DispositionType { get; set; }
        public int? DispositionCount { get; set; }
        public byte? SessionType { get; set; }
        public bool? IsConversation { get; set; }
        public bool? IsValidConnect { get; set; }
        public bool? IsMeetingSet { get; set; }
        public bool? IsFollowUp { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public bool? IsCallSentiment { get; set; }
        public int? MaxCallId { get; set; }
    }
}
