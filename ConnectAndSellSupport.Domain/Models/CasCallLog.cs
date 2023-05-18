using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCallLog
    {
        public int CallLogId { get; set; }
        public DateTime? CallTransferBegin { get; set; }
        public DateTime? CallTransferEnd { get; set; }
        public string ClientName { get; set; }
    }
}
