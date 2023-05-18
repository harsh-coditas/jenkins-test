using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasCompanySettingDetail
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string SettingKey { get; set; }
        public string PreviousSettingValue { get; set; }
        public string ModifiedSettingValue { get; set; }
        public long? CompanyId { get; set; }
    }
}
