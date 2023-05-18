using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserSession
    {
        public long UserSessionId { get; set; }
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public bool? Active { get; set; }
        public string UserIp { get; set; }

        public virtual TUser User { get; set; }
    }
}
