using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Models
{
    public class UserBulkUploadDBModelTCas
    {
        public int Id { get; set; }
        public int cat_metric { get; set; } = 1;
        public int var_metric { get; set; } = 100;
        public int commented { get; set; } = 0;
        public string filename { get; set; } = "agents.conf";
        public string category { get; set; } = "category";
        public string var_name { get; set; } = "agents";
        public string var_val { get; set; }
        public string Identifier { get; set; }
        public string LoginID { get; set; }
        public string LoginPW { get; set; } = "!@#$%^&*()";
        public string UserName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; } = "United States";
        public int Tel1 { get; set; } = 0;
        public int Ext1 { get; set; } = 0;
        public int Tel2 { get; set; } = 0;
        public int Ext2 { get; set; } = 0;
        public int Fax { get; set; } = 0;
        public int Fax_Ext { get; set; } = 0;
        public string Email1 { get; set; }
        public string Background { get; set; }
        public int PermittedRoles { get; set; }
        public string CompanyName { get; set; }
        public int Score { get; set; } = 0;
        public bool? IsDeleted { get; set; } = false;
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; } = "Administrator";
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; } = "Administrator";
        public int CompanyId { get; set; }
        public string CallbackNumber { get; set; } = "+10";
        public string Email2 { get; set; }
        public int VoicemailLength { get; set; } = 0;
        public string DotNetVersion { get; set; } = "v3.5";
        public string Title { get; set; }
        public string LoginPageFragment { get; set; }
        public bool IsBetaUser { get; set; } = false;
        public int Priority { get; set; } = 0;
        public int Sla { get; set; } = 0;
        public int LanguageSkills { get; set; } = 1;
        public string LocationCode { get; set; } = "Nirvana";
        public int HourlyRate { get; set; } = 0;
        public int InviteAlertMinutes { get; set; } = 60;
        public string DomainId { get; set; } = "";
        public bool DomainLoginRequired { get; set; } = false;
        public bool? RequiresDispositions { get; set; } = true;
        public string TimeZoneId { get; set; }
        public string DataSourceName { get; set; }
        public string AccountType { get; set; }
        public bool IsLightningOnly { get; set; } = false;
        public bool? IsAvailableForHotTransfer { get; set; }
        public int? COLVPriority { get; set; }
        public int? COLVSla { get; set; }
        public int SortOrder { get; set; } = 0;
        public string LoginEmailID { get; set; }
        public string ImageUrl { get; set; }
        public byte ExistingUserActivationStatus { get; set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? FirstUsageDate { get; set; }
    }

    public class UserBulkUploadDBModelCUser
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; } = "test";
        public bool? IsApproved { get; set; } = true;
        public bool IsLockedOut { get; set; } = false;
        public DateTime? LastLoggedIn { get; set; }
        public DateTime? PasswordChangedOn { get; set; }
        public DateTime? LockedOutOn { get; set; }
        public int FailedPasswordAttempts { get; set; } = 0;
        public string PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiresOn { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; } = "AdminCenerated";
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; } = "AdminGenerated";
        public bool IsTourCompleted { get; set; } = false;
        public bool IsPasswordReset { get; set; } = true;
        public string Otp { get; set; }
    }
    public class CasUserBulkUploadPayload
    {
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
    }
}
