using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public bool? IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public DateTime? PasswordChangedOn { get; set; }
        public DateTime? LockedOutOn { get; set; }
        public int FailedPasswordAttempts { get; set; }
        public string PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiresOn { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public bool IsTourCompleted { get; set; }
        public bool IsPasswordReset { get; set; }
        public string Otp { get; set; }

        public virtual TUser User { get; set; }
    }
}
