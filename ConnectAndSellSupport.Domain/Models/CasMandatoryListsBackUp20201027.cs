using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasMandatoryListsBackUp20201027
    {
        public int MandatoryId { get; set; }
        public int RepId { get; set; }
        public int ManagerId { get; set; }
        public int ListId { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsMandatory { get; set; }
    }
}
