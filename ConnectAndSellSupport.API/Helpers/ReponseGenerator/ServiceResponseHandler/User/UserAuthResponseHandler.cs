using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.User;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.User
{
    public class UserAuthResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UserAuthResponseHandler(IMapper mapper)
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
                    _mapper.Map<LoginResponse>(serviceResponse));
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is LoginServiceResponse loginServiceResponse &&
                !loginServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                var message = Messages.InvalidCredentials;

                if (loginServiceResponse.UserInactive)
                {
                    errorCodes.Add(APIErrorCodes.UserInactive);
                    message = Messages.UserInactive;
                }

                if (loginServiceResponse.UserUnauthorized)
                {
                    errorCodes.Add(APIErrorCodes.UserUnauthorized);
                    message = Messages.UserUnauthorized;
                }

                if (loginServiceResponse.UserNotApproved)
                {
                    errorCodes.Add(APIErrorCodes.UserNotApproved);
                    message = Messages.UserNotApproved;
                }

                if (loginServiceResponse.UserLockedOut)
                {
                    errorCodes.Add(APIErrorCodes.UserLockedOut);
                    message = Messages.UserLockedOut;
                }

                if (loginServiceResponse.InvalidUserName)
                {
                    errorCodes.Add(APIErrorCodes.InvalidCredentials);
                }

                if (loginServiceResponse.PasswordMisMatch)
                {
                    errorCodes.Add(APIErrorCodes.InvalidCredentials);
                }

                return new Response(
                    Versions.DefaultVersion, 
                    StatusCodes.Status401Unauthorized,
                    message, 
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
