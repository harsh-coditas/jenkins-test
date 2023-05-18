using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.Services.Contracts.List;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Controllers
{
    [Route(Routes.GenericControllerV1)]
    [ApiController]
    [Authorize(Policy = Policies.AdminAndEngineering)]
    public class ListsController : ControllerBase
    {
        #region Private members
        private readonly IListFetcher _listFetcher;
        private readonly IListUpdater _listUpdater;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<ListsController> _logger;
        #endregion

        #region Constructor
        public ListsController(
            IListFetcher listFetcher,
            IListUpdater listUpdater,
            IResponseFactory responseFactory,
            ILogger<ListsController> logger)
        {
            _listFetcher = listFetcher;
            _listUpdater = listUpdater;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs
        [Route(Routes.ListsByCompanyId)]
        [HttpPost]
        public async Task<IActionResult> GetLists( [FromBody] int?[] userIds)
        {
            try
            {
                var serviceResponse = await _listFetcher.GetLists(null, userIds);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve company lists - {companyId}");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        
        [Route(Routes.ListsForAutoRefreshByCompanyId)]
        [HttpGet]

        public async Task<IActionResult> GetListsForAutoRefresh(int companyId)
        {
            try
            {
                var serviceResponse = await _listFetcher.GetListsForAutoRefresh(companyId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve company lists to add to nightly refresh job- {companyId} - {userIds}", companyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        
        [Route(Routes.ListsForAutoRefreshRemovalByCompanyId)]
        [HttpGet]
        public async Task<IActionResult> GetListsForAutoRefreshRemoval(int companyId)
        {
            try
            {
                var serviceResponse = await _listFetcher.GetListsForAutoRefreshRemoval(companyId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve company lists present in nightly refresh job- {companyId} - {userIds}", companyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.EnableAutoRefresh)]
        [HttpPost]
        public async Task<IActionResult> EnableAutoRefresh([FromBody] int[] listIds)
        {
            try
            {
                var serviceResponse = await _listUpdater.EnableAutoRefresh(listIds.ToList());

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to add lists to nightly refresh job");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.DisableAutoRefresh)]
        [HttpPost]
        public async Task<IActionResult> DisableAutoRefresh([FromBody] int[] listIds)
        {
            try
            {
                var serviceResponse = await _listUpdater.DisableAutoRefresh(listIds.ToList());

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to remove lists from nightly refresh job");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}
