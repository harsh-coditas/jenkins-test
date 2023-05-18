using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListContactCustom
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public string Custom { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int Sequence { get; set; }
    }
}
