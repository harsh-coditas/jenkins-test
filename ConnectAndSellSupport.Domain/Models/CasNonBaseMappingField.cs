using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasNonBaseMappingField
    {
        public int FieldId { get; set; }
        public int? CompanyId { get; set; }
        public string Crmsystem { get; set; }
        public string CrmobjectType { get; set; }
        public string ContactFieldName { get; set; }
        public string CrmfieldName { get; set; }
        public string Crmvalue { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
