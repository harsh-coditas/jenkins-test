using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasLeadCompany
    {
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public int? AttemptedOrNot { get; set; }
        public int? ListId { get; set; }
        public string ListName { get; set; }
    }
}
