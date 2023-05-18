using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class TSession
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string CampaignName { get; set; }
        public int? CampaignId { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ScheduledEnd { get; set; }
        public int? State { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public bool? IsOnsiteTrial { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int SessionType { get; set; }
        public int InitialLeadCount { get; set; }
        public int BlockedLeadCount { get; set; }
        public int CallableLeadCount { get; set; }
        public int DelayedLeadCount { get; set; }
        public int FutureLeadCount { get; set; }
        public int ActiveLeadCount { get; set; }
        public int InactiveLeadCount { get; set; }
        public int ThrownLeadCount { get; set; }
        public int TransferredLeadCount { get; set; }
        public DateTime FirstGoTime { get; set; }
        public DateTime LastAgentCallTime { get; set; }
    }
}
