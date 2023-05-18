using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListScore
    {
        public int Id { get; set; }
        public int? ListId { get; set; }
        public int? PhonePickUpStat { get; set; }
        public int? TotalBadContact { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TotalContacts { get; set; }

        public virtual CasList List { get; set; }
    }
}
