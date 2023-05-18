using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class ConnectCount
    {
        public int? SessionId { get; set; }
        public int? Connect { get; set; }
    }
}
