using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasEtllog
    {
        public int EtllogId { get; set; }
        public string PackageId { get; set; }
        public string TaskId { get; set; }
        public int? TotalRecordPrevious { get; set; }
        public int? SendMryesRecordPrevious { get; set; }
        public int? StatusOngoingRecordPrevious { get; set; }
        public int? TotalSendMrPrevious { get; set; }
        public int? TotalRecordNew { get; set; }
        public int? SendMryesRecordNew { get; set; }
        public int? TotalSendMrNew { get; set; }
        public int? StatusOngoingRecordNew { get; set; }
        public DateTime? LogStartDate { get; set; }
        public DateTime? LogEndDate { get; set; }
    }
}
