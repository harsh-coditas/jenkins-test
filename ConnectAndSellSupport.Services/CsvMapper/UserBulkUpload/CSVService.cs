using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.CsvMapper
{
    public class CSVService : ICSVService
    {
        /// <summary>
        ///     Used to read any csv file using stream ops and return records
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <author>Shubham Varma</author>
        /// <returns></returns>
        public IEnumerable<T> ReadCSV<T>(Stream file)
        {
            var reader = new StreamReader(file);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<T>();
           
            return records;
        }
    }
}
