using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMapping
    {
        public CasMapping()
        {
            CasMappingFields = new HashSet<CasMappingField>();
            InverseParentMapping = new HashSet<CasMapping>();
        }

        public int MappingId { get; set; }
        public string Name { get; set; }
        public string Crmsystem { get; set; }
        public string CrmobjectType { get; set; }
        public int? ParentMappingId { get; set; }
        public int? ListId { get; set; }
        public bool? Primary { get; set; }
        public int? CompanyId { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual CasList List { get; set; }
        public virtual CasMapping ParentMapping { get; set; }
        public virtual ICollection<CasMappingField> CasMappingFields { get; set; }
        public virtual ICollection<CasMapping> InverseParentMapping { get; set; }
    }
}
