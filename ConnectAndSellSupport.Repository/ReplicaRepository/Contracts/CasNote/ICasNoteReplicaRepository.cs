using ConnectAndSellSupport.Repository.Contracts;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasNote
{
    public interface ICasNoteReplicaRepository : IRepository<Domain.ReplicaModels.CasNote>
    {
        Task<Domain.ReplicaModels.CasNote> GetByLeadTransitId(int leadTransitId);
    }
}
