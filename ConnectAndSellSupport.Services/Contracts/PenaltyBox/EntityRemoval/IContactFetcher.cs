using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval
{
    public interface IContactFetcher
    {
        Task<List<CasContact>> FetchContacts(RemovePenaltyBoxEntityRequest entityRequest);
        Task<List<CasContact>> FetchContacts(List<RemovePenaltyBoxCsvRequest> entityRequests);
    }
}
