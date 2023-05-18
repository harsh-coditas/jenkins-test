using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TUser
    {
        public TUser()
        {
            CasContacts = new HashSet<CasContact>();
            CasListUsers = new HashSet<CasListUser>();
            CasLists = new HashSet<CasList>();
            CasNextGenTaskInfos = new HashSet<CasNextGenTaskInfo>();
            CasSessionSchedulings = new HashSet<CasSessionScheduling>();
            CasTriggerVoicemails = new HashSet<CasTriggerVoicemail>();
            CasUserArticleViewMappings = new HashSet<CasUserArticleViewMapping>();
            CasUserInvitationCreatedByUsers = new HashSet<CasUserInvitation>();
            CasUserInvitationUsers = new HashSet<CasUserInvitation>();
            CasUserSessions = new HashSet<CasUserSession>();
            CasUserSettings = new HashSet<CasUserSetting>();
            CasUsers = new HashSet<CasUser>();
            SAttemptSummaries = new HashSet<SAttemptSummary>();
            TBilledSessions = new HashSet<TBilledSession>();
            TDncArchives = new HashSet<TDncArchive>();
            TRolesHistories = new HashSet<TRolesHistory>();
            TScheduledSessions = new HashSet<TScheduledSession>();
        }

        public int Id { get; set; }
        public int CatMetric { get; set; }
        public int VarMetric { get; set; }
        public int Commented { get; set; }
        public string Filename { get; set; }
        public string Category { get; set; }
        public string VarName { get; set; }
        public string VarVal { get; set; }
        public string Identifier { get; set; }
        public string LoginId { get; set; }
        public string LoginPw { get; set; }
        public string UserName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Tel1 { get; set; }
        public string Ext1 { get; set; }
        public string Tel2 { get; set; }
        public string Ext2 { get; set; }
        public string Fax { get; set; }
        public string FaxExt { get; set; }
        public string Email1 { get; set; }
        public string Background { get; set; }
        public int? PermittedRoles { get; set; }
        public string CompanyName { get; set; }
        public int? Score { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModDate { get; set; }
        public string ModUser { get; set; }
        public int CompanyId { get; set; }
        public string CallbackNumber { get; set; }
        public string Email2 { get; set; }
        public int VoicemailLength { get; set; }
        public string DotNetVersion { get; set; }
        public string Title { get; set; }
        public string LoginPageFragment { get; set; }
        public bool IsBetaUser { get; set; }
        public int Priority { get; set; }
        public int Sla { get; set; }
        public int LanguageSkills { get; set; }
        public string LocationCode { get; set; }
        public int HourlyRate { get; set; }
        public int InviteAlertMinutes { get; set; }
        public string DomainId { get; set; }
        public bool DomainLoginRequired { get; set; }
        public bool? RequiresDispositions { get; set; }
        public string TimeZoneId { get; set; }
        public string DataSourceName { get; set; }
        public string AccountType { get; set; }
        public bool IsLightningOnly { get; set; }
        public bool? IsAvailableForHotTransfer { get; set; }
        public int? Colvpriority { get; set; }
        public int? Colvsla { get; set; }
        public int SortOrder { get; set; }
        public string LoginEmailId { get; set; }
        public string ImageUrl { get; set; }
        public byte ExistingUserActivationStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? FirstUsageDate { get; set; }

        public virtual TCompany Company { get; set; }
        public virtual ICollection<CasContact> CasContacts { get; set; }
        public virtual ICollection<CasListUser> CasListUsers { get; set; }
        public virtual ICollection<CasList> CasLists { get; set; }
        public virtual ICollection<CasNextGenTaskInfo> CasNextGenTaskInfos { get; set; }
        public virtual ICollection<CasSessionScheduling> CasSessionSchedulings { get; set; }
        public virtual ICollection<CasTriggerVoicemail> CasTriggerVoicemails { get; set; }
        public virtual ICollection<CasUserArticleViewMapping> CasUserArticleViewMappings { get; set; }
        public virtual ICollection<CasUserInvitation> CasUserInvitationCreatedByUsers { get; set; }
        public virtual ICollection<CasUserInvitation> CasUserInvitationUsers { get; set; }
        public virtual ICollection<CasUserSession> CasUserSessions { get; set; }
        public virtual ICollection<CasUserSetting> CasUserSettings { get; set; }
        public virtual ICollection<CasUser> CasUsers { get; set; }
        public virtual ICollection<SAttemptSummary> SAttemptSummaries { get; set; }
        public virtual ICollection<TBilledSession> TBilledSessions { get; set; }
        public virtual ICollection<TDncArchive> TDncArchives { get; set; }
        public virtual ICollection<TRolesHistory> TRolesHistories { get; set; }
        public virtual ICollection<TScheduledSession> TScheduledSessions { get; set; }
    }
}
