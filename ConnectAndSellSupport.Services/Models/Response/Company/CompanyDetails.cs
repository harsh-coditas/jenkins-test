using System;

namespace ConnectAndSellSupport.Services.Models.Response.Company
{
    public class CompanyDetails
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string TimeZone { get; set; }
    }
}
