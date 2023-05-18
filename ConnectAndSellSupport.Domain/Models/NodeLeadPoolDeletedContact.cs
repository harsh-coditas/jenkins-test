using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class NodeLeadPoolDeletedContact
    {
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public bool CheckedOut { get; set; }
        public int? CheckedOutUserId { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public bool? IsConnected { get; set; }
    }
}
