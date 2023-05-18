using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class FuzzyCompanyFinalMatch
    {
        public int? FirstCompanyId { get; set; }
        public string FirstCompanyName { get; set; }
        public int? SecondCompanyId { get; set; }
        public string SecondCompanyName { get; set; }
        public string ClientName { get; set; }
        public double? MatchScore { get; set; }
    }
}
