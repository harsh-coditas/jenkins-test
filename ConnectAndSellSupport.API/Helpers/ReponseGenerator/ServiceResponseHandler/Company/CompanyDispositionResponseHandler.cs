using AutoMapper;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Models.Response;
using ConnectAndSellSupport.API.Models.Response.Company;
using ConnectAndSellSupport.Services.Models.Response;
using ConnectAndSellSupport.Services.Models.Response.Company;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Company
{
    public class CompanyDispositionResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CompanyDispositionResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is CompanyDispositionServiceResponse companyDispositionServiceResponse &&
                companyDispositionServiceResponse.Success)
            {
                var data = _mapper.Map<List<CompanyDispositionResponse>>(companyDispositionServiceResponse.CompanyDispositions);

                data = data.OrderBy(d => d.SortOrder).ToList();

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
            if (serviceResponse is CompanyDispositionServiceResponse companyDispositionServiceResponse &&
                !companyDispositionServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (companyDispositionServiceResponse.DispositionsNotFound)
                {
                    errorCodes.Add(APIErrorCodes.DispositionsNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.DispositionsNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
