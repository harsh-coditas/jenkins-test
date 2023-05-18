using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasContactUserReplenishment
{
    public interface ICasReplenishmentRepository : IRepository<Domain.Models.CasContactUserReplenishment>
    {
        public Task<IList<Domain.Models.CasContactUserReplenishment>> GetReplenishmentEntity(string companyName, List<string> userNames, DateTime fromDate, DateTime toDate);        
    }
}
