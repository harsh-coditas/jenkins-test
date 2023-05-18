using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserGreeting
    {
        public CasUserGreeting()
        {
            CasListUsers = new HashSet<CasListUser>();
        }

        public int GreetingId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? GreetingIndex { get; set; }
        public double RecordDuration { get; set; }

        public virtual ICollection<CasListUser> CasListUsers { get; set; }
    }
}
