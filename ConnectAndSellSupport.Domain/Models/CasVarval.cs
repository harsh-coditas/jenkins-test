using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasVarval
    {
        public string CompanyName { get; set; }
        public int? CompanyId { get; set; }
        public string UserName { get; set; }
        public int? UserId { get; set; }
        public string VarVal { get; set; }
        public string LoginId { get; set; }
        public string Pwd { get; set; }
        public string LoginUserName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
