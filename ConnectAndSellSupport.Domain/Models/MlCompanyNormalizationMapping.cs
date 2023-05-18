using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class MlCompanyNormalizationMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Count { get; set; }
        public string NameN { get; set; }
        public string Url { get; set; }
    }
}
