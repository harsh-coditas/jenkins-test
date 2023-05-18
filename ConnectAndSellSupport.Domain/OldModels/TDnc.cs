using System;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TDnc
    {
        public int Id { get; set; }
        public int ClientCompanyId { get; set; }
        public string ContactCompany { get; set; }
        public string ContactNumber { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactCountry { get; set; }
        public string ReasonMessage { get; set; }
        public string Pitcher { get; set; }
        public string Agent { get; set; }
        public int Dnctype { get; set; }
        public DateTime Dncexpires { get; set; }
        public string ClientCompany { get; set; }

        public virtual TCompany ClientCompanyNavigation { get; set; }
    }
}
