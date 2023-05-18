using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbdispositionConfiguration
    {
        public int DispositionId { get; set; }
        public string Disposition { get; set; }
        public bool? Status { get; set; }
        public string ContactAction { get; set; }
    }
}
