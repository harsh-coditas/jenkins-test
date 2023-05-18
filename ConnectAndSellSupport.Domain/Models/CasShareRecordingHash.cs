using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasShareRecordingHash
    {
        public int Id { get; set; }
        public int? LeadTransitId { get; set; }
        public string HashLeadTransitId { get; set; }
        public string Url { get; set; }
        public int? RecordingCompanyId { get; set; }
        public int? UserPermittedRole { get; set; }
    }
}
