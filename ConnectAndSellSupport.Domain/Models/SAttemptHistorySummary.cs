using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SAttemptHistorySummary
    {
        public int Id { get; set; }
        public string AreaCode { get; set; }
        public DateTime CallDate { get; set; }
        public int ContactId { get; set; }
        public string DialedNumber { get; set; }
        public string PreviousAgent { get; set; }
        public string PreviousAgentCompanyName { get; set; }
        public string PreviousAgentLocationCode { get; set; }
        public int? PreviousAgentHourlyRate { get; set; }
        public int? PreviousAgentScore { get; set; }
        public int? PreviousAgentLanguageSkills { get; set; }
        public int? PreviousAgentPriority { get; set; }
        public int? PreviousAgentSla { get; set; }
        public string PreviousDisposition { get; set; }
        public int? PreviousTalkTime { get; set; }
        public int? PreviousWaitTime { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
        public bool? IsIvr { get; set; }
        public bool? IsDirect { get; set; }
    }
}
