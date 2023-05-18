﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCloneSetting
    {
        public int CompanySettingId { get; set; }
        public int CompanyId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string LastModUser { get; set; }
        public DateTime? LastModDate { get; set; }
    }
}
