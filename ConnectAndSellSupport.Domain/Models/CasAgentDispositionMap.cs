using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasAgentDispositionMap
    {
        public CasAgentDispositionMap()
        {
            CasAgentDispositionMapDetails = new HashSet<CasAgentDispositionMapDetail>();
        }

        public int MappingId { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<CasAgentDispositionMapDetail> CasAgentDispositionMapDetails { get; set; }
    }
}
