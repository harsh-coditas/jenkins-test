using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasConnectBackup
    {
        public int ConnectId { get; set; }
        public int? ClinetId { get; set; }
        public string ClientName { get; set; }
        public string Crmid { get; set; }
        public int? LeadTransitId { get; set; }
        public DateTime? ThrowTime { get; set; }
        public string UserName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string CompanyName { get; set; }
        public string DispositionText { get; set; }
        public short? DispositionType { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsMeetingSet { get; set; }
    }
}
