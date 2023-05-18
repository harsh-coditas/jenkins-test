using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasRealTimeAlertForTeamSetting
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? TeamId { get; set; }
        public string DispositionsId { get; set; }
        public string EmailId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
