using ConnectAndSellSupport.Services.Models.Response.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Job
{
    public interface IJobsRecordFetcher
    {
        Task<JobsRecordServiceResponse> GetJobRecord(DateTime startTime, DateTime endTime);
    }
}
