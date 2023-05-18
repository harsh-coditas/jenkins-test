using ConnectAndSellSupport.Repository.Contracts;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.TCall
{
    public interface ITCallReplicaRepository : IRepository<Domain.ReplicaModels.TCall>
    {
        Task<(Domain.ReplicaModels.TCall AgentRecord, Domain.ReplicaModels.TCall PitcherRecord)> GetCallByLeadTransitId(int leadTransitId);
        Task<Domain.ReplicaModels.TCall> GetAgentCallByLeadTransitId(int leadTransitId);
        Task<Domain.ReplicaModels.TCall> GetPitcherCallByLeadTransitId(int leadTransitId);
    }
}
