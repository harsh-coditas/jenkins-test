using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMultiTouchListContact
    {
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public DateTime AddedDate { get; set; }

        public virtual CasContact Contact { get; set; }
        public virtual CasList List { get; set; }
    }
}
