using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class FuzzyCompanyFinalMatchBackup
    {
        public int? FirstCompanyId { get; set; }
        public string FirstCompanyName { get; set; }
        public int? SecondCompanyId { get; set; }
        public string SecondCompanyName { get; set; }
        public string ClientName { get; set; }
    }
}
