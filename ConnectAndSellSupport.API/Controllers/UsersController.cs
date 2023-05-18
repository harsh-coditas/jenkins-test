using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Models;
using ConnectAndSellSupport.API.Models.Payload.User;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.API.Controllers
{
    [Route(Routes.GenericControllerV1)]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Private members
        private readonly AppSettings _appSettings;
        private readonly IAuthenticationService _authenticationService;
        private readonly ITokenHelper _tokenHelper; 
        private readonly IUserFetcher _userFetcher;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<UsersController> _logger;
        #endregion

        #region Constructor
        public UsersController(
            IOptions<AppSettings> appSettings,
            IAuthenticationService authenticationService,
            ITokenHelper tokenHelper,
            IUserFetcher userFetcher,
            IResponseFactory responseFactory,
            ILogger<UsersController> logger)
        {
            _appSettings = appSettings.Value;
            _authenticationService = authenticationService;
            _tokenHelper = tokenHelper;
            _userFetcher = userFetcher;
            _responseFactory = responseFactory;
            _logger = logger;
        }
        #endregion

        #region APIs
        [Route(Routes.SignIn)]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn([FromBody] UserLoginPayload user)
        {
            try
            {
                var serviceResponse = await _authenticationService.GetLoginResponse(
                    user.Username, user.Password, _appSettings.JWTSecretKey);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to log user - {username}", user.Username);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.RefreshToken)]
        [HttpPost]
        public IActionResult RefreshToken([FromBody] RefreshTokenPayload refreshTokenPayload)
        {
            try
            {
                var refreshTokenResponse = _tokenHelper.GetRefreshTokenResponse(
                    refreshTokenPayload.AccessToken, _appSettings.JWTSecretKey);

                return _responseFactory.GetResponse(refreshTokenResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to refresh token - {accessToken}", refreshTokenPayload.AccessToken);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }

        [Route(Routes.UsersByCompanyId)]
        [HttpGet]
        [Authorize(Policy = Policies.AdminAndEngineering)]
        public async Task<IActionResult> GetUsers(int companyId)
        {
            try
            {
                var serviceResponse = await _userFetcher.GetUsers(companyId);

                return _responseFactory.GetResponse(serviceResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve users - {companyId}", companyId);
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
        #endregion
    }
}
