using ConnectAndSellSupport.Services.CsvMapper.PenaltyBox;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ConnectAndSellSupport.Services.Helpers.Csv
{
    public class CsvService
    {
        public static List<Tout> ReadCSVFile<Tout, TMapper>(IFormFile file) where TMapper : ClassMap<Tout>
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Mode = CsvMode.Escape
                };

                using var reader = new StreamReader(file.OpenReadStream(), Encoding.Default);
                using var csv = new CsvReader(reader, config);
                {
                    csv.Context.RegisterClassMap<TMapper>();
                    return csv.GetRecords<Tout>().ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
