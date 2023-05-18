using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TLeadAppStat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserSessionId { get; set; }
        public int UserRole { get; set; }
        public int CampaignSessionId { get; set; }
        public int LeadId { get; set; }
        public int LeadTransitId { get; set; }
        public DateTime LeadCatchTime { get; set; }
        public DateTime LeadTransferTime { get; set; }
        public DateTime DisposeTime { get; set; }
        public DateTime LeadDisplayTime { get; set; }
        public DateTime PopupTime { get; set; }
        public int AvgLatency { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
    }
}
