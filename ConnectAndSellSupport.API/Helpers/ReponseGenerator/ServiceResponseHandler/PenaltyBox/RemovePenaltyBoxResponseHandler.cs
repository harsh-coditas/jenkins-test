using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.PenaltyBox
{
    public class RemovePenaltyBoxResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public RemovePenaltyBoxResponseHandler(IMapper mapper)
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
                _mapper.Map<RemovePenaltyBoxResponse>(serviceResponse));
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is RemovePenaltyBoxEntityServiceResponse penaltyBoxEntityServiceResponse &&
                !penaltyBoxEntityServiceResponse.Success)
            {
                var errorCodes = new List<string>();

                if (penaltyBoxEntityServiceResponse.ContactsNotFound)
                {
                    errorCodes.Add(APIErrorCodes.ContactsNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.ContactsNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
