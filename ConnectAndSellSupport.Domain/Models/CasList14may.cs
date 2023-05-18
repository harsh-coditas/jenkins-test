using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasList14may
    {
        public int ListId { get; set; }
        public string Name { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime? LastRefreshDateTime { get; set; }
    }
}
