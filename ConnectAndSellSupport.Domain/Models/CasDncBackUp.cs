using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasDncBackUp
    {
        public int DncBackUpId { get; set; }
        public int? ClientCompanyId { get; set; }
        public string ClientCompanyName { get; set; }
        public string ContactNumber { get; set; }
        public int? ContactId { get; set; }
        public DateTime? DeleteContactDateTime { get; set; }
    }
}
