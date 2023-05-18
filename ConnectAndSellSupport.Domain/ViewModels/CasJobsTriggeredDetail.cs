

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasJobsTriggeredDetail
    {
        public CasJobsTriggeredDetail()
        {
            //casJobsTriggeredDetails = new HashSet<CasJobsTriggeredDetails>();
        }
        [Key]
        public int id { get; set; }
        public int JobId { get; set; }

        public string JobName { get; set; }
        public DateTime? startTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string jobStatus { get; set; }

        public string InnerExceptionMessage { get; set; }
        public virtual CasMasterJob MasterJob { get; set; }
    }
}
