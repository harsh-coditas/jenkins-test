using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts;
using ConnectAndSellSupport.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Factory
{
    public class SQLBulkFactory : ISQLBulkFactory
    {
        protected readonly CASContext _context;
        public SQLBulkFactory(CASContext context)
        {
            _context = context;
        }
        public virtual ISQLBulkOperation BeginOperation()
        {
            return new SQLBulkOperation(_context);
        }
    }
}
