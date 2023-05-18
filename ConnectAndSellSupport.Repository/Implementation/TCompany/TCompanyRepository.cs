using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.TCompany
{
    public class TCompanyRepository : Repository<Domain.Models.TCompany>, ITCompanyRepository
    {
        public TCompanyRepository(CASContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Domain.Models.TCompany>> GetAll()
        {
            return await GetMultiAsync(c => !c.IsDeleted.HasValue || !c.IsDeleted.Value);
        }
    }
}
