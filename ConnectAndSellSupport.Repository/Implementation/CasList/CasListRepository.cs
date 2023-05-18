using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasList;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasList
{
    public class CasListRepository : Repository<Domain.Models.CasList>, ICasListRepository
    {
        public CasListRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasList> GetById(int id)
        {
            if (id == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.ListId.Equals(id));
        }

        public async Task<IEnumerable<Domain.Models.CasList>> GetByIds(IEnumerable<int> listIds)
        {
            if (listIds == default)
            {
                return default;
            }


            return await GetMultiAsync(c =>
                listIds.Contains(c.ListId) &&
                (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.Models.CasList>> GetByCompanyId(int? companyId, IEnumerable<int?> userIds)
        {
            if (userIds == default)
            {
                return default;
            }

            return userIds != null ?
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) || userIds.Contains(c.UserId) &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value)) :
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.Models.CasList>> GetByCompanyIdAndAutoRefreshEnabled(int companyId, IEnumerable<int?> userIds)
        {
            if (companyId == default)
            {
                return default;
            }

            return userIds != null ?
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) && userIds.Contains(c.UserId) && c.AutoRefreshEnabled &&
                                                        (!c.IsDeleted.HasValue || !c.IsDeleted.Value)) :
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) && c.AutoRefreshEnabled &&
                                                        (!c.IsDeleted.HasValue || !c.IsDeleted.Value));


        }

        public async Task<IEnumerable<Domain.Models.CasList>> GetByCompanyIdAndAutoRefreshDisabled(int companyId, IEnumerable<int?> userIds)
        {
            if (companyId == default)
            {
                return default;
            }

            return userIds != null ?
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) && userIds.Contains(c.UserId) && !c.AutoRefreshEnabled &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value)) :
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) && !c.AutoRefreshEnabled &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }
    }
}
