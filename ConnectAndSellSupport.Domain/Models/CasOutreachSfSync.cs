using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasOutreachSfSync
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? LastSyncDateTime { get; set; }
        public string FailedTaskId { get; set; }

        public virtual TUser User { get; set; }
    }
}
