using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasJobTriggeredDetails
{
    public interface ICasJobTriggeredDetails : IRepository<Domain.Models.CasJobsTriggeredDetail>
    {
        //Task<Domain.Models.CasJobsTriggeredDetails> GetByJobId(int id);
        Task<IEnumerable<Domain.Models.CasJobsTriggeredDetail>> GetByStartDateJobIdJobName(DateTime startTime,DateTime endTime);
    }
}
