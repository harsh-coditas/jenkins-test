using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasActiveCompany
    {
        public string CompanyName { get; set; }
        public string EnvId { get; set; }
        public string Csm { get; set; }
        public string Type { get; set; }
        public string SfdcName { get; set; }
    }
}
