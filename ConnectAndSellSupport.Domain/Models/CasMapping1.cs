using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMapping1
    {
        public int MappingId { get; set; }
        public string Name { get; set; }
        public string Crmsystem { get; set; }
        public string CrmobjectType { get; set; }
        public int? ParentMappingId { get; set; }
        public int? ListId { get; set; }
        public bool Primary { get; set; }
        public int? CompanyId { get; set; }
    }
}
