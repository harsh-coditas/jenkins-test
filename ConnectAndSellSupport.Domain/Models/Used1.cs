using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Used1
    {
        public int Id { get; set; }
        public bool FollowUpHappened { get; set; }
        public bool IsConversation { get; set; }
        public string CampaignName { get; set; }
        public int? ContactId { get; set; }
        public DateTime? Throwtime { get; set; }
        public long? Rnk { get; set; }
    }
}
