using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval
{
    public interface INumberFetcher
    {
        Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> FetchFormattedNumbersFromContacts(RemovePenaltyBoxEntityRequest entityRequest);
        Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> FetchFormattedNumbersFromContacts(List<RemovePenaltyBoxCsvRequest> entityRequests);
    }
}