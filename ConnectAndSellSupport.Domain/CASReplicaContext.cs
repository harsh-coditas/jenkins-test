using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConnectAndSellSupport.Domain.ReplicaModels;

#nullable disable

namespace ConnectAndSellSupport.Domain
{
    public partial class CASReplicaContext : DbContext
    {
        public CASReplicaContext()
        {
        }

        public CASReplicaContext(DbContextOptions<CASReplicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualRanSession> ActualRanSessions { get; set; }
        public virtual DbSet<CasCompanyDisposition> CasCompanyDispositions { get; set; }
        public virtual DbSet<CasContact> CasContacts { get; set; }
        public virtual DbSet<CasList> CasLists { get; set; }
        public virtual DbSet<CasNote> CasNotes { get; set; }
        public virtual DbSet<ConversionRateTrending> ConversionRateTrendings { get; set; }
        public virtual DbSet<DeletedListDatum> DeletedListData { get; set; }
        public virtual DbSet<DeletedUserDatum> DeletedUserData { get; set; }
        public virtual DbSet<ListPerformanceContactCount> ListPerformanceContactCounts { get; set; }
        public virtual DbSet<ListPerformanceListCount> ListPerformanceListCounts { get; set; }
        public virtual DbSet<ListPerformanceUniqueCount> ListPerformanceUniqueCounts { get; set; }
        public virtual DbSet<ListPerformanceUserCount> ListPerformanceUserCounts { get; set; }
        public virtual DbSet<OutcomeAttemptDatum> OutcomeAttemptData { get; set; }
        public virtual DbSet<OutcomeConnectDatum> OutcomeConnectData { get; set; }
        public virtual DbSet<ProblemConnect> ProblemConnects { get; set; }
        public virtual DbSet<RepCount> RepCounts { get; set; }
        public virtual DbSet<RepPerformanceRepCont> RepPerformanceRepConts { get; set; }
        public virtual DbSet<RepPerformanceWaitTime> RepPerformanceWaitTimes { get; set; }
        public virtual DbSet<TCall> TCalls { get; set; }
        public virtual DbSet<TCall30jan232> TCall30jan232s { get; set; }
        public virtual DbSet<TCompany> TCompanies { get; set; }
        public virtual DbSet<TDstDate> TDstDates { get; set; }
        public virtual DbSet<TPitcherSession> TPitcherSessions { get; set; }
        public virtual DbSet<TSession> TSessions { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TimeAllocation> TimeAllocations { get; set; }
        public virtual DbSet<TimeAllocationOpt> TimeAllocationOpts { get; set; }
        public virtual DbSet<TimeAllocationTimeMetrixDatum> TimeAllocationTimeMetrixData { get; set; }
        public virtual DbSet<Usage> Usages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActualRanSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActualRanSession");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISdeleted");
            });

            modelBuilder.Entity<CasCompanyDisposition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompanyDisposition");

                entity.Property(e => e.CallOutcome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactStatus).HasMaxLength(100);

                entity.Property(e => e.ContactSubStatus).HasMaxLength(100);

                entity.Property(e => e.CountAsConversion).HasColumnName("countAsConversion");

                entity.Property(e => e.Csvstatus)
                    .HasMaxLength(100)
                    .HasColumnName("CSVStatus");

                entity.Property(e => e.DispositionText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DispositionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeadStatus).HasMaxLength(100);

                entity.Property(e => e.LeadSubStatus).HasMaxLength(100);

                entity.Property(e => e.SecondaryDispositionId)
                    .HasMaxLength(1000)
                    .HasColumnName("SecondaryDispositionID");

                entity.Property(e => e.SecondaryQuickListId).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Contact");

                entity.Property(e => e.AccountCity).HasMaxLength(1000);

                entity.Property(e => e.AccountState).HasMaxLength(1000);

