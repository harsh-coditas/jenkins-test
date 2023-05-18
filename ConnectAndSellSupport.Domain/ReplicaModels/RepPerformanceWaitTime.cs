using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class RepPerformanceWaitTime
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? CallListId { get; set; }
        public string ListName { get; set; }
        public byte? SessionType { get; set; }
        public int? SessionId { get; set; }
        public int? WaitTime { get; set; }
        public bool? DeletedUser { get; set; }
        public bool? DeletedList { get; set; }
        public int? Psid { get; set; }
        public DateTime? PscreateDate { get; set; }
    }
}
