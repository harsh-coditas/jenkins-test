using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMasterJob
    {
        public CasMasterJob()
        {
            CasJobsTriggeredDetails = new HashSet<CasJobsTriggeredDetail>();
        }

        public int JobId { get; set; }
        public string JobName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? Endtime { get; set; }

        public virtual ICollection<CasJobsTriggeredDetail> CasJobsTriggeredDetails { get; set; }
    }
}
