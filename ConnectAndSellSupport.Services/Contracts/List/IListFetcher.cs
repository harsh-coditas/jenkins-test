using ConnectAndSellSupport.Services.Models.Response.List;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.List
{
    public interface IListFetcher
    {
        Task<ListServiceResponse> GetLists(int? companyId, int?[] userIds);
        Task<ListServiceResponse> GetListsForAutoRefresh(int companyId);
        Task<ListServiceResponse> GetListsForAutoRefreshRemoval(int companyId);
    }
}
