using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasDefaultCompanySetting
    {
        public int Id { get; set; }
        public string CrmName { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
