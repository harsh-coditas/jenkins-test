using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TDnc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.TDnc
{
    public class TDncRepository : Repository<Domain.Models.TDnc>, ITDncRepository
    {
        public TDncRepository(CASContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdAndDateRange(
            int companyId,
            DateTime fromDate,
            DateTime toDate)
        {
            if (companyId == default || fromDate == default || toDate == default)
            {
                return default;
            }

            return await GetMultiAsync(c =>
                c.ClientCompanyId.Equals(companyId) &&
                c.CreateDate >= fromDate &&
                c.CreateDate <= toDate.AddDays(1));
        }

        public async Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdNumberListAndDateRange(
            int companyId, 
            HashSet<string> numberList, 
            DateTime fromDate, 
            DateTime toDate)
        {
            if (companyId == default || numberList == default || fromDate == default || toDate == default)
            {
                return default;
            }

            return await GetMultiAsync(c => 
                c.ClientCompanyId.Equals(companyId) && 
                numberList.Contains(c.ContactNumber) &&
                c.CreateDate >= fromDate &&
                c.CreateDate <= toDate.AddDays(1));
        }

        public async Task<IEnumerable<Domain.Models.TDnc>> GetByCompanyIdAndNumberList(
            int companyId,
            HashSet<string> numberList)
        {
            if (companyId == default || numberList == default)
            {
                return default;
            }

            return await GetMultiAsync(c =>
                c.ClientCompanyId.Equals(companyId) &&
                numberList.Contains(c.ContactNumber));
        }
    }
}
