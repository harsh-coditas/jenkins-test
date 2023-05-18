using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasConversationTracking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LeadTransitId { get; set; }
        public bool IsListened { get; set; }
        public bool IsRated { get; set; }
        public string RecordingListenedMap { get; set; }
        public int RatingCount { get; set; }
        public int RecordingListenedInPercentage { get; set; }
        public int TimeSpentInSec { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
    }
}
