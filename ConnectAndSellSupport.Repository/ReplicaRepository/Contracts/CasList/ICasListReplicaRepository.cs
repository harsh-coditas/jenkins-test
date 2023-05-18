using ConnectAndSellSupport.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasList
{
    public interface ICasListReplicaRepository : IRepository<Domain.ReplicaModels.CasList>
    {
        Task<Domain.ReplicaModels.CasList> GetById(int id);
        Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByIds(IEnumerable<int> listIds);
        Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyId(int companyId, IEnumerable<int?> userIds);
        Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyIdAndAutoRefreshEnabled(int companyId, IEnumerable<int?> userIds);
        Task<IEnumerable<Domain.ReplicaModels.CasList>> GetByCompanyIdAndAutoRefreshDisabled(int companyId, IEnumerable<int?> userIds);
    }
}
