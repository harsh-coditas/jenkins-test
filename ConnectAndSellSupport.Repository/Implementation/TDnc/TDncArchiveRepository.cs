using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TDnc;

namespace ConnectAndSellSupport.Repository.Implementation.TDnc
{
    public class TDncArchiveRepository : Repository<TDncArchive>, ITDncArchiveRepository
    {
        public TDncArchiveRepository(CASContext context) : base(context)
        {
        }
    }
}
