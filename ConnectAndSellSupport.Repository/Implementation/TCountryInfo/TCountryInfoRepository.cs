using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TCountryInfo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.TCountryInfo
{
    public class TCountryInfoRepository : Repository<Domain.Models.TCountryInfo>, ITCountryInfoRepository
    {
        public TCountryInfoRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.TCountryInfo> GetByName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return default;
            }

            return await GetSingleAsync(c => name.Equals(c.Name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<Domain.Models.TCountryInfo>> GetByNames(HashSet<string> names)
        {
            if (names == default)
            {
                return default;
            }

            return await GetMultiAsync(c => names.Contains(c.Name));
        }
    }
}
