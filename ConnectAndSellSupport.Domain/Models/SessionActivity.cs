using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class SessionActivity
    {
        public int ActivityId { get; set; }
        public int SessionId { get; set; }

        public virtual Session Session { get; set; }
    }
}
