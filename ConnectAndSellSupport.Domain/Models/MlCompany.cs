using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class MlCompany
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public string SecondaryIndustry { get; set; }
        public double? Revenue { get; set; }
        public double? Employees { get; set; }
        public string NameN { get; set; }
        public string CompanyTel1 { get; set; }
        public string CompanyTel2 { get; set; }
        public int Id { get; set; }
    }
}
