using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.Company;
using ConnectAndSellSupport.API.Models.Response.Jobs;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.Company;
using ConnectAndSellSupport.Services.Models.Response.Job;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Job
{
    public class JobResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public JobResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is JobsRecordServiceResponse jobsRecordServiceResponse &&
                jobsRecordServiceResponse.Success)
            {
                var data = _mapper.Map<List<jobResponse>>(jobsRecordServiceResponse.JobResponse);

                data = data.OrderBy(d => d.JobName).ToList();

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status200OK,
                    Messages.SuccessMessage,
                    data);
            }

            return default;
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is JobsRecordServiceResponse jobsRecordServiceResponse &&
                !jobsRecordServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (jobsRecordServiceResponse.JobNotFound)
                {
                    errorCodes.Add(APIErrorCodes.JobsNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.CompaniesNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
