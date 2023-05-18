using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasCompanyDisposition
{
    public class CasCompanyDispositionRepository : Repository<Domain.Models.CasCompanyDisposition>, ICasCompanyDispositionRepository
    {
        public CasCompanyDispositionRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasCompanyDisposition> GetById(int id)
        {
            if (id == default)
            {
                return default;
            }

            return await GetSingleAsync(c => c.CompanyDispositionId.Equals(id) && c.Active);
        }

        public async Task<Domain.Models.CasCompanyDisposition> GetByText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return default;
            }

            return await GetSingleAsync(c => c.DispositionText.Equals(text) && c.Active);
        }

        public async Task<IEnumerable<Domain.Models.CasCompanyDisposition>> GetByCompanyId(int companyId)
        {
            if (companyId == default)
            {
                return default;
            }

            return await GetMultiAsync(c => c.CompanyId.Equals(companyId) && c.Active);
        }
    }
}
