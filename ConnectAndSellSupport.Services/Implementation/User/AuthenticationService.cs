using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Helpers;
using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.User
{
    public class AuthenticationService : IAuthenticationService
    {
        #region Private members
        private readonly ITokenHelper _tokenHelper;
        private readonly ITUserRepository _tUserRepository;
        private readonly ILoginService _loginService;
        private readonly ILogger<AuthenticationService> _logger;
        #endregion

        #region Constructor
        public AuthenticationService(
            ITokenHelper tokenHelper,
            ITUserRepository tUserRepository,
            ILoginService loginService,
            ILogger<AuthenticationService> logger)
        {
            _tokenHelper = tokenHelper;
            _tUserRepository = tUserRepository;
            _loginService = loginService;
            _logger = logger;
        }
        #endregion

        #region Interface implementations
        public async Task<LoginServiceResponse> GetLoginResponse(string userName, string password, string jwtSecret)
        {
            var tUser = await _tUserRepository.GetByUsername(userName);

            var loginResponse = await _loginService.Login(tUser, password);

            if (loginResponse.Success)
            {
                loginResponse.Success = true;
                loginResponse.AccessToken = _tokenHelper.GenerateToken(
                    tUser.Id.ToString(), tUser.UserName, tUser.LoginEmailId, tUser.PermittedRoles?.ToString(), jwtSecret);
                loginResponse.RefreshToken = _tokenHelper.GenerateRefreshToken();
                loginResponse.UserName = tUser.UserName;
                loginResponse.Email = tUser.LoginEmailId;

                _logger.LogInformation("User {userName} has logged into the system", tUser.UserName);
            }

            return loginResponse;
        }
        #endregion
    }
}
