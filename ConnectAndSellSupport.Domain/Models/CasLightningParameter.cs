using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasLightningParameter
    {
        public int LightningParameterId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
