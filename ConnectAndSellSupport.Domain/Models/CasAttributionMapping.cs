using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasAttributionMapping
    {
        public int MappingId { get; set; }
        public int CompanyId { get; set; }
        public string ContactFieldName { get; set; }
        public string CrmfieldName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}
