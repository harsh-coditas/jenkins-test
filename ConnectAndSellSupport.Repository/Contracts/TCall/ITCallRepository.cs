using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.TCall
{
    public interface ITCallRepository : IRepository<Domain.Models.TCall>
    {
        Task<(Domain.Models.TCall AgentRecord, Domain.Models.TCall PitcherRecord)> GetCallByLeadTransitId(int leadTransitId);
        Task<Domain.Models.TCall> GetAgentCallByLeadTransitId(int leadTransitId);
        Task<Domain.Models.TCall> GetPitcherCallByLeadTransitId(int leadTransitId);
    }
}
