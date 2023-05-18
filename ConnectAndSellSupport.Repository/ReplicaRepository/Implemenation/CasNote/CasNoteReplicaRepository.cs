using ConnectAndSellSupport.Domain;
using ConnectAndSellSupport.Repository.Implementation;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.CasNote
{
    public class CasNoteReplicaRepository : Repository<Domain.ReplicaModels.CasNote>, ICasNoteReplicaRepository
    {
        public CasNoteReplicaRepository(CASReplicaContext context) : base(context)
        {
        }

        public async Task<Domain.ReplicaModels.CasNote> GetByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId));
        }
    }
}
