using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.List;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.List;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.List
{
    public class ListResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ListResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is ListServiceResponse listServiceResponse &&
                listServiceResponse.Success)
            {
                var data = _mapper.Map<List<ListResponse>>(listServiceResponse.Lists);

                data = data.OrderBy(d => d.Name).ToList();

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
            if (serviceResponse is ListServiceResponse listServiceResponse &&
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
