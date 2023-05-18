using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTriggerList
    {
        public int TriggerId { get; set; }
        public int ListId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual CasList List { get; set; }
        public virtual CasTrigger Trigger { get; set; }
    }
}
