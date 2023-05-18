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
    public class CompanyConfigurationsController : ControllerBase
    {
        #region Private members
        private readonly ICompanyConfigurationFetcher _companyConfigurationFetcher;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<CompanyConfigurationsController> _logger;
        #endregion

        #region Constructor
        public CompanyConfigurationsController(
            ICompanyConfigurationFetcher companyConfigurationFetcher,
            IResponseFactory responseFactory,
            ILogger<CompanyConfigurationsController> logger)
        {
            _companyConfigurationFetcher = companyConfigurationFetcher;
            _responseFactory = responseFactory;
           _logger = logger;
        }
        #endregion

        #region APIs
        [Route(Routes.DispositionsByCompanyId)]
        [HttpGet]
        public async Task<IActionResult> GetCompanyDisposition(int companyId)
        {
            try
            {
                var serviceResponse = await _companyConfigurationFetcher.GetCompanyDispositions(companyId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve company dispositions - {companyId}", companyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}
