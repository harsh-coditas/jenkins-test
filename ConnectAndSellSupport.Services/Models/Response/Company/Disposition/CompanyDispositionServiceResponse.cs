using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.Company
{
    public class CompanyDispositionServiceResponse : BaseServiceResponse
    {
        public List<CompanyDisposition> CompanyDispositions { get; set; }

        public bool DispositionsNotFound { get; set; }
    }
}
