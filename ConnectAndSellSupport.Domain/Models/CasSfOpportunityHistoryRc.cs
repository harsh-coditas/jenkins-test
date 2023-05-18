using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasSfOpportunityHistoryRc
    {
        public int Id { get; set; }
        public string OpportunityCrmId { get; set; }
        public string StageName { get; set; }
        public string Probability { get; set; }
        public string Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ForecastCategory { get; set; }
        public string Custom { get; set; }
        public string CloseDate { get; set; }
        public string Type { get; set; }
    }
}
