using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.Services.Contracts.Data;
using ConnectAndSellSupport.Services.Models.Request.Data;
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
    public class DataController : ControllerBase
    {
        #region Private members
        private readonly IReplenishmentService _replenishmentService;
        private readonly IRequestFactory _requestFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<DataController> _logger;
        #endregion

        #region Constructor
        public DataController(
            IReplenishmentService replenishmentService,
            IRequestFactory requestFactory,
            IResponseFactory responseFactory,
            ILogger<DataController> logger)
        {
            _replenishmentService = replenishmentService;
            _requestFactory = requestFactory;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs

        #region ReplenishmentData
        [Route(Routes.ReplenishmentData)]
        [HttpPost]
        public async Task<IActionResult> GetReplenishmentEntityAsync([FromBody] GetReplenishmentRequest entityPayload)
        {
            try
            {
                var serviceResponse = await _replenishmentService.GetReplenishmentEntity(entityPayload);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to get the replenishment entity - {CompanyName}", entityPayload.CompanyName);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion

        #endregion
    }
}
