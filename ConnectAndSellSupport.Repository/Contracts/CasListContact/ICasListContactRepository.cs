using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasListContact
{
    public interface ICasListContactRepository : IRepository<Domain.Models.CasListContact>
    {
        Task<Domain.Models.CasListContact> GetByContactId(int contactId);
        Task<IEnumerable<Domain.Models.CasListContact>> GetByListIds(HashSet<int> listIds);
    }
}
