using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasContact
{
    public interface ICasContactRepository : IRepository<Domain.Models.CasContact>
    {
        Task<Domain.Models.CasContact> GetById(int id);
        Task<IEnumerable<Domain.Models.CasContact>> GetByIds(HashSet<int> ids);
        Task<IEnumerable<Domain.Models.CasContact>> GetByUserIds(HashSet<int> userIds);
        Task<IEnumerable<Domain.Models.CasContact>> GetByContactIds(HashSet<int> contactIds);
    }
}
