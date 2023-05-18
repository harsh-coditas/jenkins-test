using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TEngineAllocatedActivity
    {
        public int Id { get; set; }
        public string EngineIdentifier { get; set; }
        public int StartActivityId { get; set; }
        public int EndActivityId { get; set; }
        public bool Active { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
    }
}
