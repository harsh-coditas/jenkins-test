using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class LogTable
    {
        public string Tsqlstatement { get; set; }
        public double? Fragmentation { get; set; }
        public DateTime? Executed { get; set; }
        public string ExecutedBy { get; set; }
    }
}
