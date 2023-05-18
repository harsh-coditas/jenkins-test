using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.Call;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.Call;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Call
{
    public class AgentCallRecordResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public AgentCallRecordResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {   
            if (serviceResponse is CallRecordServiceResponse callRecordServiceResponse)
            {
                return new Response(
                        Versions.DefaultVersion,
                        StatusCodes.Status200OK,
                        Messages.SuccessMessage,
                        _mapper.Map<AgentCallRecordResponse>(callRecordServiceResponse.CallDetails));
            }

            return default;
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is CallRecordServiceResponse callRecordServiceResponse &&
                !callRecordServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (callRecordServiceResponse.InvalidLeadTransitId)
                {
                    errorCodes.Add(APIErrorCodes.InvalidLeadTransitId);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.ConversationNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
