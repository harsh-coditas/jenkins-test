using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasPenaltyBoxAudit
{
    public interface ICasPenaltyBoxAuditRepository : IRepository<Domain.Models.CasPenaltyBoxAudit>
    {
        Task<IEnumerable<Domain.Models.CasPenaltyBoxAudit>> GetPenaltyBoxAudit(int companyId, string EntityType, DateTime fromDate, DateTime toDate, int?[] ListIds, int?[] UserIds);
        Task<IEnumerable<Domain.Models.CasPenaltyBoxAudit>> GetPenaltyBoxAuditByPhoneNumber(string phoneNumber);
        Task<Domain.Models.CasPenaltyBoxAudit> GetPenaltyBoxAuditDetails(int companyId, string CompaignName, string firstName, string LastName, string PBPhone); 
        
    }
}
