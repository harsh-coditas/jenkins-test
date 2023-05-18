using AutoMapper;
using ConnectAndSellSupport.Domain.Models.Custom.Company;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySetting;
using ConnectAndSellSupport.Repository.Contracts.CasList;
using ConnectAndSellSupport.Services.Contracts.List;
using ConnectAndSellSupport.Services.Models.Response.List;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.List
{
    public class ListFetcher : IListFetcher
    {
        #region Private members
        private readonly ICasListRepository _casListRepository;
        private readonly ICasCompanySettingRepository _casCompanySettingRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ListFetcher(
            ICasListRepository casListRepository,
            ICasCompanySettingRepository casCompanySettingRepository,
            IMapper mapper)
        {
            _casListRepository = casListRepository;
            _casCompanySettingRepository = casCompanySettingRepository;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<ListServiceResponse> GetLists(int? companyId, int?[] userIds)
        {
            var lists = await _casListRepository.GetByCompanyId(companyId, userIds);

            if (!lists?.Any() ?? true)
            {
                return new ListServiceResponse
                {
                    ListsNotFound = true
                };
            }

            return new ListServiceResponse
            {
                Lists = _mapper.Map<List<ListDetails>>(lists),
                Success = true
            };
        }

        public async Task<ListServiceResponse> GetListsForAutoRefresh(int companyId)
        {
            var autoRefreshCompanySetting = await _casCompanySettingRepository.GetByCompanyIdAndKey(companyId, CompanySettingType.EnableAutoRefreshListForCompany);

            var lists = (bool.TryParse(autoRefreshCompanySetting?.SettingValue, out var value) && value)
                 ? await _casListRepository.GetByCompanyIdAndAutoRefreshDisabled(companyId, null)
                 : await _casListRepository.GetByCompanyId(companyId, null);

            if (!lists?.Any() ?? true)
            {
                return new ListServiceResponse
                {
                    ListsNotFound = true
                };
            }

            return new ListServiceResponse
            {
                Lists = _mapper.Map<List<ListDetails>>(lists),
                Success = true
            };
        }

        public async Task<ListServiceResponse> GetListsForAutoRefreshRemoval(int companyId)
        {
            var autoRefreshCompanySetting = await _casCompanySettingRepository.GetByCompanyIdAndKey(companyId, CompanySettingType.EnableAutoRefreshListForCompany);

            if (!bool.TryParse(autoRefreshCompanySetting?.SettingValue, out var value) || !value)
            {
                return new ListServiceResponse
                {
                    ListsNotFound = true
                };
            }

            var lists = await _casListRepository.GetByCompanyIdAndAutoRefreshEnabled(companyId, null);

            return !lists?.Any() ?? true
                ? new ListServiceResponse { ListsNotFound = true }
                : new ListServiceResponse
                {
                    Lists = _mapper.Map<List<ListDetails>>(lists),
                    Success = true
                };
        }
        #endregion
    }
}
