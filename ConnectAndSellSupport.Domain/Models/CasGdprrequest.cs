using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGdprrequest
    {
        public long GdprrequestId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactCompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool? GdprrequestStaus { get; set; }
        public int? RequestUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ContactId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
