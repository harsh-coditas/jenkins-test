using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMatching
    {
        public int MatchingId { get; set; }
        public DateTime? MatchedDate { get; set; }
        public DateTime? MatchStartDate { get; set; }
        public DateTime? MatchEndDate { get; set; }
        public int? MatchPercentage { get; set; }
        public int? TotalRecords { get; set; }
        public int? RecordsUpdated { get; set; }
        public int? RecordsSkipped { get; set; }
        public int? MatchedById { get; set; }
        public string MatchedByName { get; set; }
        public int? CompanyId { get; set; }
    }
}
