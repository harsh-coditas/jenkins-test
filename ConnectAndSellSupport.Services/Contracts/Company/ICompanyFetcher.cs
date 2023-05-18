using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Company
{
    public interface ICompanyFetcher
    {
        Task<CompanyServiceResponse> GetCompanies();
    }
}
