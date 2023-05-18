using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.Services.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator
{
    public class ResponseFactory : ControllerBase, IResponseFactory
    {
        #region Private members
        private readonly ServiceReponseHandlerResolver _serviceReponseHandlerResolver;
        #endregion

        #region Constructor
        public ResponseFactory(ServiceReponseHandlerResolver serviceReponseHandlerResolver)
        {
            _serviceReponseHandlerResolver = serviceReponseHandlerResolver;
        }
        #endregion

        #region Private methods
        private IActionResult HandleResponse(Response response)
        {
            return response?.StatusCode switch
            {
                StatusCodes.Status200OK => Ok(response),
                StatusCodes.Status400BadRequest => BadRequest(response),
                StatusCodes.Status401Unauthorized => Unauthorized(response),
                StatusCodes.Status404NotFound => NotFound(response),
                _ => StatusCode(response.StatusCode, response)
            };
        }
        #endregion

        #region Interface implementations
        public IActionResult GetResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse == null)
            {
                return GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }

            var serviceResponseHandler = _serviceReponseHandlerResolver(serviceResponse);

            if (serviceResponseHandler == null)
            {
                return GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }

            var response = (serviceResponse.Success)
                ? serviceResponseHandler.GetSucessResponse(serviceResponse)
                : serviceResponseHandler.GetErrorResponse(serviceResponse);

            return HandleResponse(response);
        }

        public IActionResult GetErrorResponse(int statusCode, params string[] errorCodes)
        {
            return HandleResponse(
                new Response(
                    Versions.DefaultVersion,
                    statusCode,
                    Messages.InternalServerException,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes.ToList())));
        }
        #endregion
    }
}
