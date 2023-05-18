using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMeetingInvitee
    {
        public int MeetingInviteeId { get; set; }
        public int MeetingId { get; set; }
        public string InviteeEmail { get; set; }
        public string InviteeResponse { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
        public string InviteeType { get; set; }

        public virtual CasMeeting Meeting { get; set; }
    }
}
