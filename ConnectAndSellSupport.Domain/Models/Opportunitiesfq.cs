using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Opportunitiesfq
    {
        public string StageName { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityCrmId { get; set; }
        public string UserName { get; set; }
        public string OwnerName { get; set; }
        public double? Probability { get; set; }
        public double? Amount { get; set; }
        public double? Value { get; set; }
        public string CloseDate { get; set; }
        public int ConnectCount { get; set; }
        public string AccountName { get; set; }
        public DateTime OpportunityCreatedate { get; set; }
        public string TeamName { get; set; }
        public string Type { get; set; }
    }
}
