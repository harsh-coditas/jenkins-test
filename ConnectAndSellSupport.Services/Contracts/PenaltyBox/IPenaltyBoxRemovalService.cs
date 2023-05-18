using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox
{
    public interface IPenaltyBoxRemovalService
    {
        Task<RemovePenaltyBoxEntityServiceResponse> RemovePenaltyBoxEntity(RemovePenaltyBoxEntityRequest entityRequest);
        Task<RemovePenaltyBoxEntityBulkServiceResponse> RemovePenaltyBoxEntity(int companyId, IFormFile entityRequest);
    }
}
