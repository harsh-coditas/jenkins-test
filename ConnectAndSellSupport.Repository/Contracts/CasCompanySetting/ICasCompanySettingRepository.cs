using ConnectAndSellSupport.Domain.Models.Custom.Company;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasCompanySetting
{
    public interface ICasCompanySettingRepository : IRepository<Domain.Models.CasCompanySetting>
    {
        Task<Domain.Models.CasCompanySetting> GetByCompanyIdAndKey(int companyId, CompanySettingType key);
    }
}
