using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMasterJob
    {
        public CasMasterJob()
        {
            CasJobsTriggeredDetails = new HashSet<CasJobsTriggeredDetails>();
        }
        [Key]
        public int JobId { get; set; }
        public string JobName { get; set; }
        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public virtual ICollection<CasJobsTriggeredDetails> CasJobsTriggeredDetails { get; set; }


    }
}
