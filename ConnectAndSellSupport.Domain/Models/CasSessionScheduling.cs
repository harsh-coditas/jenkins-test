using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasSessionScheduling
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsDeleted { get; set; }
        public string InviteId { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual TUser User { get; set; }
    }
}
