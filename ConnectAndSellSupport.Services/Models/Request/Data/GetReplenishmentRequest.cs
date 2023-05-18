using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.Services.Models.Request.Data
{
    public class GetReplenishmentRequest
    {
        public string CompanyName { get; set; }

        public List<string> UserNames { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }        
    }
}
