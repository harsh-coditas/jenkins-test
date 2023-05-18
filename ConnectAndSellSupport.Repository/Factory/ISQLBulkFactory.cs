using ConnectAndSellSupport.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Factory
{
    public interface ISQLBulkFactory
    {
        ISQLBulkOperation BeginOperation();
    }
}
