using ConnectAndSellSupport.Domain;
using ConnectAndSellSupport.Repository.Implementation;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasList;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.CasList
{
    public class CasListReplicaRepository : Repository<Domain.ReplicaModels.CasList>, ICasListReplicaRepository
    {
        public CasListReplicaRepository(CASReplicaContext context) : base(context)
        {
        }

        public async Task<Domain.ReplicaModels.CasList> GetById(int id)
        {
            if (id == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.ListId.Equals(id));
        }

        public async Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByIds(IEnumerable<int> listIds)
        {
            if (listIds == default)
            {
                return default;
            }


            return await GetMultiAsync(c =>
                listIds.Contains(c.ListId) &&
                (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyId(int companyId, IEnumerable<int?> userIds)
        {
            if (companyId == default)
            {
                return default;
            }

            return userIds != null ?
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) && userIds.Contains(c.UserId) &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value)) :
                                    await GetMultiAsync(c => c.CompanyId.Equals(companyId) &&
                                                       (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyIdAndAutoRefreshEnabled(int companyId, IEnumerable<int?> userIds)
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

        public async Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyIdAndAutoRefreshDisabled(int companyId, IEnumerable<int?> userIds)
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
