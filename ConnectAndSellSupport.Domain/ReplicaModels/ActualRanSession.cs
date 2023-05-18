using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.ReplicaModels
{
    public partial class ActualRanSession
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public byte? SessionType { get; set; }
        public bool? Isdeleted { get; set; }
        public int? WaitTime { get; set; }
    }
}
