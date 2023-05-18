using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.TUser
{
    public interface ITUserRepository : IRepository<Domain.Models.TUser>
    {
        Task<Domain.Models.TUser> GetById(int id);
        Task<IEnumerable<Domain.Models.TUser>> GetByIds(HashSet<int> id);
        Task<Domain.Models.TUser> GetByUsername(string username);
        Task<IEnumerable<Domain.Models.TUser>> GetByCompanyId(int companyId);

    }
}
