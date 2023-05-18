using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbruleReport
    {
        public int ReportId { get; set; }
        public int? ContactId { get; set; }
        public int? RuleId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EntityAction { get; set; }
        public bool? ActionResult { get; set; }
    }
}
