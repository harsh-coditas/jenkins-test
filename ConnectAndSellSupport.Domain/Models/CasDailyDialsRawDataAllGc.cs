using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasDailyDialsRawDataAllGc
    {
        public int? EnvId { get; set; }
        public string ClientName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Dials { get; set; }
        public int? Conversations { get; set; }
        public int? MeetingCount { get; set; }
        public int? ProblemConenctCount { get; set; }
        public int? DirectNumberCount { get; set; }
        public int? MainNumberCount { get; set; }
        public int? GateKeeparCount { get; set; }
        public int? TotalRep { get; set; }
    }
}
