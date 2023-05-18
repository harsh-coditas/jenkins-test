using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TBilledSession
    {
        public int Id { get; set; }
        public int ScheduledSessionId { get; set; }
        public DateTime ScheduledStart { get; set; }
        public DateTime ScheduledEnd { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public string SessionType { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public decimal? SessionHours { get; set; }
        public decimal? AdjustmentHours { get; set; }
        public decimal? BilledHours { get; set; }
        public int? SessionConnects { get; set; }
        public int? ProblemConnects { get; set; }
        public int? AdjustmentConnects { get; set; }
        public int? BilledConnects { get; set; }
        public int? AgentCalls { get; set; }
        public decimal? TalkMinutes { get; set; }
        public decimal? PauseMinutes { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual TScheduledSession ScheduledSession { get; set; }
        public virtual TUser User { get; set; }
    }
}
