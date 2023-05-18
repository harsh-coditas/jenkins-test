using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListUserBackup4Feb
    {
        public int ListId { get; set; }
        public int UserId { get; set; }
        public int AccessType { get; set; }
        public int? VoicemailId { get; set; }
        public int? GreetingId { get; set; }
        public string CallerId { get; set; }
    }
}
