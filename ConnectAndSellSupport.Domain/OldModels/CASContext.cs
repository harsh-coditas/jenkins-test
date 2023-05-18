using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CASContext : DbContext
    {
        public CASContext()
        {
        }

        public CASContext(DbContextOptions<CASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CasCompanyDisposition> CasCompanyDispositions { get; set; }
        public virtual DbSet<CasCompanySetting> CasCompanySettings { get; set; }
        public virtual DbSet<CasCompanySettingDetail> CasCompanySettingDetails { get; set; }
        public virtual DbSet<CasContact> CasContacts { get; set; }
        public virtual DbSet<CasConversationRating> CasConversationRatings { get; set; }
        public virtual DbSet<CasConversationTracking> CasConversationTrackings { get; set; }
        public virtual DbSet<CasList> CasLists { get; set; }
        public virtual DbSet<CasListContact> CasListContacts { get; set; }
        public virtual DbSet<CasMeeting> CasMeetings { get; set; }
        public virtual DbSet<CasMeetingInvitee> CasMeetingInvitees { get; set; }
        public virtual DbSet<CasNote> CasNotes { get; set; }
        public virtual DbSet<CasSiebelUserMapping> CasSiebelUserMappings { get; set; }
        public virtual DbSet<CasUser> CasUsers { get; set; }
        public virtual DbSet<TCall> TCalls { get; set; }
        public virtual DbSet<TCompany> TCompanies { get; set; }
        public virtual DbSet<TCountryInfo> TCountryInfos { get; set; }
        public virtual DbSet<TDnc> TDncs { get; set; }
        public virtual DbSet<TDncArchive> TDncArchives { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }

        public virtual DbSet<CasMasterJob> CasMasterJobs { get; set; }

        public virtual DbSet<CasJobsTriggeredDetails> CasJobsTriggeredDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<CasMasterJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                .HasName("PK__cas_mast__056690C216D66F2D");
                entity.ToTable("Cas_MasterJob");
                entity.Property(e => e.JobName).HasMaxLength(100);
                entity.Property(e => e.StartTime).HasColumnType("datetime");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasJobsTriggeredDetails>(entity =>
            {
                entity.HasKey(e => e.id)
                .HasName("PK__cas_jobs__3214EC077C289EA1");
                entity.ToTable("Cas_JobsTriggeredDetails");
                entity.Property(e => e.JobId);
                entity.Property(e => e.JobName).HasMaxLength(100);
                entity.Property(e => e.startTime).HasColumnType("datetime");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.jobStatus).HasMaxLength(100);
                entity.Property(e => e.InnerExceptionMessage).HasMaxLength(5000);
                entity.HasOne(d => d.MasterJob)
                .WithMany(e => e.CasJobsTriggeredDetails)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__cas_jobsT__JobId__46DEFF19");
            });

            modelBuilder.Entity<CasCompanyDisposition>(entity =>
            {
                entity.HasKey(e => e.CompanyDispositionId)
                    .HasName("PK_CompanyDisposition");

                entity.ToTable("cas_CompanyDisposition");

                entity.Property(e => e.ContactStatus).HasMaxLength(100);

                entity.Property(e => e.ContactSubStatus).HasMaxLength(100);

                entity.Property(e => e.CountAsConversion).HasColumnName("countAsConversion");

                entity.Property(e => e.Csvstatus)
                    .HasMaxLength(100)
                    .HasColumnName("CSVStatus");

                entity.Property(e => e.DispositionMode).HasDefaultValueSql("((3))");

                entity.Property(e => e.DispositionText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DispositionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeadStatus).HasMaxLength(100);

                entity.Property(e => e.LeadSubStatus).HasMaxLength(100);

                entity.Property(e => e.SecondaryDispositionId)
                    .HasMaxLength(500)
                    .HasColumnName("SecondaryDispositionID");

                entity.Property(e => e.SecondaryQuickListId).HasMaxLength(500);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasCompanyDispositions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_CompanyDisposition_t_Company");
            });

            modelBuilder.Entity<CasCompanySetting>(entity =>
            {
                entity.HasKey(e => e.CompanySettingId);

                entity.ToTable("cas_CompanySetting");

                entity.Property(e => e.LastModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasCompanySettings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_CompanySetting_t_Company");
            });

            modelBuilder.Entity<CasCompanySettingDetail>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("cas_CompanySetting_Details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SettingKey).HasMaxLength(50);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<CasContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("cas_Contact");

                entity.Property(e => e.AccountCity).HasMaxLength(1000);

                entity.Property(e => e.AccountState).HasMaxLength(1000);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallOnDays)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.IsDualSidedConversation).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInjectedContact).HasColumnName("isInjectedContact");

                entity.Property(e => e.IsPostInjectedContact).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.PostInjectedContactTime).HasColumnType("datetime");

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

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasContacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_Contact_t_User");
            });

            modelBuilder.Entity<CasConversationRating>(entity =>
            {
                entity.ToTable("cas_ConversationRating");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RateNote1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote7)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RateNoteBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasConversationTracking>(entity =>
            {
                entity.ToTable("cas_ConversationTracking");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RecordingListenedMap)
                    .IsRequired()
                    .HasMaxLength(105)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("cas_List");

                entity.HasIndex(e => e.UserId, "IDX_NC_cas_List_UserId");

                entity.Property(e => e.CallStarterText).IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultCallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DialToConnectRatio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsLeadInjectAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOodlist).HasColumnName("IsOODList");

                entity.Property(e => e.IsSmartList).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ListCampaignId)
                    .HasMaxLength(50)
                    .HasColumnName("ListCampaignID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SettingMetaData).IsUnicode(false);

                entity.Property(e => e.SfReportPath).HasMaxLength(1000);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_List_t_User");
            });

            modelBuilder.Entity<CasListContact>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.ContactId });

                entity.ToTable("cas_ListContact");

                entity.HasIndex(e => e.ContactId, "contactid_listid_idx");

                entity.HasIndex(e => e.ContactId, "ix_cas_ListContact_ContactId");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CasListContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_ListContact_cas_Contact");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasListContacts)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_ListContact_cas_List");
            });

            modelBuilder.Entity<CasMeeting>(entity =>
            {
                entity.HasKey(e => e.MeetingId);

                entity.ToTable("cas_Meeting");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceProvider).HasMaxLength(30);

                entity.Property(e => e.TimeZone).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<CasMeetingInvitee>(entity =>
            {
                entity.HasKey(e => e.MeetingInviteeId);

                entity.ToTable("cas_MeetingInvitee");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InviteeEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InviteeResponse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InviteeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.CasMeetingInvitees)
                    .HasForeignKey(d => d.MeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_MeetingInvitee_cas_Meeting");
            });

            modelBuilder.Entity<CasNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("cas_Note");

                entity.HasIndex(e => new { e.ContactId, e.IsConversation, e.CreateDate }, "IX_CasNote_ContactID_Conversation_CreateDate");

                entity.Property(e => e.CallSentiment).HasMaxLength(1000);

                entity.HasIndex(e => e.LeadTransitId, "IX_cas_Note_LeadTransistId");

                entity.Property(e => e.Disposition).HasMaxLength(50);

                entity.Property(e => e.IsBlindLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCheckedForReview).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.IsConversation)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextSteps).HasMaxLength(2000);

                entity.Property(e => e.ReviewDescription)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CasNotes)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_Note_cas_Contact");
            });

            modelBuilder.Entity<CasSiebelUserMapping>(entity =>
            {
                entity.ToTable("cas_SiebelUserMapping");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiebelUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasUser>(entity =>
            {
                entity.ToTable("cas_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");

                entity.Property(e => e.LockedOutOn).HasColumnType("datetime");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasMaxLength(7)
                    .HasColumnName("OTP");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PasswordChangedOn).HasColumnType("datetime");

                entity.Property(e => e.PasswordResetExpiresOn).HasColumnType("datetime");

                entity.Property(e => e.PasswordResetToken).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cas_User__UserId__3A379A64");
            });

            modelBuilder.Entity<TCall>(entity =>
            {
                entity.ToTable("t_Call");

                entity.HasIndex(e => new { e.ClientName, e.ThrowTime }, "IDX_NC_t_Call_ClientNameThrowtime");

                entity.HasIndex(e => new { e.CallListId, e.IsConversation }, "IDX_NC_t_call_CallListIdIsConversation");

                entity.HasIndex(e => new { e.Id, e.ThrowTime }, "IDX_NC_t_call_IDThrowTime");

                entity.HasIndex(e => new { e.ThrowTime, e.ProblemCodes }, "IDX_NC_t_call_ThrowtimeProblemCodes");

                entity.HasIndex(e => e.ClientName, "IX_t_Call");

                entity.HasIndex(e => e.LeadId, "IX_t_Call_AttemptedLeads");

                entity.HasIndex(e => e.CampaignName, "IX_t_Call_CampaignName");

                entity.HasIndex(e => e.ClientName, "IX_t_Call_ClientName");

                entity.HasIndex(e => e.ContactId, "IX_t_Call_Contactid");

                entity.HasIndex(e => e.CreateDate, "IX_t_Call_CreateDate");

                entity.HasIndex(e => e.LeadTransitId, "IX_t_Call_LinkID");

                entity.HasIndex(e => e.SessionId, "IX_t_Call_SessionID");

                entity.HasIndex(e => new { e.ThrowTime, e.EndTime }, "IX_t_Call_ThrowTime_EndTime");

                entity.HasIndex(e => e.UserName, "IX_t_Call_UserName");

                entity.HasIndex(e => e.UserRole, "IX_t_Call_UserRole");

                entity.HasIndex(e => e.VoicemailLeft, "IX_t_Call_VoiceMailLeft");

                entity.HasIndex(e => e.ContactTel1, "NonClusteredIndex-20150817-021414");

                entity.HasIndex(e => e.ContactTel2, "NonClusteredIndex-20150817-021513");

                entity.HasIndex(e => new { e.ContactId, e.Id, e.CreateDate, e.CallListId }, "_dta_index_t_Call_5_1330103779__K80_K1_K62");

                entity.HasIndex(e => new { e.IsValidConnect, e.ClientName, e.Id, e.EndTime, e.CampaignName, e.DispositionText }, "_dta_index_t_Call_6_1330103779__K77_K4_K1_K13_K7_K22_69");

                entity.HasIndex(e => new { e.Id, e.ThrowTime }, "_dta_index_t_Call_7_1330103779__K1_K10");

                entity.HasIndex(e => new { e.CallListId, e.DispositionText, e.ThrowTime, e.ClientName, e.UserName, e.SessionId, e.CampaignName }, "_dta_index_t_Call_7_1330103779__K81_K22_K10_K4_K5_K73_K7_1_77_83");

                entity.HasIndex(e => e.ClientName, "idx_SS_t_Call_ClientName");

                entity.HasIndex(e => new { e.UserName, e.ThrowTime }, "idx_SS_t_Call_Username_Throwtime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CallType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientId).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.IsConnectOnHello).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsReferral).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTransfer).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadCatchTime).HasColumnType("datetime");

                entity.Property(e => e.LeadListName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeadSendTime).HasColumnType("datetime");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.NameCatchTime).HasColumnType("datetime");

                entity.Property(e => e.NoteText).IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCompany>(entity =>
            {
                entity.ToTable("t_Company");

                entity.HasIndex(e => e.Identifier, "IX_t_Company")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

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

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.CrmLoginMask)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CrmUrlFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

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

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDispositionRequired)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVoicemailEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.Overview).IsUnicode(false);

                entity.Property(e => e.PreferredCrm)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Salesforce')");

                entity.Property(e => e.Priority).HasDefaultValueSql("((5))");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

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

                entity.Property(e => e.Sla).HasDefaultValueSql("((7))");

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

            modelBuilder.Entity<TCountryInfo>(entity =>
            {
                entity.ToTable("t_CountryInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DomesticFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IddCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntlFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Iso2Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iso3Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NddCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoCountryCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.RootName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDnc>(entity =>
            {
                entity.ToTable("t_Dnc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires")
                    .HasDefaultValueSql("('2000-01-01')");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientCompanyNavigation)
                    .WithMany(p => p.TDncs)
                    .HasForeignKey(d => d.ClientCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Dnc_t_Company");
            });

            modelBuilder.Entity<TDncArchive>(entity =>
            {
                entity.ToTable("t_Dnc_Archive");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ArchiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ArchiveUserId).HasColumnName("ArchiveUserID");

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires")
                    .HasDefaultValueSql("('2000-01-01')");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ArchiveUser)
                    .WithMany(p => p.TDncArchives)
                    .HasForeignKey(d => d.ArchiveUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Dnc_Archive_t_ArchiveUserID");

                entity.HasOne(d => d.ClientCompanyNavigation)
                    .WithMany(p => p.TDncArchives)
                    .HasForeignKey(d => d.ClientCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Dnc_Archive_t_Company");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("t_User");

                entity.HasIndex(e => e.CompanyName, "IX_t_User_CompanyName");

                entity.HasIndex(e => new { e.DomainId, e.IsDeleted }, "IX_t_User_DomainId_IsDeleted");

                entity.HasIndex(e => e.Identifier, "IX_t_User_Identifier");

                entity.HasIndex(e => e.IsDeleted, "IX_t_User_IsDeleted");

                entity.HasIndex(e => e.LoginId, "IX_t_User_LoginId");

                entity.HasIndex(e => new { e.LoginId, e.IsDeleted }, "IX_t_User_LoginId_IsDeleted");

                entity.HasIndex(e => e.UserName, "IX_t_User_UserName");

                entity.HasIndex(e => new { e.Commented, e.Filename }, "filename_comment");

                entity.Property(e => e.Id).HasColumnName("ID");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CatMetric).HasColumnName("cat_metric");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("category")
                    .HasDefaultValueSql("('default')");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colvpriority).HasColumnName("COLVPriority");

                entity.Property(e => e.Colvsla).HasColumnName("COLVSla");

                entity.Property(e => e.Commented).HasColumnName("commented");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.DataSourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DomainId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DotNetVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.InviteAlertMinutes).HasDefaultValueSql("((60))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageSkills).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('(none)')");

                entity.Property(e => e.LoginEmailId)
                    .IsUnicode(false)
                    .HasColumnName("LoginEmailID");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginPageFragment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.RequiresDispositions)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TUsers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_User_t_Company");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
