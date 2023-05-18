using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasPenalizedPhoneNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasPenalizedPhoneNumber
{
    public class CasPenalizedPhoneNumberRepository : Repository<Domain.Models.CasPenalizedPhoneNumber>, ICasPenalizedPhoneNumberRepository
    {
        public CasPenalizedPhoneNumberRepository(CASContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Domain.Models.CasPenalizedPhoneNumber>> GetPenalizedPhoneNumber(int companyId, string EntityType, DateTime fromDate, DateTime toDate, int?[] ListIds, int?[] UserIds)
        {
            if(companyId == default)
            {
                return default;
            }
           

            return await GetMultiAsync(c => c.ClientId.Equals(companyId)  && 
                                                            (
                                                                (EntityType == "DNC" && c.Dnc.HasValue && c.Dnc == true) ||
                                                                (EntityType == "BadNumber" && c.BadNumber.HasValue && c.BadNumber == true) ||
                                                                (EntityType == "MalformedNumber" && c.MalformedNumber.HasValue && c.MalformedNumber == true) ||
                                                                (EntityType == "Wrong Number" && c.WrongNumber == 1)

                                                            )
                                                            &&(c.IsDeleted.HasValue && c.IsDeleted==false)
                                                            && (ListIds.Contains(c.ListId)
                                                            && UserIds.Contains(c.CampaignUserId))
                                                            && (c.LastPenalizedDate > fromDate && c.LastPenalizedDate < toDate));



        }

        public async Task<IEnumerable<Domain.Models.CasPenalizedPhoneNumber>> GetPenalizedPhoneNumberByPhoneNumber(string PhoneNumber)
        {
            if(PhoneNumber==default)
            {
                return default;
            }
            return await GetMultiAsync(c=>c.PhoneNumber.Equals(PhoneNumber)
                                        &&(c.IsDeleted.HasValue && c.IsDeleted == false));   
            
        }

        public async Task<Domain.Models.CasPenalizedPhoneNumber> GetPenaltyBoxPhoneNumbersByIds(int penaltyBoxId)
        {
            if(penaltyBoxId==default)
            {
                return default;
            }
            return await GetSingleAsync(c => c.RecordId.Equals(penaltyBoxId) 
                                        &&(c.IsDeleted.HasValue && c.IsDeleted== false));
            
        }
    }
}
