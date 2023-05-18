using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TContactSummaryMergedDatum
    {
        public int ContactSummaryId { get; set; }
        public int ContactId { get; set; }
        public int? AttemptCount { get; set; }
        public int? ConnectCount { get; set; }
        public string LastAttemptDisposition { get; set; }
        public string LastConnectDisposition { get; set; }
        public DateTime? LastAttemptDate { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public DateTime? FirstDialTime { get; set; }
        public DateTime? FirstConnectTime { get; set; }
    }
}
