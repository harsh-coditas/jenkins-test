using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class WrapTimeReport
    {
        public int? SessionId { get; set; }
        public DateTime? ThrowTime { get; set; }
        public string ClientName { get; set; }
        public string CampaignName { get; set; }
        public int? LeadTransitId { get; set; }
        public int? WrapTime { get; set; }
    }
}
