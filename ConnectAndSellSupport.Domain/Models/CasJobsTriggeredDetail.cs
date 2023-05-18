using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasJobsTriggeredDetail
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string JobName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? Endtime { get; set; }
        public string Jobstatus { get; set; }
        public string InnerExceptionMessage { get; set; }

        public virtual CasMasterJob Job { get; set; }
    }
}
