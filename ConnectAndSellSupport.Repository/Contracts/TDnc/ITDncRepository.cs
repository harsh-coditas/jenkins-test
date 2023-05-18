using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.TDnc
{
    public interface ITDncRepository : IRepository<Domain.Models.TDnc>
    {
        Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdAndDateRange(int companyId, DateTime fromDate, DateTime toDate);
        Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdNumberListAndDateRange(int companyId, HashSet<string> numberList, DateTime fromDate, DateTime toDate);
        Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdAndNumberList(int companyId, HashSet<string> numberList);
    }
}
