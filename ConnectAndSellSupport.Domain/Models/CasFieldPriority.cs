using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasFieldPriority
    {
        public int FieldPriorityId { get; set; }
        public int? CompanyId { get; set; }
        public string Crmsystem { get; set; }
        public string CrmobjectType { get; set; }
        public string CrmfieldName { get; set; }
        public int Priority { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
