using AutoMapper;
using ConnectAndSellSupport.Repository.Contracts.CasJobTriggeredDetails;
using ConnectAndSellSupport.Services.Contracts.Job;
using ConnectAndSellSupport.Services.Models.Response.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Job
{
    public class JobRecordFetcher : IJobsRecordFetcher
    {
        #region Private members
        private readonly ICasJobTriggeredDetails _JobTriggeredDetails;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public JobRecordFetcher(ICasJobTriggeredDetails jobTriggeredDetails, IMapper mapper)
        {
            _JobTriggeredDetails = jobTriggeredDetails;
            _mapper = mapper;
        }
        #endregion
        #region Interface implementations
        public async Task<JobsRecordServiceResponse> GetJobRecord(DateTime startTime, DateTime endTime)
        {
           
            var jobRecord = await _JobTriggeredDetails.GetByStartDateJobIdJobName( startTime , endTime);
            if(!jobRecord?.Any()?? true)
            {
                return new JobsRecordServiceResponse
                {
                    JobNotFound = true
                };
            }
           return new JobsRecordServiceResponse()
            {
                JobResponse = _mapper.Map<List<JobDetailsResponse>>(jobRecord),
                Success = true
            };
           
        }
        #endregion
    }
}
