using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Company
{
    public interface ICompanyConfigurationFetcher
    {
        Task<CompanyDispositionServiceResponse> GetCompanyDispositions(int companyId);
    }
}
