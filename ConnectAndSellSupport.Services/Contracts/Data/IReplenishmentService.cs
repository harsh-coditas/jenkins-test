using ConnectAndSellSupport.Services.Models.Request.Data;
using ConnectAndSellSupport.Services.Models.Response.Data;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Data
{
    public interface IReplenishmentService
    {
        public Task<ReplenishmentServiceResponse> GetReplenishmentEntity(GetReplenishmentRequest entityRequest);
    }
}
