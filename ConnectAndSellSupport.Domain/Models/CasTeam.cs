using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string Users { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
