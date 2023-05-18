using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class ResourceLockHistory
    {
        public long HistoryId { get; set; }
        public string ResourceKey { get; set; }
        public string HoldReleaseUserContext { get; set; }
        public Guid? HoldReleaseSystemContext { get; set; }
        public int? Spid { get; set; }
        public DateTime? LockAcquiredOn { get; set; }
        public DateTime? LockReleasedOn { get; set; }
    }
}
