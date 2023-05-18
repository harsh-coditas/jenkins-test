using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasContact;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasContact
{
    public class CasContactRepository : Repository<Domain.Models.CasContact>, ICasContactRepository
    {
        public CasContactRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasContact> GetById(int id)
        {
            if (id == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.ContactId.Equals(id));
        }

        public async Task<IEnumerable<Domain.Models.CasContact>> GetByIds(HashSet<int> ids)
        {
            if (ids == default)
            {
                return default;
            }

            return await GetMultiAsync(c => ids.Contains(c.ContactId));
        }

        public async Task<IEnumerable<Domain.Models.CasContact>> GetByUserIds(HashSet<int> userIds)
        {
            if (userIds == default)
            {
                return default;
            }

            return await GetMultiAsync(c => userIds.Contains(c.UserId));
        }

        public async Task<IEnumerable<Domain.Models.CasContact>> GetByContactIds(HashSet<int> contactIds)
        {
            if (contactIds == default)
            {
                return default;
            }

            return await GetMultiAsync(c => contactIds.Contains(c.ContactId));
        }
    }
}
