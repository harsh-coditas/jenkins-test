using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasPriorityMapping
    {
        public int PriorityId { get; set; }
        public int CompanyId { get; set; }
        public string Crmpriority { get; set; }
        public string Caspriority { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
