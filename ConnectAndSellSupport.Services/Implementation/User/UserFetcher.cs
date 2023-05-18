using AutoMapper;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.User
{
    public class UserFetcher : IUserFetcher
    {
        #region Private members
        private readonly ITUserRepository _tUserRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UserFetcher(
            ITUserRepository tUserRepository,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            _tUserRepository = tUserRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<UserServiceResponse> GetUsers(int companyId)
        {
            var users = await _tUserRepository.GetByCompanyId(companyId);

            if (!users?.Any() ?? true)
            {
                return new UserServiceResponse
                {
                    UsersNotFound = true
                };
            }

            return new UserServiceResponse
            {
                Users = _mapper.Map<List<UserDetails>>(users),
                Success = true
            };
        }

        public Task<(int, string)> GetLoggedInUser()
        {
            var user = _httpContextAccessor.HttpContext.User;

            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            _ = int.TryParse(userIdClaim, out int userId);

            var username = user.FindFirst(ClaimTypes.Name)?.Value;

            return Task.FromResult((userId, username));
        }
        #endregion
    }
}
