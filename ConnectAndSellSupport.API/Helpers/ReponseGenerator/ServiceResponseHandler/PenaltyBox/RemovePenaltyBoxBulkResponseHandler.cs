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
    public class RemovePenaltyBoxBulkResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public RemovePenaltyBoxBulkResponseHandler(IMapper mapper)
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
                _mapper.Map<RemovePenaltyBoxBulkResponse>(serviceResponse));
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is RemovePenaltyBoxEntityBulkServiceResponse penaltyBoxEntityServiceResponse &&
                !penaltyBoxEntityServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                var statusCode = 0;
                var message = string.Empty;

                // Message handling arranged in order of priority of final message/status
                // Least to highest priority
                if (penaltyBoxEntityServiceResponse.InvalidCompanyId)
                {
                    errorCodes.Add(APIErrorCodes.InvalidCompanyId);
                    statusCode = StatusCodes.Status400BadRequest;
                    message = Messages.InvalidCompanyId;
                }

                if (penaltyBoxEntityServiceResponse.InvalidFileFormat)
                {
                    errorCodes.Add(APIErrorCodes.InvalidFileFormat);
                    statusCode = StatusCodes.Status400BadRequest;
                    message = Messages.InvalidFileFormat;
                }

                if (penaltyBoxEntityServiceResponse.EmptyFile)
                {
                    errorCodes.Add(APIErrorCodes.EmptyFileFormat);
                    statusCode = StatusCodes.Status400BadRequest;
                    message = Messages.EmptyFileFormat;
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
