using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.API.Models.Payload.PenaltyBox;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
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
    public class PenaltyBoxController : ControllerBase
    {
        #region Private members
        private readonly IPenaltyBoxRemovalService _penaltyBoxRemovalService;
        private readonly IRequestFactory _requestFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<PenaltyBoxController> _logger;
        #endregion

        #region Constructor
        public PenaltyBoxController(
            IPenaltyBoxRemovalService penaltyBoxRemovalService,
            IRequestFactory requestFactory,
            IResponseFactory responseFactory,
            ILogger<PenaltyBoxController> logger)
        {
            _penaltyBoxRemovalService = penaltyBoxRemovalService;
            _requestFactory = requestFactory;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs
        [Route(Routes.EntityRemoval)]
        [HttpPost]
        public async Task<IActionResult> RemovePenaltyBoxEntity([FromBody] RemovePenaltyBoxEntityPayload entityPayload)
        {
            try
            {
                var serviceResponse = await _penaltyBoxRemovalService.RemovePenaltyBoxEntity(
                    _requestFactory.GetRequest(entityPayload) as RemovePenaltyBoxEntityRequest);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to remove penalty box entity - {entityTypeId} - {companyId}", entityPayload.Type, entityPayload.CompanyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }


        [Route(Routes.ImportEntityRemoval)]
        [HttpPost]
        public async Task<IActionResult> RemovePenaltyBoxEntity(int companyId, IFormFile entityPayload)
        {
            try
            {
                entityPayload ??= Request.Form.Files[0];

                var serviceResponse = await _penaltyBoxRemovalService.RemovePenaltyBoxEntity(companyId, entityPayload);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to remove penalty box entities");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}
