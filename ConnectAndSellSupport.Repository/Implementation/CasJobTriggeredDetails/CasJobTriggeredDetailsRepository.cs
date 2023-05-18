using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasJobTriggeredDetails;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasJobTriggeredDetails
{
    public class CasJobTriggeredDetailsRepository : Repository<CasJobsTriggeredDetail>, ICasJobTriggeredDetails
    {
        
        public CasJobTriggeredDetailsRepository(CASContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CasJobsTriggeredDetail>> GetByStartDateJobIdJobName( DateTime startTime, DateTime endTime)
        {
            //var jobParameter = new List<SqlParameter>();
            //jobParameter.Add(new SqlParameter("@startTime", startTime));
            //jobParameter.Add(new SqlParameter("@endTime", endTime));
            //var jobRecord = await Task.Run(() => _context.casjobstriggereddetails.FromSqlRaw(@"exec p_GetJobDetalis @startTime , @endTime", jobParameter).ToListAsync());
            //return jobRecord;
            return await GetMultiAsync(c=>c.StartTime>startTime && c.StartTime<endTime);
        }
    }
}
