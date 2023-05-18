using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Session
    {
        public Session()
        {
            Leads = new HashSet<Lead>();
            SessionActivities = new HashSet<SessionActivity>();
            SessionNotes = new HashSet<SessionNote>();
        }

        public int SessionId { get; set; }
        public bool IsScheduled { get; set; }
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public string SessionType { get; set; }
        public string ScheduledStart { get; set; }
        public string ScheduledEnd { get; set; }
        public string CampaignName { get; set; }
        public string ClientSvcManager { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<SessionActivity> SessionActivities { get; set; }
        public virtual ICollection<SessionNote> SessionNotes { get; set; }
    }
}
