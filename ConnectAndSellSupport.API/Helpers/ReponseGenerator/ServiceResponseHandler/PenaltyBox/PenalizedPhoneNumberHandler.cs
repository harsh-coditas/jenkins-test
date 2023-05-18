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
    public class PenalizedPhoneNumberHandler : IServiceResponseHandler
    {
        private readonly IMapper _mapper;

        public PenalizedPhoneNumberHandler(IMapper map)
        {
            _mapper = map;
        }
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is PenaltyBoxDetailsResponse detailsResponse)
            {
                var data = _mapper.Map<PenaltyBoxFetcherResponse>(detailsResponse);
                // data = _mapper.Map(detailsResponse.CasPenalizedPhoneNumberDetails, data);
                //data = _mapper.Map(detailsResponse.CasPenalizedPhoneNumberDetails, data);
                data.penalisedPhoneNumberResponse = _mapper.Map<List<CasPenalisedPhoneNumberResponse>>(detailsResponse.CasPenalizedPhoneNumberDetails);
                data.penaltyBoxResponses = _mapper.Map<List<CasPenaltyBoxResponse>>(detailsResponse.CasPenaltyBoxDetails);

                return new Response(
                     Versions.DefaultVersion,
                        StatusCodes.Status200OK,
                        Messages.SuccessMessage,
                        data
                    );
            }
            return default;
        }


        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is PenaltyBoxDetailsResponse detailsResponse &&
                !detailsResponse.Success)
            {
                var errorCodes = new List<string>();
                var statusCode = StatusCodes.Status400BadRequest;
                var message = Messages.ErrorMessage;

                if (detailsResponse.ContactNotFound)
                {
                    errorCodes.Add(APIErrorCodes.ContactNotFound);
                    statusCode = StatusCodes.Status404NotFound;
                    message = Messages.ConversationNotFound;
                }
                //else if (detailsResponse.PitcherRecordNotFound && detailsResponse.CasNoteNotFound)
                //{
                //    errorCodes.Add(APIErrorCodes.ConversationNotFound);
                //    statusCode = StatusCodes.Status404NotFound;
                //    message = Messages.ConversationNotFound;
                //}
                //else if (callRecordServiceResponse.PitcherRecordNotFound || callRecordServiceResponse.CasNoteNotFound)
                //{
                //    errorCodes.Add(APIErrorCodes.ConversationIncomplete);
                //    statusCode = StatusCodes.Status404NotFound;
                //    message = Messages.ConversationNotFound;
                //}

                return new Response(
                    Versions.DefaultVersion,
                    statusCode,
                    message,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
    }
}
