using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListType
    {
        public CasListType()
        {
            CasLists = new HashSet<CasList>();
        }

        public int ListTypeId { get; set; }
        public int? CompanyId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<CasList> CasLists { get; set; }
    }
}
