using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasListContact;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasListContact
{
    public class CasListContactRepository : Repository<Domain.Models.CasListContact>, ICasListContactRepository
    {
        public CasListContactRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasListContact> GetByContactId(int contactId)
        {
            if (contactId == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.ContactId.Equals(contactId));
        }

        public async Task<IEnumerable<Domain.Models.CasListContact>> GetByListIds(HashSet<int> listIds)
        {
            if (listIds == default)
            {
                return default;
            }

            return await GetMultiAsync(c => listIds.Contains(c.ListId));
        }
    }
}
