using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCompanySetting
    {
        public int CompanySettingId { get; set; }
        public int CompanyId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string LastModUser { get; set; }
        public DateTime? LastModDate { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
