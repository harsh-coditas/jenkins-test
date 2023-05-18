using System;

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasContactUserReplenishment
    {
        public string ClientName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactCompanyName { get; set; }
        public string Title { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string TimeZone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string IsReferral { get; set; }
        public string CrmUrl { get; set; }
        public bool Active { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
