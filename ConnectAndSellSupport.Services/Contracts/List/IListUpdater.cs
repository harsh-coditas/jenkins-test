using ConnectAndSellSupport.Services.Models.Response.List;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.List
{
    public interface IListUpdater
    {
        Task<ListsUpdateServiceResponse> EnableAutoRefresh(IEnumerable<int> listIds);
        Task<ListsUpdateServiceResponse> DisableAutoRefresh(IEnumerable<int> listIds);
    }
}
