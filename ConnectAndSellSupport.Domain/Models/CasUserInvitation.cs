using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUserInvitation
    {
        public int UserInvitationId { get; set; }
        public int? CompanyId { get; set; }
        public string EmailKey { get; set; }
        public string EmailId { get; set; }
        public DateTime? InvitationDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? UserRole { get; set; }
        public int? CreatedByUserId { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? UserId { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual TUser CreatedByUser { get; set; }
        public virtual TUser User { get; set; }
    }
}
