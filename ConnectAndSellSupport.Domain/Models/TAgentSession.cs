using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TAgentSession
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int TotalLeads { get; set; }
        public string AgentIdentifier { get; set; }
        public int TotalTransfers { get; set; }
        public int ValidConnects { get; set; }
        public int TotalLeadTime { get; set; }
        public int TotalTalkTime { get; set; }
        public int TotalPauseTime { get; set; }
        public int Redials { get; set; }
        public int VoicemailsLeft { get; set; }
        public int HourlyRate { get; set; }
        public string Ipaddress { get; set; }
    }
}
