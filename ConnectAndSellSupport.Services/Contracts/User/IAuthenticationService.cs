using ConnectAndSellSupport.Services.Models.Response.User;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.User
{
    public interface IAuthenticationService
    {
        Task<LoginServiceResponse> GetLoginResponse(string userName, string password, string jwtSecret);
    }
}
