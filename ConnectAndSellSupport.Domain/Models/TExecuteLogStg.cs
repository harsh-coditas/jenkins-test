using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TExecuteLogStg
    {
        public int LogId { get; set; }
        public string SprocName { get; set; }
        public string Description { get; set; }
        public int? AffectedRows { get; set; }
        public DateTime? ExecutionTime { get; set; }
        public string ParameterString { get; set; }
        public string ParameterValue { get; set; }
    }
}
