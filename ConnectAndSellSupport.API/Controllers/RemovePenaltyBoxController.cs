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
    public class RemovePenaltyBoxController : Controller
    {

        // [Authorize(Policy = Policies.AdminAndEngineering)]
        private readonly IPenaltyBoxUpdater _PenaltyBoxupdater;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<RemovePenaltyBoxController> _logger;
        private readonly IRequestFactory _requestFactory;
        private readonly IPenaltyBoxFetcher _penaltyBoxFetcher;
        public RemovePenaltyBoxController(
            IPenaltyBoxUpdater penaltyBoxUpdater,
            IResponseFactory responseFactory,
            ILogger<RemovePenaltyBoxController> logger,
             IRequestFactory requestFactory,
            IPenaltyBoxFetcher penaltyBoxFetcher
            )
        {
            _PenaltyBoxupdater=penaltyBoxUpdater;
            _penaltyBoxFetcher = penaltyBoxFetcher;
            _responseFactory=responseFactory;
            _logger = logger;
            _requestFactory = requestFactory; ;

        }

        [Route(Routes.penaltyBoxUpdate)]
        [HttpPost]
        public async Task<IActionResult> PenaltyBoxRemoval([FromBody] RemovePenaltyBoxEntity entityPayload)
        {
            try
            {
                var serviceResponce = await _PenaltyBoxupdater.UpdateEntity(
                    _requestFactory.GetRequest(entityPayload) as PenaltyBoxServiceRequest);
                return _responseFactory.GetResponse(serviceResponce);

            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to remove penalty box entity - {entityTypeId} - {companyId}", entityPayload.StatusType, entityPayload.CompanyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
            return null;
        }
        [Route(Routes.GetPenaltyBoxDetails)]
        [HttpGet]
        public async Task<IActionResult> GetPenaltyBoxDetailsByPhoneNumber(string phoneNumber)
        {
            try
            {
                if(phoneNumber==null)
                {
                    return null;
                }
                var getPenaltyBoxDetails= await _penaltyBoxFetcher.GetPenaltyBoxByNumber(phoneNumber);
                return _responseFactory.GetResponse(getPenaltyBoxDetails);
            }
            catch(Exception ex)
            {
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
            return null;
        }
        [Route(Routes.RemovePhoneNumberFromPenaltyBox)]
        [HttpPatch]
        public async Task<IActionResult> RemovePenaltyBoxPhoneNumber([FromBody] RemovePenaltyBoxPhoneNumber phoneNumber)
        {
            try
            {
                if(phoneNumber == null)
                {
                    return null; 
                }
                var serviceResponce = await _PenaltyBoxupdater.RemovePhoneNumber(
                     _requestFactory.GetRequest(phoneNumber) as RemovePenaltyBoxbyPhoneNumberRequest);
                return _responseFactory.GetResponse(serviceResponce);
                
            }
            catch( Exception ex)
            {
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
            return null;
        }
        [Route(Routes.RemovePerticularDataFromPenaltyBox)]
        [HttpPatch]
        public async Task<IActionResult> RemoveSelectedDataFromPenaltyBox([FromBody] RemovePenaltyBoxById removePenaltyBoxById)
        {
            try
            {
                if(removePenaltyBoxById==null)
                {
                    return null;
                }
                var serviceRequest = await _PenaltyBoxupdater.RemovePenaltyBoxById(
                     _requestFactory.GetRequest(removePenaltyBoxById) as RemovePenaltyBoxByIDRequest);
                return _responseFactory.GetResponse(serviceRequest);
            }
            catch (Exception ex)
            {
                return _responseFactory.GetErrorResponse(
                   StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);

            }
            return null;
        }

    }
}
