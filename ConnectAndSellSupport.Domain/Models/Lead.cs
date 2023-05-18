using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class Lead
    {
        public int ListId { get; set; }
        public int SessionId { get; set; }

        public virtual Session Session { get; set; }
    }
}
