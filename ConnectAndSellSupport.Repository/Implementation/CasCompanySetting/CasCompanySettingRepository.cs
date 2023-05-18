using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.Company;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySetting;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasCompanySetting
{
    public class CasCompanySettingRepository : Repository<Domain.Models.CasCompanySetting>, ICasCompanySettingRepository
    {
        public CasCompanySettingRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasCompanySetting> GetByCompanyIdAndKey(int companyId, CompanySettingType key)
        {
            if (companyId == default || key.Equals(CompanySettingType.Default))
            {
                return default;
            }

            return await GetSingleAsync(c => c.CompanyId.Equals(companyId) && c.SettingKey.Equals(key.ToString()));
        }
    }
}
