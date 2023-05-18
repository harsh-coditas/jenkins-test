using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SLeaderBoardSummary
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public int? Attempts { get; set; }
        public int? Connects { get; set; }
        public int? PositiveOutcomes { get; set; }
        public int? DateCount { get; set; }
    }
}
