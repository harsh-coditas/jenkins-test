using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Company
{
    public interface ICompanySettingsUpdater
    {
        Task<CompanyUpdateServiceResponse> EnableAutoRefreshList(IEnumerable<int> companyIds);
    }
}
