using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.User;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.User
{
    public interface ILoginService
    {
        Task<LoginServiceResponse> Login(TUser tUser, string passwordEntered);
    }
}
