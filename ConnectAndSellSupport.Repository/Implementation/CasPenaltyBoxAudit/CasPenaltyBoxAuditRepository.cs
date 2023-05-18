using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasPenaltyBoxAudit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasPenaltyBoxAudit
{
    public class CasPenaltyBoxAuditRepository : Repository<Domain.Models.CasPenaltyBoxAudit>, ICasPenaltyBoxAuditRepository
    {
        public CasPenaltyBoxAuditRepository(CASContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Domain.Models.CasPenaltyBoxAudit>> GetPenaltyBoxAudit(int companyId, string EntityType, DateTime fromDate, DateTime toDate, int?[] ListIds, int?[] UserIds)
        {
            if (companyId == default)
            {
                return default;
            }
            return await GetMultiAsync(c => c.ClientId.Equals(companyId) &&
                                                                 (
                                                                     (EntityType == "DNC" && c.Status == "DNC") ||
                                                                     (EntityType == "BadNumber" && c.Status== "Bad Number") ||
                                                                     (EntityType == "MalformedNumber" && c.Status== "Malformed Number") ||
                                                                     (EntityType == "Wrong Number" && c.Status == "Wrong Number")

                                                                 )
                                                                 && (c.IsDeleted.HasValue && c.IsDeleted==false)
                                                                 && (ListIds.Contains(c.ListId)
                                                                 && UserIds.Contains(c.CampaignUserId))
                                                                 && (c.CreatedDate > fromDate && c.CreatedDate < toDate));
        }

        public async Task<IEnumerable<Domain.Models.CasPenaltyBoxAudit>> GetPenaltyBoxAuditByPhoneNumber(string phoneNumber)
        {
           if(phoneNumber==default)
            {
                return default;
            }
           return await GetMultiAsync(c=>c.Phone1.Equals(phoneNumber) 
                                       || c.Phone2.Equals(phoneNumber)
                                       || c.Phone3.Equals(phoneNumber)
                                       || c.Pbphone.Equals(phoneNumber) 
                                       && (c.IsDeleted.HasValue && c.IsDeleted == false))  ;
        }

        public async Task<Domain.Models.CasPenaltyBoxAudit> GetPenaltyBoxAuditDetails(int companyId, string CompaignName, string firstName, string LastName, string PBPhone)
        {
           if(companyId==default)
            {
                return null;
            }
            return await GetSingleAsync(c => c.ContactId.Equals(companyId)
                                         && c.CampaignName.Equals(CompaignName)
                                         && c.FirstName.Equals(firstName)
                                         && c.LastName.Equals(LastName)
                                         && c.Pbphone.Equals(PBPhone));
        }
    }
}
