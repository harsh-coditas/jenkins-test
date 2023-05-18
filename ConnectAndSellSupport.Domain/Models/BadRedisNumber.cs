using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class BadRedisNumber
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}
