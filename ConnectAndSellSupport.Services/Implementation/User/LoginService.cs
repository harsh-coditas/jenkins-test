using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using ConnectAndSellSupport.Repository.Contracts.CasUser;
using ConnectAndSellSupport.Services.Constants;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Helpers;
using ConnectAndSellSupport.Services.Helpers.Password;
using ConnectAndSellSupport.Services.Models.Response.User;
using System;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.User
{
    public class LoginService : ILoginService
    {
        #region Private members
        private readonly ICasUserRepository _casUserRepository;
        private readonly IPasswordHelper _passwordHelper;
        #endregion

        #region Constructor
        public LoginService(
            ICasUserRepository casUserRepository,
            IPasswordHelper passwordHelper)
        {
            _casUserRepository = casUserRepository;
            _passwordHelper = passwordHelper;
        }
        #endregion

        #region Private methods
        private void LockUser(CasUser casUser)
        {
            if (casUser != null && 
                casUser.IsApproved.HasValue && casUser.IsApproved.Value && 
                !casUser.IsLockedOut)
            {
                casUser.FailedPasswordAttempts++;

                if (casUser.FailedPasswordAttempts >= Constant.PasswordAttemptThreshold)
                {
                    casUser.IsLockedOut = true;
                    casUser.LockedOutOn = DateTime.Now;                    
                }

                _casUserRepository.UpdateAsync(casUser);
            }
        }

        private void HandleUserLogin(
            CasUser casUser, 
            string passwordEntered,
            LoginServiceResponse loginResponse)
        {
            if (casUser == null)
            {
                loginResponse.InvalidUserName = true;
            }
            else if (!casUser.IsApproved.HasValue || !casUser.IsApproved.Value)
            {
                loginResponse.UserNotApproved = true;
            }
            else if (!casUser.IsPasswordReset)
            {
                loginResponse.PasswordMisMatch = true;
            }
            else if (casUser.IsLockedOut)
            {
                loginResponse.UserLockedOut = true;
            }
            else if (!_passwordHelper.ValidatePassword(passwordEntered, casUser.Password))
            {
                LockUser(casUser);
                loginResponse.PasswordMisMatch = true;
            }
        }
        #endregion

        #region Interface implementations
        public async Task<LoginServiceResponse> Login(TUser tUser, string passwordEntered)
        {
            var loginResponse = new LoginServiceResponse();

            if (tUser == null)
            {
                loginResponse.InvalidUserName = true;
                return loginResponse;
            }

            if (!tUser.ExistingUserActivationStatus.Equals((byte)ExistingUserActivationStatus.UserActivated))
            {
                loginResponse.UserInactive = true;
                return loginResponse;
            }

            if (!tUser.PermittedRoles.HasValue || !
                tUser.PermittedRoles.Value.IsInRole(Roles.Administrator, Roles.Engineering))
            {
                loginResponse.UserUnauthorized = true;
                return loginResponse;
            }

            var casUser = await _casUserRepository.GetByUserId(tUser.Id);

            HandleUserLogin(casUser, passwordEntered, loginResponse);
            
            if(!loginResponse.HasError)
            {
                casUser.LastLoggedIn = DateTime.Now;
                casUser.FailedPasswordAttempts = 0;
                casUser.PasswordResetExpiresOn = null;
                casUser.PasswordResetToken = null;

                await _casUserRepository.UpdateAsync(casUser);

                loginResponse.Success = true;
            }           

            return loginResponse;
        }
        #endregion
    }
}
