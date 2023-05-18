using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.CsvMapper
{
    public interface ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(Stream file);
    }
}
