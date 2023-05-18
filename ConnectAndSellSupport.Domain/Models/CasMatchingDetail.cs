using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMatchingDetail
    {
        public int MatchingDetailsId { get; set; }
        public int? MatchingId { get; set; }
        public string SfaccountName { get; set; }
        public string CascompanyName { get; set; }
        public int? MatchingStatus { get; set; }
    }
}
