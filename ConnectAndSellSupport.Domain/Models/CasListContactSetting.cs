using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListContactSetting
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int ContactId { get; set; }
        public bool OnHold { get; set; }
    }
}
