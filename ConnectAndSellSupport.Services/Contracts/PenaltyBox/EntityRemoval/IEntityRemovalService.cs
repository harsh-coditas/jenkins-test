using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval
{
    public delegate IEntityRemovalService EntityRemovalServiceResolver(PenaltyBoxEntityType entityType);

    public interface IEntityRemovalService
    {
        Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(RemovePenaltyBoxEntityRequest entityRequest);
        Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(int companyId, List<RemovePenaltyBoxCsvRequest> entityRequests);
    }
}
