using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using System;
using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Request.PenaltyBox
{
    public class RemovePenaltyBoxEntityRequest
    {
        public PenaltyBoxEntityType Type { get; set; }
        public int CompanyId { get; set; }
        public HashSet<int> UserIds { get; set; }
        public HashSet<int> ListIds { get; set; }
        public DateTime FromDate{ get; set; }
        public DateTime ToDate{ get; set; }
    }
}
