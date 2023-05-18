using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class ConversionRateTrending
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int? CampaignUserId { get; set; }
        public int? CallListId { get; set; }
        public string CallListName { get; set; }
        public DateTime? SessionDate { get; set; }
        public byte? SessionType { get; set; }
        public byte? AssignmentType { get; set; }
        public bool? IsFollowUpList { get; set; }
        public string DispositionText { get; set; }
        public bool? IsConversation { get; set; }
        public bool? IsMeeting { get; set; }
        public string DispositionType { get; set; }
        public int? DispositionTypeValue { get; set; }
        public int? Conversations { get; set; }
        public int? Connects { get; set; }
        public int? Meetings { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public int? CallId { get; set; }
    }
}
