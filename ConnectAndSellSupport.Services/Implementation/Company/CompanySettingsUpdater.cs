using ConnectAndSellSupport.Domain.Models.Custom.Company;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySetting;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using ConnectAndSellSupport.Services.Models.Response.Company;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Company
{
    public class CompanySettingsUpdater : ICompanySettingsUpdater
    {
        #region Private members
        private readonly ICasCompanySettingRepository _casCompanySettingRepository;
        private readonly ICompanySettingsDetailsUpdater _companySettingsDetailsUpdater;
        private readonly IUserFetcher _userFetcher;
        #endregion

        #region Constructor
        public CompanySettingsUpdater(
            ICasCompanySettingRepository casCompanySettingRepository,
            ICompanySettingsDetailsUpdater companySettingsDetailsUpdater,
            IUserFetcher userFetcher)
        {
            _casCompanySettingRepository = casCompanySettingRepository;
            _companySettingsDetailsUpdater = companySettingsDetailsUpdater;
            _userFetcher = userFetcher;
        }
        #endregion

        #region Interface implementations
        public async Task<CompanyUpdateServiceResponse> EnableAutoRefreshList(IEnumerable<int> companyIds)
        {
            var (_, username) = await _userFetcher.GetLoggedInUser();
            var currentTime = TimeZoneHelper.GetPstTime();

            foreach (var companyId in companyIds.Distinct())
            {
                var companySetting = await _casCompanySettingRepository.GetByCompanyIdAndKey(companyId, CompanySettingType.EnableAutoRefreshListForCompany);

                if (companySetting == default)
                {
                    await _casCompanySettingRepository.AddAsync(
                        new Domain.Models.CasCompanySetting
                        {
                            CompanyId = companyId,
                            SettingKey = CompanySettingType.EnableAutoRefreshListForCompany.ToString(),
                            SettingValue = bool.TrueString,
                            LastModUser = username,
                            LastModDate = currentTime
                        });

                    await _companySettingsDetailsUpdater.AddSettingsUpdate(companyId, CompanySettingType.EnableAutoRefreshListForCompany, bool.FalseString, bool.TrueString);
                }
                else if (!bool.TryParse(companySetting.SettingValue, out bool value) || !value)
                {
                    companySetting.SettingValue = bool.TrueString;
                    companySetting.LastModUser = username;
                    companySetting.LastModDate = currentTime;

                    await _casCompanySettingRepository.UpdateAsync(companySetting);

                    await _companySettingsDetailsUpdater.AddSettingsUpdate(companyId, CompanySettingType.EnableAutoRefreshListForCompany, value.ToString(), bool.TrueString);
                }
            }

            return new CompanyUpdateServiceResponse { Success = true };
        }
        #endregion
    }
}
