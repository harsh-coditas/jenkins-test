using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CrmtypeMaster
    {
        public int Id { get; set; }
        public string CrmtypeName { get; set; }
        public string Crmsystem { get; set; }
    }
}