                entity.Property(e => e.CallOnDays)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyIndustry).HasMaxLength(400);

                entity.Property(e => e.CompanyLocation).HasMaxLength(400);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CompanyUrl).HasMaxLength(1000);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).IsUnicode(false);

                entity.Property(e => e.ContactStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.CrmUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CrmtimeZone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMTimeZone");

                entity.Property(e => e.Custom).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnrichedCompany).HasMaxLength(500);

                entity.Property(e => e.EnrichedEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnrichedPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnrichedPhoneType).HasMaxLength(100);

                entity.Property(e => e.EnrichedTitle).HasMaxLength(1000);

                entity.Property(e => e.EnrichmentSource).HasMaxLength(100);

                entity.Property(e => e.EnrichmentStatus).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsInjectedContact).HasColumnName("isInjectedContact");

                entity.Property(e => e.JobPostingTitle).HasMaxLength(1000);

                entity.Property(e => e.LastConnectDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastVoicemail).HasColumnType("datetime");

                entity.Property(e => e.LeadSource).HasMaxLength(200);

                entity.Property(e => e.LinkedInUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MostRecentCampaign)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityId)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OriginListName).HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostInjectedContactTime).HasColumnType("datetime");

                entity.Property(e => e.ReferralCustom).IsUnicode(false);

                entity.Property(e => e.SecondarySubStatus).HasMaxLength(1000);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.StepNotes).IsUnicode(false);

                entity.Property(e => e.SubStatus).HasMaxLength(1000);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_List");

                entity.HasIndex(e => e.ListId, "ListID")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ListId, e.IsDeleted }, "ListID_IsDeleted");

                entity.Property(e => e.AcknowledgedBy).HasMaxLength(255);

                entity.Property(e => e.CallStarterText).IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.DefaultCallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DialToConnectRatio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsOodlist).HasColumnName("IsOODList");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastUsed).HasColumnType("datetime");

                entity.Property(e => e.ListCampaignId)
                    .HasMaxLength(50)
                    .HasColumnName("ListCampaignID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutreachListRefreshDate).HasColumnType("datetime");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SequenceId)
                    .HasMaxLength(900)
                    .HasColumnName("SequenceID");

                entity.Property(e => e.SettingMetaData).IsUnicode(false);

                entity.Property(e => e.SfReportPath).HasMaxLength(1000);

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<CasNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("cas_Note");

                entity.Property(e => e.CallSentiment).HasMaxLength(1000);

                entity.Property(e => e.Disposition).HasMaxLength(50);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.NextSteps).HasMaxLength(2000);

                entity.Property(e => e.ReviewDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<ConversionRateTrending>(entity =>
            {
                entity.ToTable("ConversionRateTrending");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallId).HasColumnName("CallID");

                entity.Property(e => e.CallListName)
                    .HasMaxLength(510)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionType).HasMaxLength(50);

                entity.Property(e => e.SessionDate).HasColumnType("date");
            });

            modelBuilder.Entity<DeletedListDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeletedListData", "CDC");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeletedUserDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeletedUserData", "CDC");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ListPerformanceContactCount>(entity =>
            {
                entity.ToTable("ListPerformance_ContactCount");

                entity.HasIndex(e => e.CallListId, "DeletedList");

                entity.HasIndex(e => e.CampaignUserId, "DeletedUser");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ThrowTime }, "UniqueContactCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompanyName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsPbrecord).HasColumnName("IsPBRecord");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListPerformanceListCount>(entity =>
            {
                entity.ToTable("ListPerformance_ListCount");

                entity.HasIndex(e => new { e.LeadtransitId, e.CallId }, "ContactIDUpdation");

                entity.HasIndex(e => e.CampaignUserId, "DeletedUserId");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ThrowTime }, "ListPerformance_ListCount_ListIDs");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ListPerformance_ListView_ForAllData");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ThrowTime }, "ListPerformance_ListView_UserAndList");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ListPerformance_ListView_UserIds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionType).HasColumnName("DispositionTYPE");

                entity.Property(e => e.IsPbrecord).HasColumnName("IsPBRecord");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListPerformanceUniqueCount>(entity =>
            {
                entity.ToTable("ListPerformance_UniqueCount");

                entity.HasIndex(e => e.CallListId, "DeletedList");

                entity.HasIndex(e => e.CampaignUserId, "DeletedUserId");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ListPerformance_UniqueContact_ForAllData");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ThrowTime }, "ListPerformance_UniqueCount_ListIds");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ListPerformance_UniqueCount_UserAndList");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ListPerformance_UniqueCount_UserIds");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ThrowTime }, "UniqueCount_ListID");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "UniqueCount_UserId");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "UserView_UniqueContact");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsPbrecord).HasColumnName("IsPBRecord");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListPerformanceUserCount>(entity =>
            {
                entity.ToTable("ListPerformance_UserCount");

                entity.HasIndex(e => e.CallListId, "DeletedList");

                entity.HasIndex(e => e.CampaignUserId, "DeletedUser");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "UserView_ForAll");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "UserView_ListId");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ThrowTime }, "UserView_ListIdAndUSerId");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ThrowTime }, "UserView_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsPbrecord).HasColumnName("IsPBRecord");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OutcomeAttemptDatum>(entity =>
            {
                entity.HasIndex(e => e.CallListId, "OutcomeAttempt_CallListID");

                entity.HasIndex(e => e.CampaignUserId, "OutcomeAttempt_CampaignUSerId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedList).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.DispositionCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBadNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutcomeConnectDatum>(entity =>
            {
                entity.HasIndex(e => e.CallListId, "OutcomeConnect_CallListId");

                entity.HasIndex(e => e.CampaignUserId, "Outcome_CampaignUserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedList).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.DispositionCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCallSentiment).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFollowUp).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMeetingSet).HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProblemConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProblemConnect");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepCount>(entity =>
            {
                entity.ToTable("RepCount");

                entity.HasIndex(e => new { e.CompanyId, e.CampaignUserId, e.ThrowTime }, "Report_RepPerformance_CampaignUserId");

                entity.HasIndex(e => new { e.CompanyId, e.ThrowTime }, "Report_RepPerformance_ListId");

                entity.HasIndex(e => new { e.CompanyId, e.ListId, e.ThrowTime }, "Report_RepPerformance_ListIdAndCampaignUserId");

                entity.HasIndex(e => new { e.CompanyId, e.ThrowTime }, "Report_RepPerformance_ThrowTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.CampaignUserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.ListName)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepPerformanceRepCont>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RepPerformance_RepCont");

                entity.HasIndex(e => new { e.CompanyId, e.CreateDate }, "Report_RepPerformance_DeletedData");

                entity.HasIndex(e => new { e.CompanyId, e.CreateDate }, "Report_RepPerformance_RepCount");

                entity.Property(e => e.CallListId).HasColumnName("CallListID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepPerformanceWaitTime>(entity =>
            {
                entity.ToTable("RepPerformance_WaitTime");

                entity.HasIndex(e => new { e.ClientId, e.CreateDate, e.UserId }, "Report_RepPerformance_WaitTimeData");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.PscreateDate }, "Report_RepPerformance_WaitTime_CallListId");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.PscreateDate }, "Report_RepPerformance_WaitTime_UserId");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.PscreateDate }, "Report_RepPerformance_WaitTime_UserIdWithWaitTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallListId).HasColumnName("CallListID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.ListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PscreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PSCreateDate");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCall>(entity =>
            {

                entity.ToTable("t_Call");

                entity.HasIndex(e => new { e.LeadTransitId, e.CallType }, "CallMeetingdataUpdate");

                entity.HasIndex(e => e.ClientId, "ClientId");

                entity.HasIndex(e => e.UserName, "DataInsertFromTCall");

                entity.HasIndex(e => e.UserName, "DataInsert_Usage");

                entity.HasIndex(e => new { e.CallType, e.Id, e.DispositionText }, "OutcomeConnect_DataLoad");

                entity.HasIndex(e => new { e.IsConversation, e.CallType, e.Id }, "OutcomeConnect_DataLoad_Sentiment");

                entity.HasIndex(e => new { e.CallType, e.Id, e.DispositionText }, "Outcome_AttemptData");

                entity.HasIndex(e => e.SessionId, "RepPerformance_WaitTimeData");

                entity.HasIndex(e => new { e.ClientName, e.ThrowTime, e.ClientId }, "Search_WrongClientId");

                entity.HasIndex(e => e.SessionId, "TimeMetrixDataLoad");

                entity.HasIndex(e => e.Id, "t_Call_ID_RepPerformance")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyExt1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyExt2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyInfo).IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompanyURL");

                entity.Property(e => e.CompanyZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBackground).IsUnicode(false);

                entity.Property(e => e.ContactCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactSalutation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.LeadCatchTime).HasColumnType("datetime");

                entity.Property(e => e.LeadListName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeadSendTime).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameCatchTime).HasColumnType("datetime");

                entity.Property(e => e.NoteText).IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCall30jan232>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_30Jan23_2");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyExt1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyExt2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyInfo).IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompanyURL");

                entity.Property(e => e.CompanyZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBackground).IsUnicode(false);

                entity.Property(e => e.ContactCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactExt3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactSalutation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.LeadCatchTime).HasColumnType("datetime");

                entity.Property(e => e.LeadListName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeadSendTime).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameCatchTime).HasColumnType("datetime");

                entity.Property(e => e.NoteText).IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Company");

                entity.Property(e => e.AccountId).HasMaxLength(25);

                entity.Property(e => e.AccountMgr)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AccountMgrDate).HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSvcsMgr)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSvcsMgrDate).HasColumnType("datetime");

                entity.Property(e => e.Colvpriority).HasColumnName("COLVPriority");

                entity.Property(e => e.Colvsla).HasColumnName("COLVSla");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmLoginMask)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CrmUrlFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EngineIdentifier).IsUnicode(false);

                entity.Property(e => e.Ext1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ext2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxExt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Ext");

                entity.Property(e => e.Growth).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Overview).IsUnicode(false);

                entity.Property(e => e.PreferredCrm)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRepDate).HasColumnType("datetime");

                entity.Property(e => e.ScriptCompanyName).IsUnicode(false);

                entity.Property(e => e.SessionReportDl)
                    .IsUnicode(false)
                    .HasColumnName("SessionReportDL");

                entity.Property(e => e.SfaccountUrl)
                    .IsUnicode(false)
                    .HasColumnName("SFAccountURL");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDstDate>(entity =>
            {
                entity.ToTable("t_DstDates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.FallBack).HasColumnType("datetime");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SpringForward).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPitcherSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_PitcherSession");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionEnd).HasColumnType("datetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionStart).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Session");

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstGoTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastAgentCallTime).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_User");

                entity.HasIndex(e => new { e.Id, e.IsDeleted }, "USerID_IsDeleted");

                entity.HasIndex(e => e.Id, "UserID")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.AccountType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Background).IsUnicode(false);

                entity.Property(e => e.CallbackNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CatMetric).HasColumnName("cat_metric");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colvpriority).HasColumnName("COLVPriority");

                entity.Property(e => e.Colvsla).HasColumnName("COLVSla");

                entity.Property(e => e.Commented).HasColumnName("commented");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataSourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DotNetVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email1).IsUnicode(false);

                entity.Property(e => e.Email2).IsUnicode(false);

                entity.Property(e => e.Ext1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaxExt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Ext");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstUsageDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginEmailId)
                    .IsUnicode(false)
                    .HasColumnName("LoginEmailID");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPageFragment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarMetric).HasColumnName("var_metric");

                entity.Property(e => e.VarName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("var_name");

                entity.Property(e => e.VarVal)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("var_val");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeAllocation>(entity =>
            {
                entity.ToTable("TimeAllocation");

                entity.HasIndex(e => e.CampaignUserId, "CampaignUserId");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "ClientId_ThrowTime");

                entity.HasIndex(e => e.ContactId, "ContactId");

                entity.HasIndex(e => e.CallListId, "DeletedListID_Updation");

                entity.HasIndex(e => new { e.DeletedList, e.DeletedUser }, "DeletedUserAndList");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime, e.DeletedList, e.DeletedUser, e.AssignmentId, e.IsFollowUp }, "NonClusteredIndex-20220911-102153");

                entity.HasIndex(e => e.SessionType, "SessionType");

                entity.HasIndex(e => e.ThrowTime, "ThrowTime");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ThrowTime }, "TimeAllocation");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime, e.SessionType, e.DeletedList, e.DeletedUser, e.AssignmentId, e.IsFollowUp, e.Ienumber }, "TimeAllocationForAllCondition");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ThrowTime }, "TimeAllocation_CallListID");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ThrowTime }, "TimeAllocation_ClientCampaignThriowTime");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "TimeAllocation_ClientIdWithThrowTime");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "TimeAllocation_DeletedData");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "TimeAllocation_ForAllUsersAndList");

                entity.HasIndex(e => new { e.ClientId, e.ThrowTime }, "TimeAllocation_MainCondition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.CampaignUserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Ienumber).HasColumnName("IENumber");

                entity.Property(e => e.IenumbersCount).HasColumnName("IENumbersCount");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeAllocationOpt>(entity =>
            {
                entity.ToTable("TimeAllocation_Opt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.CampaignUserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Ienumber).HasColumnName("IENumber");

                entity.Property(e => e.IenumbersCount).HasColumnName("IENumbersCount");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeAllocationTimeMetrixDatum>(entity =>
            {
                entity.ToTable("TimeAllocation_TimeMetrixData");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.PscreateDate }, "TimeAllocation_ClientIDAndListId_TimeMetrix");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.PscreateDate }, "TimeAllocation_ClientIdAndUserId");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.PscreateDate }, "TimeAllocation_DeletedUSersAndList");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.PscreateDate }, "TimeAllocation_UserListAndListID_New");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.CallListId).HasColumnName("CallListID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.ListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PscreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PSCreateDate");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usage>(entity =>
            {
                entity.ToTable("Usage");

                entity.HasIndex(e => new { e.ClientId, e.ActualDate }, "UsageReport_AllCondition");

                entity.HasIndex(e => new { e.ClientId, e.CallListId, e.ActualDate }, "UsageReport_ListID");

                entity.HasIndex(e => new { e.ClientId, e.CampaignUserId, e.ActualDate }, "UsageReport_UserId_ListID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.Attempt).HasDefaultValueSql("((0))");

                entity.Property(e => e.BadNumbers).HasDefaultValueSql("((0))");

                entity.Property(e => e.CallListId).HasColumnName("CallListID");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Connect).HasDefaultValueSql("((0))");

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Meeting).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
