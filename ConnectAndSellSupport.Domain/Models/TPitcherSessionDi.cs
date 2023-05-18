using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TPitcherSessionDi
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int SessionId { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime? SessionEnd { get; set; }
        public int? SessionRating { get; set; }
        public int NumRedials { get; set; }
        public int NumConnects { get; set; }
        public int TotalLeadTime { get; set; }
        public int TotalTalkTime { get; set; }
        public int TotalPauseTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int NumProblems { get; set; }
        public int NumLeads { get; set; }
        public string Ipaddress { get; set; }
        public int? NumValidConnects { get; set; }
        public int TotalWaitTime { get; set; }
    }
}
