using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMeeting
    {
        public CasMeeting()
        {
            CasMeetingInvitees = new HashSet<CasMeetingInvitee>();
        }

        public int MeetingId { get; set; }
        public string CalendarMeetingId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string UserName { get; set; }
        public int ContactId { get; set; }
        public int? ListId { get; set; }
        public int CompanyId { get; set; }
        public int SessionType { get; set; }
        public bool? IsMeetingOccured { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
        public bool? IsMeetingOnTarget { get; set; }
        public string Feedback { get; set; }
        public bool ResponseEmailSent { get; set; }
        public string Location { get; set; }
        public int? LeadTransitId { get; set; }
        public string ServiceProvider { get; set; }
        public string TimeZone { get; set; }
        public int? MeetingDuration { get; set; }

        public virtual ICollection<CasMeetingInvitee> CasMeetingInvitees { get; set; }
    }
}
