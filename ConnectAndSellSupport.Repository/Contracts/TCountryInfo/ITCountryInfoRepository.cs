using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.TCountryInfo
{
    public interface ITCountryInfoRepository : IRepository<Domain.Models.TCountryInfo>
    {
        Task<Domain.Models.TCountryInfo> GetByName(string name);
        Task<IEnumerable<Domain.Models.TCountryInfo>> GetByNames(HashSet<string> name);
    }
}
