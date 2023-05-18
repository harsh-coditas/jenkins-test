using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts
{
    public interface ISQLBulkOperation : IDisposable
    {
        /// <summary>
        /// Accepts DataTable as parameter and uses the Tablename assigned to the DataTable as the table to write data into
        /// </summary>
        /// <param name="dt">
        /// DataTable must have TableName which corresponds to table name in the database
        /// </param>
        void BulkInsert(DataTable dt);
        void Complete();
    }
}
