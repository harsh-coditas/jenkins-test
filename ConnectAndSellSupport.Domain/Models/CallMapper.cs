using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CallMapper
    {
        public int? NewPhoneCallId { get; set; }
        public int? OldPhoneCallId { get; set; }
        public int? OldContactId { get; set; }
        public long? NewContactId { get; set; }
        public int? OldPhoneNumberId { get; set; }
        public long? NewPhoneNumberId { get; set; }
        public int? OldSessionId { get; set; }
        public long? NewSessionId { get; set; }
        public int? EnvId { get; set; }
        public int? OldLeadtransitId { get; set; }
        public long? NewLeadtransitId { get; set; }
        public string ContactNumber { get; set; }
    }
}
