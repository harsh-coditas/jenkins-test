using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasProblemDispositionsDetail
    {
        public int ProblemDispositionId { get; set; }
        public string ProblemDispositionText { get; set; }
        public int ProblemCode { get; set; }
    }
}
