using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class MappingDatum
    {
        public string CompanyName { get; set; }
        public string CrmobjectType { get; set; }
        public string ContactFieldName { get; set; }
        public string CrmfieldName { get; set; }
    }
}
