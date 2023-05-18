using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Models.Response.Job
{
    public class JobsRecordServiceResponse : BaseServiceResponse
    {
        public List<JobDetailsResponse> JobResponse { get; set; }
        public bool JobNotFound { get; set; }
    }
}
