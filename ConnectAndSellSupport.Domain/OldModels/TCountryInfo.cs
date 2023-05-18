using System;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TCountryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RootName { get; set; }
        public string CountryCode { get; set; }
        public string IddCode { get; set; }
        public string NddCode { get; set; }
        public string DomesticFormat { get; set; }
        public int? MinDigits { get; set; }
        public int? MaxDigits { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public string Iso3Code { get; set; }
        public string Iso2Code { get; set; }
        public bool? NoCountryCode { get; set; }
        public string IntlFormat { get; set; }
    }
}
