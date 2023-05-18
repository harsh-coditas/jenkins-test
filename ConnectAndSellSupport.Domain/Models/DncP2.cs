using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class DncP2
    {
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string CompanyName { get; set; }
        public string ContactTel2 { get; set; }
        public string ClientName { get; set; }
        public long? Rnk { get; set; }
    }
}
