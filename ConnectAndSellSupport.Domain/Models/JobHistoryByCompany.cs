using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class JobHistoryByCompany
    {
        public int JobParamId { get; set; }
        public int CompanyId { get; set; }
        public string JobName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
