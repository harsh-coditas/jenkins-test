using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.API.Models.Payload.Call;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Models.Request.Call;
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
    public class CallsController : ControllerBase
    {
        #region Private members
        private readonly ICallRecordFetcher _callRecordFetcher;
        private readonly ICallRecordUpdater _callRecordUpdater;
        private readonly IRequestFactory _requestFactory;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<CallsController> _logger;
        #endregion

        #region Constructor
        public CallsController(
            ICallRecordFetcher callRecordFetcher,
            ICallRecordUpdater callRecordUpdater,
            IRequestFactory requestFactory,
            IResponseFactory responseFactory,
            ILogger<CallsController> logger)
        {
            _callRecordFetcher = callRecordFetcher;
            _callRecordUpdater = callRecordUpdater;
            _requestFactory = requestFactory;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs
        [Route(Routes.AgentCallRecord)]
        [HttpGet]
        public async Task<IActionResult> GetAgentCallRecord(int leadTransitId)
        {
            try
            {
                var serviceResponse = await _callRecordFetcher.GetAgentCallRecord(leadTransitId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve call record - {leadTransitId}", leadTransitId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.PitcherCallRecord)]
        [HttpGet]
        public async Task<IActionResult> GetPitcherConversationRecord(int leadTransitId)
        {
            try
            {
                var serviceResponse = await _callRecordFetcher.GetPitcherCallRecord(leadTransitId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve call record - {leadTransitId}", leadTransitId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.AddPitcherCallRecord)]
        [HttpPost]
        public async Task<IActionResult> AddCallRecord(int leadTransitId, [FromBody] AddCallRecordPayload callRecordPayload)
        {
            try
            {
                var serviceResponse = await _callRecordUpdater.AddOrUpdatePitcherCallRecord(
                    leadTransitId, _requestFactory.GetRequest(callRecordPayload) as CallRecordServiceRequest);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve call record - {leadTransitId}", leadTransitId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.UpdatePitcherCallRecord)]
        [HttpPost]
        public async Task<IActionResult> UpdateCallRecord(int leadTransitId, [FromBody] UpdateCallRecordPayload callRecordPayload)
        {
            try
            {
                var serviceResponse = await _callRecordUpdater.AddOrUpdatePitcherCallRecord(
                    leadTransitId, _requestFactory.GetRequest(callRecordPayload) as CallRecordServiceRequest);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve call record - {leadTransitId}", leadTransitId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}