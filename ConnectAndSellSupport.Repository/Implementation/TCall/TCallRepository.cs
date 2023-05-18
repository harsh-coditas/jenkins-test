using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.Call;
using ConnectAndSellSupport.Repository.Contracts.TCall;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.TCall
{
    public class TCallRepository : Repository<Domain.Models.TCall>, ITCallRepository
    {
        public TCallRepository(CASContext context) : base(context)
        {
        }

        public async Task<(Domain.Models.TCall AgentRecord, Domain.Models.TCall PitcherRecord)> GetCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            var callRecords = await GetMultiAsync(c => c.LeadTransitId.Equals(leadTransitId) && (!c.IsDeleted.HasValue || !c.IsDeleted.Value));

            var recordDict = callRecords.GroupBy(c => c.CallType, c => c).ToDictionary(g => g.Key, g => g.Select(x => x));
            recordDict.TryGetValue((int)CallType.Agent, out var agentRecords);
            recordDict.TryGetValue((int)CallType.Pitcher, out var pitcherRecords);

            return (agentRecords?.FirstOrDefault(), pitcherRecords?.FirstOrDefault());
        }

        public async Task<Domain.Models.TCall> GetAgentCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId) && c.CallType.Equals((byte)CallType.Agent) && (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }

        public async Task<Domain.Models.TCall> GetPitcherCallByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId) && c.CallType.Equals((byte)CallType.Pitcher) && (!c.IsDeleted.HasValue || !c.IsDeleted.Value));
        }
    }
}
