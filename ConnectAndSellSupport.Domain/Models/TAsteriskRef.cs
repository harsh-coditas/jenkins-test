using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TAsteriskRef
    {
        public int Id { get; set; }
        public string Configuration { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public int MiPort { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int SipCapacity { get; set; }
        public int IaxCapacity { get; set; }
        public string SipFormat { get; set; }
        public string IaxFormat { get; set; }
    }
}
