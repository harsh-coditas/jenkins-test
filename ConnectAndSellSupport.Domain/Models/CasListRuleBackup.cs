using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListRuleBackup
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string Rules { get; set; }
        public bool DaysFlag { get; set; }
        public bool DeactivateFlag { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
