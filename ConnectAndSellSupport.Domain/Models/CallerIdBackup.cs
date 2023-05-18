using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CallerIdBackup
    {
        public int UserSettingId { get; set; }
        public int UserId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
