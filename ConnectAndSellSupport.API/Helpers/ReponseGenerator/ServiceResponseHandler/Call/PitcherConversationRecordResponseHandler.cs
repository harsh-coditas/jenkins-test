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
    public class PitcherConversationRecordResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public PitcherConversationRecordResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is CallRecordServiceResponse callRecordServiceResponse)
            {
                // Response returns a combined conversation record from both t_call and cas_note table
                var data = _mapper.Map<PitcherConversionRecordResponse>(callRecordServiceResponse);
                data = _mapper.Map(callRecordServiceResponse.CallDetails, data);
                data = _mapper.Map(callRecordServiceResponse.NoteDetails, data);

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
            if (serviceResponse is CallRecordServiceResponse callRecordServiceResponse &&
                !callRecordServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                var statusCode = StatusCodes.Status400BadRequest;
                var message = Messages.ErrorMessage;

                if (callRecordServiceResponse.InvalidLeadTransitId)
                {
                    errorCodes.Add(APIErrorCodes.InvalidLeadTransitId);
                    statusCode = StatusCodes.Status404NotFound;
                    message = Messages.ConversationNotFound;
                }
                else if (callRecordServiceResponse.PitcherRecordNotFound && callRecordServiceResponse.CasNoteNotFound)
                {
                    errorCodes.Add(APIErrorCodes.ConversationNotFound);
                    statusCode = StatusCodes.Status404NotFound;
                    message = Messages.ConversationNotFound;
                }
                else if (callRecordServiceResponse.PitcherRecordNotFound || callRecordServiceResponse.CasNoteNotFound)
                {
                    errorCodes.Add(APIErrorCodes.ConversationIncomplete);
                    statusCode = StatusCodes.Status404NotFound;
                    message = Messages.ConversationNotFound;
                }

                return new Response(
                    Versions.DefaultVersion,
                    statusCode,
                    message,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
