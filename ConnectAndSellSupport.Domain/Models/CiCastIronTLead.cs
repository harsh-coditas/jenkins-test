using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CiCastIronTLead
    {
        public int Seq { get; set; }
        public string Flag { get; set; }
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyTel1 { get; set; }
        public string CompanyTel2 { get; set; }
        public string CompanyAddr1 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
        public string CompanyCountry { get; set; }
        public string ContactTel1 { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? WaitDate { get; set; }
        public string SalesForceId { get; set; }
        public string LastPitcherNote { get; set; }
        public string PitcherDisposition { get; set; }
    }
}
