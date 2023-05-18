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
    public class PitcherConversationUpdateRecordResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public PitcherConversationUpdateRecordResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is PitcherCallRecordUpdateServiceResponse callRecordServiceResponse)
            {
                // Response returns a combined conversation record from both t_call and cas_note table
                var data = _mapper.Map<PitcherConversionUpdateRecordResponse>(callRecordServiceResponse.CallDetails);
                data ??= _mapper.Map(callRecordServiceResponse.NoteDetails, data);

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
            if (serviceResponse is PitcherCallRecordUpdateServiceResponse callRecordServiceResponse &&
                !callRecordServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                var statusCode = StatusCodes.Status400BadRequest;
                var message = Messages.ErrorMessage;

                // Message handling arranged in order of priority of final message/status
                // Least to highest priority
                if (callRecordServiceResponse.InvalidDispositionId)
                {
                    errorCodes.Add(APIErrorCodes.InvalidDispositionId);
                    message = Messages.InvalidDispositionId;
                }

                if (callRecordServiceResponse.InvalidNextCallDate)
                {
                    errorCodes.Add(APIErrorCodes.InvalidNextCallDate);
                    message = Messages.InvalidDispositionId;
                }

                if (callRecordServiceResponse.InvalidLeadTransitId)
                {
                    errorCodes.Add(APIErrorCodes.InvalidLeadTransitId);
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
