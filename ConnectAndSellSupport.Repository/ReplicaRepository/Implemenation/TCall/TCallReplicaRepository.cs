using ConnectAndSellSupport.Domain;
using ConnectAndSellSupport.Domain.Models.Custom.Call;
using ConnectAndSellSupport.Repository.Implementation;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.TCall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.TCall
{
    public class TCallReplicaRepository : Repository<Domain.ReplicaModels.TCall>, ITCallReplicaRepository
    {
        public TCallReplicaRepository(CASReplicaContext context) : base(context)
        {
        }

        public async Task<(Domain.ReplicaModels.TCall AgentRecord, Domain.ReplicaModels.TCall PitcherRecord)> GetCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            var callRecords = await GetMultiAsync(c => c.LeadTransitId.Equals(leadTransitId) && (!c.IsDeleted));

            var recordDict = callRecords.GroupBy(c => c.CallType, c => c).ToDictionary(g => g.Key, g => g.Select(x => x));
            recordDict.TryGetValue((int)CallType.Agent, out var agentRecords);
            recordDict.TryGetValue((int)CallType.Pitcher, out var pitcherRecords);

            return (agentRecords?.FirstOrDefault(), pitcherRecords?.FirstOrDefault());
        }

        public async Task<Domain.ReplicaModels.TCall> GetAgentCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId) && c.CallType.Equals((byte)CallType.Agent) && !c.IsDeleted);
        }

        public async Task<Domain.ReplicaModels.TCall> GetPitcherCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId) && c.CallType.Equals((byte)CallType.Pitcher) && !c.IsDeleted);
        }
    }
}
