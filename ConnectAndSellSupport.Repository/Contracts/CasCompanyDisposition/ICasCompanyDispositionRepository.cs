using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition
{
    public interface ICasCompanyDispositionRepository : IRepository<Domain.Models.CasCompanyDisposition>
    {
        Task<Domain.Models.CasCompanyDisposition> GetById(int id);
        Task<Domain.Models.CasCompanyDisposition> GetByText(string text);
        Task<IEnumerable<Domain.Models.CasCompanyDisposition>> GetByCompanyId(int companyId);
    }
}
