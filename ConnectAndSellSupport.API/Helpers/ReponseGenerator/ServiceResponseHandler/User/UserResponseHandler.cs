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
using System.Linq;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.User
{
    public class UserResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UserResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is UserServiceResponse userServiceResponse &&
                userServiceResponse.Success)
            {
                var data = _mapper.Map<List<UserResponse>>(userServiceResponse.Users);

                data = data.OrderBy(d => d.UserName).ToList();

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status200OK,
                    Messages.SuccessMessage,
                    _mapper.Map<List<UserResponse>>(userServiceResponse.Users));
            }

            return default;
        }

        public Response GetErrorResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is UserServiceResponse userServiceResponse &&
                !userServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (userServiceResponse.UsersNotFound)
                {
                    errorCodes.Add(APIErrorCodes.UsersNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.UsersNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
