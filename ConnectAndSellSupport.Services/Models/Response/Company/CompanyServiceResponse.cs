using System;
using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.Company
{
    public class CompanyServiceResponse : BaseServiceResponse
    {
        public List<CompanyDetails> Companies { get; set; }

        public bool CompaniesNotFound { get; set; }
    }
}
