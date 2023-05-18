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
    public class CompanyResponseHandler : IServiceResponseHandler
    {
        #region Private members
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CompanyResponseHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public Response GetSucessResponse(BaseServiceResponse serviceResponse)
        {
            if (serviceResponse is CompanyServiceResponse companyServiceResponse &&
                companyServiceResponse.Success)
            {
                var data = _mapper.Map<List<CompanyResponse>>(companyServiceResponse.Companies);

                data = data.OrderBy(d => d.CompanyName).ToList();

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
            if (serviceResponse is CompanyServiceResponse companyServiceResponse &&
                !companyServiceResponse.Success)
            {
                var errorCodes = new List<string>();
                if (companyServiceResponse.CompaniesNotFound)
                {
                    errorCodes.Add(APIErrorCodes.CompaniesNotFound);
                }

                return new Response(
                    Versions.DefaultVersion,
                    StatusCodes.Status404NotFound,
                    Messages.CompaniesNotFound,
                    BaseErrorResponseCreator.GetBaseErrorResponse(errorCodes));
            }

            return default;
        }
        #endregion
    }
}
