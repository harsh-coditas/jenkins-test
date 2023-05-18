using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListUser
    {
        public int ListId { get; set; }
        public int UserId { get; set; }
        public int AccessType { get; set; }
        public int? VoicemailId { get; set; }
        public int? GreetingId { get; set; }
        public string CallerId { get; set; }
        public bool? IsArchived { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual CasUserGreeting Greeting { get; set; }
        public virtual CasList List { get; set; }
        public virtual TUser User { get; set; }
        public virtual CasUserVoicemail Voicemail { get; set; }
    }
}
