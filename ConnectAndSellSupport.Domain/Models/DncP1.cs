using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class DncP1
    {
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string CompanyName { get; set; }
        public string ContactTel1 { get; set; }
        public string ClientName { get; set; }
        public long? Rnk { get; set; }
    }
}
