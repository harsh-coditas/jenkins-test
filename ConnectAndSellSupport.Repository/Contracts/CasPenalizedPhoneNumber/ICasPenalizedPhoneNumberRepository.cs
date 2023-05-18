using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasPenalizedPhoneNumber
{
    public interface ICasPenalizedPhoneNumberRepository : IRepository<Domain.Models.CasPenalizedPhoneNumber>
    {
        Task<IEnumerable<Domain.Models.CasPenalizedPhoneNumber>> GetPenalizedPhoneNumber(int companyId, string EntityType, DateTime fromDate, DateTime toDate, int?[] ListIds, int?[] UserIds);
        Task<IEnumerable<Domain.Models.CasPenalizedPhoneNumber>> GetPenalizedPhoneNumberByPhoneNumber(string PhoneNumber);
        Task<Domain.Models.CasPenalizedPhoneNumber> GetPenaltyBoxPhoneNumbersByIds(int penaltyBoxId);
    }
}
