using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserVoicemail
    {
        public CasUserVoicemail()
        {
            CasListUsers = new HashSet<CasListUser>();
        }

        public int VoicemailId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? VoicemailIndex { get; set; }
        public double RecordDuration { get; set; }

        public virtual ICollection<CasListUser> CasListUsers { get; set; }
    }
}
