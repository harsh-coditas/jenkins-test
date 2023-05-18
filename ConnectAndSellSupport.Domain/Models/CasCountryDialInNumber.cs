using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCountryDialInNumber
    {
        public int Id { get; set; }
        public string Isocode { get; set; }
        public string Country { get; set; }
        public string DialInNumber { get; set; }
        public string AlternateDialInNumber { get; set; }
        public string EngineIdentifier { get; set; }
    }
}
