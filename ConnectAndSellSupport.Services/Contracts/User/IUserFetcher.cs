using ConnectAndSellSupport.Services.Models.Response.User;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.User
{
    public interface IUserFetcher
    {
        Task<UserServiceResponse> GetUsers(int companyId);
        Task<(int UserId, string Username)> GetLoggedInUser();
    }
}
