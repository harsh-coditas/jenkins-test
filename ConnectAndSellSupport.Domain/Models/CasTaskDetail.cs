using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasTaskDetail
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? ContactId { get; set; }
        public int? UserId { get; set; }
        public int? TaskType { get; set; }
        public int? LeadTransitId { get; set; }
        public string Status { get; set; }
        public string TaskId { get; set; }
        public string CrmId { get; set; }
        public int? NextTaskDetailId { get; set; }
    }
}
