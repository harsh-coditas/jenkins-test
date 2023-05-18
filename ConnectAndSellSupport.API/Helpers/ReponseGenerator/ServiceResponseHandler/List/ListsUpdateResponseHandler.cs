using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.List;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.List
{
    public class ListsUpdateResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ListsUpdateResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            return new Response(
                Versions.DefaultVersion,
                StatusCodes.Status200OK,
                Messages.SuccessMessage,
                null);
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is ListsUpdateServiceResponse listServiceResponse &&
                !listServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (listServiceResponse.ListsNotFound)
                {
                    errorCodes.Add(APIErrorCodes.ListsNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.ListsNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
