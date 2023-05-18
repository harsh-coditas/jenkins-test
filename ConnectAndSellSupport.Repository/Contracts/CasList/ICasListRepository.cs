using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasList
{
    public interface ICasListRepository : IRepository<Domain.Models.CasList>
    {
        Task<Domain.Models.CasList> GetById(int id);
        Task<IEnumerable<Domain.Models.CasList>> GetByIds(IEnumerable<int> listIds);
        Task<IEnumerable<Domain.Models.CasList>> GetByCompanyId(int? companyId, IEnumerable<int?> userIds);
        Task<IEnumerable<Domain.Models.CasList>> GetByCompanyIdAndAutoRefreshEnabled(int companyId, IEnumerable<int?> userIds);
        Task<IEnumerable<Domain.Models.CasList>> GetByCompanyIdAndAutoRefreshDisabled(int companyId, IEnumerable<int?> userIds);        
    }
}
