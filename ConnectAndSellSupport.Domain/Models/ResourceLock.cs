using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class ResourceLock
    {
        public string ResourceKey { get; set; }
        public string HoldReleaseUserContext { get; set; }
        public Guid? HoldReleaseSystemContext { get; set; }
        public bool IsLocked { get; set; }
        public int? Spid { get; set; }
        public DateTime? LockAcquiredOn { get; set; }
    }
}
