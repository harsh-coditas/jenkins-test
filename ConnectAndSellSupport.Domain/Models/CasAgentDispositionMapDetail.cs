using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasAgentDispositionMapDetail
    {
        public int MappingDetailId { get; set; }
        public int MappingId { get; set; }
        public string AgentDispositionText { get; set; }
        public string MappedCustomDispositionText { get; set; }
        public string CallOutcome { get; set; }

        public virtual CasAgentDispositionMap Mapping { get; set; }
    }
}
