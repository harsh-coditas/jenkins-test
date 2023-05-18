using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.Services.Contracts.Company;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Controllers
{
    [Route(Routes.GenericControllerV1)]
    [ApiController]
    [Authorize(Policy = Policies.AdminAndEngineering)]
    public class CompaniesController : ControllerBase
    {
        #region Private members
        private readonly ICompanyFetcher _companyFetcher;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<CompaniesController> _logger;
        #endregion

        #region Constructor
        public CompaniesController(
            ICompanyFetcher companyFetcher,
            IResponseFactory responseFactory,
            ILogger<CompaniesController> logger)
        {
            _companyFetcher = companyFetcher;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var serviceResponse = await _companyFetcher.GetCompanies();

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve companies");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}
