using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TScheduledSession
    {
        public TScheduledSession()
        {
            TBilledSessions = new HashSet<TBilledSession>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public int RecurrenceIndex { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ScheduledEnd { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public int Pitchers { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual TUser User { get; set; }
        public virtual ICollection<TBilledSession> TBilledSessions { get; set; }
    }
}
