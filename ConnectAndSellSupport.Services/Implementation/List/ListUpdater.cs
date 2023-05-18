using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasList;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Contracts.List;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using ConnectAndSellSupport.Services.Models.Response.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.List
{
    public class ListUpdater : IListUpdater
    {
        #region Private members
        private readonly ICasListRepository _casListRepository;
        private readonly ICompanySettingsUpdater _companySettingsUpdater;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ListUpdater(
            ICasListRepository casListRepository,
            ICompanySettingsUpdater companySettingsUpdater,
            IMapper mapper)
        {
            _casListRepository = casListRepository;
            _companySettingsUpdater = companySettingsUpdater;
            _mapper = mapper;
        }
        #endregion

        #region Interface implementations
        public async Task<ListsUpdateServiceResponse> EnableAutoRefresh(IEnumerable<int> listIds)
        {
            var lists = await _casListRepository.GetByIds(listIds);

            if (lists.IsNullOrEmpty())
            {
                return new ListsUpdateServiceResponse
                {
                    ListsNotFound = true
                };
            }

            var companyIds = lists.Select(l => l.CompanyId).OfType<int>();

            _ = await _companySettingsUpdater.EnableAutoRefreshList(companyIds);

            var filteredLists = new List<CasList>();
            foreach (var list in lists)
            {
                if (list.AutoRefreshEnabled)
                {
                    continue;
                }

                list.AutoRefreshEnabled = true;
                list.LastRefreshDateTime = DateTime.Now;
                list.Updatedate = TimeZoneHelper.GetPstTime();
                filteredLists.Add(list);
            }            

            await _casListRepository.UpdateMultiAsync(filteredLists);

            return new ListsUpdateServiceResponse
            {
                Success = true
            };
        }

        public async Task<ListsUpdateServiceResponse> DisableAutoRefresh(IEnumerable<int> listIds)
        {
            var lists = await _casListRepository.GetByIds(listIds);

            if (lists.IsNullOrEmpty())
            {
                return new ListsUpdateServiceResponse
                {
                    ListsNotFound = true
                };
            }

            var filteredLists = new List<CasList>();
            foreach (var list in lists)
            {
                if (!list.AutoRefreshEnabled)
                {
                    continue;
                }

                list.AutoRefreshEnabled = false;
                list.LastRefreshDateTime = null;
                list.Updatedate = TimeZoneHelper.GetPstTime();
                filteredLists.Add(list);
            }

            await _casListRepository.UpdateMultiAsync(filteredLists);

            return new ListsUpdateServiceResponse
            {
                Success = true
            };
        }
        #endregion
    }
}
