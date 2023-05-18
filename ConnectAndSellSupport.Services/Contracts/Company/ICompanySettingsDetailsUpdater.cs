using ConnectAndSellSupport.Domain.Models.Custom.Company;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.Company
{
    public interface ICompanySettingsDetailsUpdater
    {
        Task AddSettingsUpdate(int companyId, CompanySettingType key, string currentValue, string modifiedValue);
    }
}
