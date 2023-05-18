using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasListTag
    {
        public int TagId { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
