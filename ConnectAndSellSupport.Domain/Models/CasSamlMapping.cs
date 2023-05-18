using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasSamlMapping
    {
        public int Id { get; set; }
        public int OktaParentCompanyId { get; set; }
        public string OktaParentCompanyName { get; set; }
        public bool IsOktaParentCompanyActive { get; set; }
        public int AssignCompanyId { get; set; }
        public string AssignCompanyName { get; set; }
        public bool IsAssignCompanyActive { get; set; }
    }
}
