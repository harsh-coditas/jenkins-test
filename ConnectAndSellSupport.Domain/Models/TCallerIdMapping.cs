using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TCallerIdMapping
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Iso2countryCode { get; set; }
        public string DefaultCountryIso2code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
