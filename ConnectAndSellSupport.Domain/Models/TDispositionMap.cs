using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TDispositionMap
    {
        public int Id { get; set; }
        public string FromDisposition { get; set; }
        public string ToDisposition { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
    }
}
