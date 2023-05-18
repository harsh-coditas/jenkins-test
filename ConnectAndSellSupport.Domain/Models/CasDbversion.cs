using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasDbversion
    {
        public int DbversionId { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string Description { get; set; }
    }
}
