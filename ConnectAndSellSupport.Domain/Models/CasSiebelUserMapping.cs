using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasSiebelUserMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string SiebelUserName { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
