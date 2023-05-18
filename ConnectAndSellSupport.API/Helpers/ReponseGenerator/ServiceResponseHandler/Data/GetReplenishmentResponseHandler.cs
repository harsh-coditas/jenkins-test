using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Data
{
    public class GetReplenishmentResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        public GetReplenishmentResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            return new Response(
                  Versions.DefaultVersion,
                  StatusCodes.Status200OK,
                  Messages.SuccessMessage,
                  _mapper.Map<ReplenishmentServiceResponse>(serviceResponse));
        }
        #endregion

        #region Interface implementations
        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is ReplenishmentServiceResponse replenishmentServiceResponse &&
               replenishmentServiceResponse.ReplenishmentDataNotFound)
            {
                var errorCodes = new List<string>
                {
                    APIErrorCodes.ReplenishmentDataNotFound
                };

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.ReplenishmentDataNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion       
    }
}
