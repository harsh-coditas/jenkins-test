using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPenaltyBoxAuditFisher
    {
        public int AuditId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CampaignUserId { get; set; }
        public string CampaignName { get; set; }
        public int ListId { get; set; }
        public string Listname { get; set; }
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string CrmId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Pbphone { get; set; }
        public int SessionId { get; set; }
        public string Pbdisposition { get; set; }
        public string AgentDisposition { get; set; }
        public string ClientFacingDisposition { get; set; }
        public string Crmobject { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? RemovalDate { get; set; }
        public bool? RecordStatus { get; set; }
        public string Phone3 { get; set; }
        public bool? IsDeleted { get; set; }
        public string StatusPhone1 { get; set; }
        public string StatusPhone2 { get; set; }
        public string StatusPhone3 { get; set; }
    }
}
