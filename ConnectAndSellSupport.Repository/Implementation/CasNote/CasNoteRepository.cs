using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasNote;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasNote
{
    public class CasNoteRepository : Repository<Domain.Models.CasNote>, ICasNoteRepository
    {
        public CasNoteRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasNote> GetByLeadTransitId(int leadTransitId)
        {
            if (leadTransitId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.LeadTransitId.Equals(leadTransitId));
        }
    }
}
