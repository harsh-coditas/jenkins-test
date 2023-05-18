using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class FuzzyCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ClientName { get; set; }
    }
}
