using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class ContactNumber
    {
        public double? DialledNumber { get; set; }
        public DateTime? CallPlacedTime { get; set; }
        public DateTime? CallConnectedTime { get; set; }
        public DateTime? CallDisconnectedTime { get; set; }
    }
}
