using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.TCompany
{
    public interface ITCompanyRepository : IRepository<Domain.Models.TCompany>
    {
        Task<IEnumerable<Domain.Models.TCompany>> GetAll();
    }
}
