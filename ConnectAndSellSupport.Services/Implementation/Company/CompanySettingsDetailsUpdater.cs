using ConnectAndSellSupport.Domain.Models.Custom.Company;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySettingDetail;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Company
{
    public class CompanySettingsDetailsUpdater : ICompanySettingsDetailsUpdater
    {
        #region Private members
        private readonly ICasCompanySettingDetailRepository _casCompanySettingDetailRepository;
        private readonly IUserFetcher _userFetcher;
        #endregion

        #region Constructor
        public CompanySettingsDetailsUpdater(
            ICasCompanySettingDetailRepository casCompanySettingDetailRepository,
            IUserFetcher userFetcher)
        {
            _casCompanySettingDetailRepository = casCompanySettingDetailRepository;
            _userFetcher = userFetcher;
        }
        #endregion

        #region Interface implementations
        public async Task AddSettingsUpdate(int companyId, CompanySettingType key, string currentValue, string modifiedValue)
        {
            var (_, username) = await _userFetcher.GetLoggedInUser();
            var currentTime = TimeZoneHelper.GetPstTime();

            await _casCompanySettingDetailRepository.AddAsync(
                new Domain.Models.CasCompanySettingDetail
                {
                    UserName = username,
                    ModifiedDate = currentTime,
                    SettingKey = key.ToString(),
                    PreviousSettingValue = currentValue,
                    ModifiedSettingValue = modifiedValue,
                    CompanyId = companyId
                });
        }
        #endregion
    }
}
