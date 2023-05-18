using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TTriggerLog
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ListId { get; set; }
        public int TriggerId { get; set; }
        public int TriggerActionId { get; set; }
        public int? SessionId { get; set; }
        public string UserName { get; set; }
        public string ClientName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual CasContact Contact { get; set; }
        public virtual CasList List { get; set; }
        public virtual CasTrigger Trigger { get; set; }
        public virtual CasTriggerAction TriggerAction { get; set; }
    }
}
