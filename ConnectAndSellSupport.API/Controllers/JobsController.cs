using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.Services.Contracts.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Controllers
{
    [Route(Routes.GenericControllerV1)]
    [ApiController]
    [Authorize(Policy = Policies.AdminAndEngineering)]
    public class JobsController : ControllerBase
    {
        private readonly IJobsRecordFetcher _jobTriggeredDetails;
       // private readonly IRequestFactory _requestFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<JobsController> _logger;
        public JobsController(IJobsRecordFetcher jobTriggeredDetails,
            IRequestFactory requestFactory,
            IResponseFactory responseFactory,
            ILogger<JobsController> logger)
        {
            _jobTriggeredDetails = jobTriggeredDetails;
           // _requestFactory = requestFactory;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        [Route(Routes.ListsForJobsByStartDateAndEndDate)]
        [HttpGet]
        public async Task<IActionResult> GetJobsRecord(DateTime startTime, DateTime endTime )
        {
            try
            {
                var serviceResponce = await _jobTriggeredDetails.GetJobRecord(startTime ,endTime);
                return _responseFactory.GetResponse(serviceResponce);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve Jobs record for dates from {startTime} to {endTime}", startTime);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
           
        }
    }
}
