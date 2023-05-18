using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPbruleAction
    {
        public int PbruleAction { get; set; }
        public int? RuleId { get; set; }
        public string EntityName { get; set; }
        public string Pbtype { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string CreateUser { get; set; }
        public string ModUser { get; set; }

        public virtual CasPbrule Rule { get; set; }
    }
}
