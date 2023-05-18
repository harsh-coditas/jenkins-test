using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasManagementReportDl
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ProductType { get; set; }
        public string ToEmail { get; set; }
        public string CcEmail { get; set; }
        public string BccEmail { get; set; }
    }
}
