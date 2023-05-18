using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySettingDetail;

namespace ConnectAndSellSupport.Repository.Implementation.CasCompanySettingDetail
{
    public class CasCompanySettingDetailRepository : Repository<Domain.Models.CasCompanySettingDetail>, ICasCompanySettingDetailRepository
    {
        public CasCompanySettingDetailRepository(CASContext context) : base(context)
        {
        }
    }
}
