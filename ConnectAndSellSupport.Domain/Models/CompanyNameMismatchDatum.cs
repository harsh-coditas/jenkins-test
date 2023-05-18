using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CompanyNameMismatchDatum
    {
        public int Contactid { get; set; }
        public int? CallContactid { get; set; }
        public string CallCompanyname { get; set; }
        public string CompanyName { get; set; }
        public int TcallId { get; set; }
        public int? LeadTransitId { get; set; }
    }
}
