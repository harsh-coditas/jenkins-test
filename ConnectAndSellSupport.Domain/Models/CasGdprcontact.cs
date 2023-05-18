using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGdprcontact
    {
        public int GdprcontactId { get; set; }
        public int? GdprrequestId { get; set; }
        public int? ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int? CompanyId { get; set; }
        public int? RequestUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
