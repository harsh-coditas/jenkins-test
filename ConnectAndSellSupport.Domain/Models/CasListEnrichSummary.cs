using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListEnrichSummary
    {
        public int ListId { get; set; }
        public DateTime? EnrichStartTimestamp { get; set; }
        public DateTime? EnrichEndTimestamp { get; set; }
        public int? ContactTotalCount { get; set; }
        public int? ContactMatchCount { get; set; }
        public int? ContactNotFoundCount { get; set; }
        public int? ContactMainAddCount { get; set; }
        public int? ContactMainAlternateCount { get; set; }
        public int? ContactDirectAddCount { get; set; }
        public int? ContactDirectAlternateCount { get; set; }
        public int? ContactJobChangeEnrichedPhoneCount { get; set; }

        public virtual CasList List { get; set; }
    }
}
