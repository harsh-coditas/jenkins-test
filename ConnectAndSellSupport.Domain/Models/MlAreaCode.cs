using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class MlAreaCode
    {
        public double? Id { get; set; }
        public double? AreaCode { get; set; }
        public string State { get; set; }
        public string TimeZone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
}
