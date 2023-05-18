using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConnectAndSellSupport.Domain.Models;

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

        public virtual DbSet<AgentCallSendTime> AgentCallSendTimes { get; set; }
        public virtual DbSet<AttemptData2> AttemptData2s { get; set; }
        public virtual DbSet<AttemptDataNew> AttemptDataNews { get; set; }
        public virtual DbSet<AttemptDateWithContactId> AttemptDateWithContactIds { get; set; }
        public virtual DbSet<AttemptDatum> AttemptData { get; set; }
        public virtual DbSet<AttemptedNumber> AttemptedNumbers { get; set; }
        public virtual DbSet<AutoLeOnIeAnalysis> AutoLeOnIeAnalyses { get; set; }
        public virtual DbSet<AutomaticTimeZoneMapper> AutomaticTimeZoneMappers { get; set; }
        public virtual DbSet<BackupCasListContact> BackupCasListContacts { get; set; }
        public virtual DbSet<BadRedisNumber> BadRedisNumbers { get; set; }
        public virtual DbSet<CallId> CallIds { get; set; }
        public virtual DbSet<CallMapper> CallMappers { get; set; }
        public virtual DbSet<CallerIdBackup> CallerIdBackups { get; set; }
        public virtual DbSet<CasActiveCompany> CasActiveCompanies { get; set; }
        public virtual DbSet<CasAgentDispositionMap> CasAgentDispositionMaps { get; set; }
        public virtual DbSet<CasAgentDispositionMapDetail> CasAgentDispositionMapDetails { get; set; }
        public virtual DbSet<CasAllSfOpportunity> CasAllSfOpportunities { get; set; }
        public virtual DbSet<CasAttemptAndConversationSummary> CasAttemptAndConversationSummaries { get; set; }
        public virtual DbSet<CasAttributionMapping> CasAttributionMappings { get; set; }
        public virtual DbSet<CasAttributionMappingBack> CasAttributionMappingBacks { get; set; }
        public virtual DbSet<CasBadNumber> CasBadNumbers { get; set; }
        public virtual DbSet<CasCallLog> CasCallLogs { get; set; }
        public virtual DbSet<CasCallPreference> CasCallPreferences { get; set; }
        public virtual DbSet<CasCasListTeam> CasCasListTeams { get; set; }
        public virtual DbSet<CasCategoryAndRating> CasCategoryAndRatings { get; set; }
        public virtual DbSet<CasCloneSetting> CasCloneSettings { get; set; }
        public virtual DbSet<CasCompanyDisposition> CasCompanyDispositions { get; set; }
        public virtual DbSet<CasCompanySetting> CasCompanySettings { get; set; }
        public virtual DbSet<CasCompanySetting050421> CasCompanySetting050421s { get; set; }
        public virtual DbSet<CasCompanySettingBckp> CasCompanySettingBckps { get; set; }
        public virtual DbSet<CasCompanySettingConnectedNumber> CasCompanySettingConnectedNumbers { get; set; }
        public virtual DbSet<CasCompanySettingDetail> CasCompanySettingDetails { get; set; }
        public virtual DbSet<CasCompanysettingSfdc0829> CasCompanysettingSfdc0829s { get; set; }
        public virtual DbSet<CasCompanysettingbackup0912> CasCompanysettingbackup0912s { get; set; }
        public virtual DbSet<CasCompiledCtr> CasCompiledCtrs { get; set; }
        public virtual DbSet<CasCompiledRtsr> CasCompiledRtsrs { get; set; }
        public virtual DbSet<CasConnect> CasConnects { get; set; }
        public virtual DbSet<CasConnectBackup> CasConnectBackups { get; set; }
        public virtual DbSet<CasConnectLatest> CasConnectLatests { get; set; }
        public virtual DbSet<CasContact> CasContacts { get; set; }
        public virtual DbSet<CasContact20211111> CasContact20211111s { get; set; }
        public virtual DbSet<CasContactDailyDatum> CasContactDailyData { get; set; }
        public virtual DbSet<CasContactDemo> CasContactDemos { get; set; }
        public virtual DbSet<CasContactSm> CasContactSms { get; set; }
        public virtual DbSet<CasConversationRating> CasConversationRatings { get; set; }
        public virtual DbSet<CasConversationRatingOriginal> CasConversationRatingOriginals { get; set; }
        public virtual DbSet<CasConversationTracking> CasConversationTrackings { get; set; }
        public virtual DbSet<CasCountryDialInNumber> CasCountryDialInNumbers { get; set; }
        public virtual DbSet<CasCrmfilter> CasCrmfilters { get; set; }
        public virtual DbSet<CasCrmfilter23740> CasCrmfilter23740s { get; set; }
        public virtual DbSet<CasCrmfilter23741> CasCrmfilter23741s { get; set; }
        public virtual DbSet<CasDailyDialsRawDataAllGc> CasDailyDialsRawDataAllGcs { get; set; }
        public virtual DbSet<CasDailyDialsRawDatum> CasDailyDialsRawData { get; set; }
        public virtual DbSet<CasDbversion> CasDbversions { get; set; }
        public virtual DbSet<CasDefaultCompanySetting> CasDefaultCompanySettings { get; set; }
        public virtual DbSet<CasDncBackUp> CasDncBackUps { get; set; }
        public virtual DbSet<CasDuplicateContact> CasDuplicateContacts { get; set; }
        public virtual DbSet<CasDuplicateContact2> CasDuplicateContact2s { get; set; }
        public virtual DbSet<CasDuplicateContact23740> CasDuplicateContact23740s { get; set; }
        public virtual DbSet<CasDuplicateContact23741> CasDuplicateContact23741s { get; set; }
        public virtual DbSet<CasEmailTemplate> CasEmailTemplates { get; set; }
        public virtual DbSet<CasEnvironmentInfo> CasEnvironmentInfos { get; set; }
        public virtual DbSet<CasErrorneousRecording> CasErrorneousRecordings { get; set; }
        public virtual DbSet<CasEtllog> CasEtllogs { get; set; }
        public virtual DbSet<CasFieldPriority> CasFieldPriorities { get; set; }
        public virtual DbSet<CasFutptemplate> CasFutptemplates { get; set; }
        public virtual DbSet<CasGdprcontact> CasGdprcontacts { get; set; }
        public virtual DbSet<CasGdprrequest> CasGdprrequests { get; set; }
        public virtual DbSet<CasGoal> CasGoals { get; set; }
        public virtual DbSet<CasGoalDataDailyDatum> CasGoalDataDailyData { get; set; }
        public virtual DbSet<CasGoalDatum> CasGoalData { get; set; }
        public virtual DbSet<CasGoalTarhet> CasGoalTarhets { get; set; }
        public virtual DbSet<CasJobsTriggeredDetail> CasJobsTriggeredDetails { get; set; }
        public virtual DbSet<CasLeadCompany> CasLeadCompanies { get; set; }
        public virtual DbSet<CasLightningParameter> CasLightningParameters { get; set; }
        public virtual DbSet<CasList> CasLists { get; set; }
        public virtual DbSet<CasList14may> CasList14mays { get; set; }
        public virtual DbSet<CasListCalendar> CasListCalendars { get; set; }
        public virtual DbSet<CasListContact> CasListContacts { get; set; }
        public virtual DbSet<CasListContact23740> CasListContact23740s { get; set; }
        public virtual DbSet<CasListContact23741> CasListContact23741s { get; set; }
        public virtual DbSet<CasListContactBackup> CasListContactBackups { get; set; }
        public virtual DbSet<CasListContactCustom> CasListContactCustoms { get; set; }
        public virtual DbSet<CasListContactSetting> CasListContactSettings { get; set; }
        public virtual DbSet<CasListEnrichSummary> CasListEnrichSummaries { get; set; }
        public virtual DbSet<CasListRule> CasListRules { get; set; }
        public virtual DbSet<CasListRuleBackup> CasListRuleBackups { get; set; }
        public virtual DbSet<CasListScore> CasListScores { get; set; }
        public virtual DbSet<CasListTag> CasListTags { get; set; }
        public virtual DbSet<CasListTeam> CasListTeams { get; set; }
        public virtual DbSet<CasListType> CasListTypes { get; set; }
        public virtual DbSet<CasListUser> CasListUsers { get; set; }
        public virtual DbSet<CasListUserBackup4Feb> CasListUserBackup4Febs { get; set; }
        public virtual DbSet<CasLog> CasLogs { get; set; }
        public virtual DbSet<CasManagementObjectDataHistory> CasManagementObjectDataHistories { get; set; }
        public virtual DbSet<CasManagementObjectDatum> CasManagementObjectData { get; set; }
        public virtual DbSet<CasManagementReportDl> CasManagementReportDls { get; set; }
        public virtual DbSet<CasMandatoryList> CasMandatoryLists { get; set; }
        public virtual DbSet<CasMandatoryListsBackUp20201027> CasMandatoryListsBackUp20201027s { get; set; }
        public virtual DbSet<CasMapping> CasMappings { get; set; }
        public virtual DbSet<CasMapping1> CasMapping1s { get; set; }
        public virtual DbSet<CasMappingBackUp20200528> CasMappingBackUp20200528s { get; set; }
        public virtual DbSet<CasMappingField> CasMappingFields { get; set; }
        public virtual DbSet<CasMappingField1> CasMappingField1s { get; set; }
        public virtual DbSet<CasMappingFieldBackUp20200528> CasMappingFieldBackUp20200528s { get; set; }
        public virtual DbSet<CasMappingbackup> CasMappingbackups { get; set; }
        public virtual DbSet<CasMappingfieldbackup> CasMappingfieldbackups { get; set; }
        public virtual DbSet<CasMasterJob> CasMasterJobs { get; set; }
        public virtual DbSet<CasMatching> CasMatchings { get; set; }
        public virtual DbSet<CasMatchingDetail> CasMatchingDetails { get; set; }
        public virtual DbSet<CasMeeting> CasMeetings { get; set; }
        public virtual DbSet<CasMeetingInvitee> CasMeetingInvitees { get; set; }
        public virtual DbSet<CasMultiTouchListContact> CasMultiTouchListContacts { get; set; }
        public virtual DbSet<CasMultitouchAction> CasMultitouchActions { get; set; }
        public virtual DbSet<CasMultitouchContactEffect> CasMultitouchContactEffects { get; set; }
        public virtual DbSet<CasMultitouchRule> CasMultitouchRules { get; set; }
        public virtual DbSet<CasNextGenTaskInfo> CasNextGenTaskInfos { get; set; }
        public virtual DbSet<CasNextGenTaskInfo5174> CasNextGenTaskInfo5174s { get; set; }
        public virtual DbSet<CasNonBaseMappingField> CasNonBaseMappingFields { get; set; }
        public virtual DbSet<CasNotAttempted> CasNotAttempteds { get; set; }
        public virtual DbSet<CasNote> CasNotes { get; set; }
        public virtual DbSet<CasNote30jan23> CasNote30jan23s { get; set; }
        public virtual DbSet<CasNote31jan23> CasNote31jan23s { get; set; }
        public virtual DbSet<CasOutreachSfSync> CasOutreachSfSyncs { get; set; }
        public virtual DbSet<CasPbdispositionConfiguration> CasPbdispositionConfigurations { get; set; }
        public virtual DbSet<CasPbrule> CasPbrules { get; set; }
        public virtual DbSet<CasPbruleAction> CasPbruleActions { get; set; }
        public virtual DbSet<CasPbruleGroup> CasPbruleGroups { get; set; }
        public virtual DbSet<CasPbruleGroupValueMapping> CasPbruleGroupValueMappings { get; set; }
        public virtual DbSet<CasPbruleReport> CasPbruleReports { get; set; }
        public virtual DbSet<CasPbruleValue> CasPbruleValues { get; set; }
        public virtual DbSet<CasPbtemp> CasPbtemps { get; set; }
        public virtual DbSet<CasPbtemp2> CasPbtemp2s { get; set; }
        public virtual DbSet<CasPbtempF> CasPbtempFs { get; set; }
        public virtual DbSet<CasPbwrong> CasPbwrongs { get; set; }
        public virtual DbSet<CasPbwrong2> CasPbwrong2s { get; set; }
        public virtual DbSet<CasPbwrongF> CasPbwrongFs { get; set; }
        public virtual DbSet<CasPenalizedPhoneNumber> CasPenalizedPhoneNumbers { get; set; }
        public virtual DbSet<CasPenalizedPhoneNumberFisher> CasPenalizedPhoneNumberFishers { get; set; }
        public virtual DbSet<CasPenaltyBoxAudit> CasPenaltyBoxAudits { get; set; }
        public virtual DbSet<CasPenaltyBoxAuditFisher> CasPenaltyBoxAuditFishers { get; set; }
        public virtual DbSet<CasPitcherSessiondatum> CasPitcherSessiondata { get; set; }
        public virtual DbSet<CasPriorityMapping> CasPriorityMappings { get; set; }
        public virtual DbSet<CasProblemDispositionsDetail> CasProblemDispositionsDetails { get; set; }
        public virtual DbSet<CasRealTimeAlertForTeamSetting> CasRealTimeAlertForTeamSettings { get; set; }
        public virtual DbSet<CasRecordingDetail> CasRecordingDetails { get; set; }
        public virtual DbSet<CasSamlMapping> CasSamlMappings { get; set; }
        public virtual DbSet<CasScoreCard> CasScoreCards { get; set; }
        public virtual DbSet<CasSessionScheduling> CasSessionSchedulings { get; set; }
        public virtual DbSet<CasSfOpportunity> CasSfOpportunities { get; set; }
        public virtual DbSet<CasSfOpportunity0419> CasSfOpportunity0419s { get; set; }
        public virtual DbSet<CasSfOpportunityHistory> CasSfOpportunityHistories { get; set; }
        public virtual DbSet<CasSfOpportunityHistory0419> CasSfOpportunityHistory0419s { get; set; }
        public virtual DbSet<CasSfOpportunityHistoryLatest> CasSfOpportunityHistoryLatests { get; set; }
        public virtual DbSet<CasSfOpportunityHistoryRc> CasSfOpportunityHistoryRcs { get; set; }
        public virtual DbSet<CasSfOpportunityLatest> CasSfOpportunityLatests { get; set; }
        public virtual DbSet<CasSfOpportunityRc> CasSfOpportunityRcs { get; set; }
        public virtual DbSet<CasShareRecordingHash> CasShareRecordingHashes { get; set; }
        public virtual DbSet<CasSiebelUserMapping> CasSiebelUserMappings { get; set; }
        public virtual DbSet<CasTaskDetail> CasTaskDetails { get; set; }
        public virtual DbSet<CasTeam> CasTeams { get; set; }
        public virtual DbSet<CasTrigger> CasTriggers { get; set; }
        public virtual DbSet<CasTriggerAction> CasTriggerActions { get; set; }
        public virtual DbSet<CasTriggerCondition> CasTriggerConditions { get; set; }
        public virtual DbSet<CasTriggerContactEffect> CasTriggerContactEffects { get; set; }
        public virtual DbSet<CasTriggerError> CasTriggerErrors { get; set; }
        public virtual DbSet<CasTriggerGroup> CasTriggerGroups { get; set; }
        public virtual DbSet<CasTriggerGroupConditionMapping> CasTriggerGroupConditionMappings { get; set; }
        public virtual DbSet<CasTriggerList> CasTriggerLists { get; set; }
        public virtual DbSet<CasTriggerProspectRemovedFromList> CasTriggerProspectRemovedFromLists { get; set; }
        public virtual DbSet<CasTriggerTaskConfig> CasTriggerTaskConfigs { get; set; }
        public virtual DbSet<CasTriggerVoicemail> CasTriggerVoicemails { get; set; }
        public virtual DbSet<CasUser> CasUsers { get; set; }
        public virtual DbSet<CasUserArticleViewMapping> CasUserArticleViewMappings { get; set; }
        public virtual DbSet<CasUserContactAolist> CasUserContactAolists { get; set; }
        public virtual DbSet<CasUserEnvironmentMapper> CasUserEnvironmentMappers { get; set; }
        public virtual DbSet<CasUserGreeting> CasUserGreetings { get; set; }
        public virtual DbSet<CasUserInvitation> CasUserInvitations { get; set; }
        public virtual DbSet<CasUserSession> CasUserSessions { get; set; }
        public virtual DbSet<CasUserSetting> CasUserSettings { get; set; }
        public virtual DbSet<CasUserVoicemail> CasUserVoicemails { get; set; }
        public virtual DbSet<CasValvalTemp> CasValvalTemps { get; set; }
        public virtual DbSet<CasVarval> CasVarvals { get; set; }
        public virtual DbSet<CasWriteback> CasWritebacks { get; set; }
        public virtual DbSet<CasZendeskArticle> CasZendeskArticles { get; set; }
        public virtual DbSet<CgAttribute> CgAttributes { get; set; }
        public virtual DbSet<ChangePwd> ChangePwds { get; set; }
        public virtual DbSet<CiCastIronTLead> CiCastIronTLeads { get; set; }
        public virtual DbSet<ClosedFacility> ClosedFacilities { get; set; }
        public virtual DbSet<CompanyCompare> CompanyCompares { get; set; }
        public virtual DbSet<CompanyNameMismatchDatum> CompanyNameMismatchData { get; set; }
        public virtual DbSet<ConnectCount> ConnectCounts { get; set; }
        public virtual DbSet<ContactNumber> ContactNumbers { get; set; }
        public virtual DbSet<ContactSightCommunication> ContactSightCommunications { get; set; }
        public virtual DbSet<ContactbckpSandlerSharper> ContactbckpSandlerSharpers { get; set; }
        public virtual DbSet<CrmidAttempt> CrmidAttempts { get; set; }
        public virtual DbSet<CrmtypeMaster> CrmtypeMasters { get; set; }
        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<DbaLoadStatus> DbaLoadStatuses { get; set; }
        public virtual DbSet<DeletedContactId> DeletedContactIds { get; set; }
        public virtual DbSet<DirectNumber0821> DirectNumber0821s { get; set; }
        public virtual DbSet<DncAll> DncAlls { get; set; }
        public virtual DbSet<DncFinal> DncFinals { get; set; }
        public virtual DbSet<DncFinal2> DncFinal2s { get; set; }
        public virtual DbSet<DncFinalF> DncFinalves { get; set; }
        public virtual DbSet<DncP1> DncP1s { get; set; }
        public virtual DbSet<DncP2> DncP2s { get; set; }
        public virtual DbSet<DncRem> DncRems { get; set; }
        public virtual DbSet<DncRemaining> DncRemainings { get; set; }
        public virtual DbSet<DuplicateWrongDatum> DuplicateWrongData { get; set; }
        public virtual DbSet<FisherBadDuplicate> FisherBadDuplicates { get; set; }
        public virtual DbSet<FuzzyCompany> FuzzyCompanies { get; set; }
        public virtual DbSet<FuzzyCompany2> FuzzyCompany2s { get; set; }
        public virtual DbSet<FuzzyCompanyFinalMatch> FuzzyCompanyFinalMatches { get; set; }
        public virtual DbSet<FuzzyCompanyFinalMatchAll> FuzzyCompanyFinalMatchAlls { get; set; }
        public virtual DbSet<FuzzyCompanyFinalMatchBackup> FuzzyCompanyFinalMatchBackups { get; set; }
        public virtual DbSet<FuzzyCompanyTempMatch> FuzzyCompanyTempMatches { get; set; }
        public virtual DbSet<FuzzyMatchedCompanyName> FuzzyMatchedCompanyNames { get; set; }
        public virtual DbSet<HubspotObjectRecord> HubspotObjectRecords { get; set; }
        public virtual DbSet<JobHistoryByCompany> JobHistoryByCompanies { get; set; }
        public virtual DbSet<Jsontemp> Jsontemps { get; set; }
        public virtual DbSet<LatestDataNoAttempt> LatestDataNoAttempts { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<LeadTime30jan23> LeadTime30jan23s { get; set; }
        public virtual DbSet<ListContactSightCommunication> ListContactSightCommunications { get; set; }
        public virtual DbSet<ListTypeDatum> ListTypeData { get; set; }
        public virtual DbSet<LogTable> LogTables { get; set; }
        public virtual DbSet<MappingBak> MappingBaks { get; set; }
        public virtual DbSet<MappingDatum> MappingData { get; set; }
        public virtual DbSet<MappingFieldBak> MappingFieldBaks { get; set; }
        public virtual DbSet<MlAreaCode> MlAreaCodes { get; set; }
        public virtual DbSet<MlCompany> MlCompanies { get; set; }
        public virtual DbSet<MlCompanyNormalizationMapping> MlCompanyNormalizationMappings { get; set; }
        public virtual DbSet<MlTitle> MlTitles { get; set; }
        public virtual DbSet<MlTitleLookup> MlTitleLookups { get; set; }
        public virtual DbSet<NegativeTalkTime> NegativeTalkTimes { get; set; }
        public virtual DbSet<NodeFollowUpDeletedContact> NodeFollowUpDeletedContacts { get; set; }
        public virtual DbSet<NodeLeadPoolDeletedContact> NodeLeadPoolDeletedContacts { get; set; }
        public virtual DbSet<NotAttempted> NotAttempteds { get; set; }
        public virtual DbSet<Opportunitiesfq> Opportunitiesfqs { get; set; }
        public virtual DbSet<PhoneId> PhoneIds { get; set; }
        public virtual DbSet<PitcherSessionBackup> PitcherSessionBackups { get; set; }
        public virtual DbSet<PreviewRequest> PreviewRequests { get; set; }
        public virtual DbSet<PreviewRequestKey> PreviewRequestKeys { get; set; }
        public virtual DbSet<PreviewRequestResult> PreviewRequestResults { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<ResourceLock> ResourceLocks { get; set; }
        public virtual DbSet<ResourceLockHistory> ResourceLockHistories { get; set; }
        public virtual DbSet<SAttemptHistorySummary> SAttemptHistorySummaries { get; set; }
        public virtual DbSet<SAttemptSummary> SAttemptSummaries { get; set; }
        public virtual DbSet<SCallsSummary> SCallsSummaries { get; set; }
        public virtual DbSet<SConnectsSummary> SConnectsSummaries { get; set; }
        public virtual DbSet<SLeaderBoardSummary> SLeaderBoardSummaries { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SessionActivity> SessionActivities { get; set; }
        public virtual DbSet<SessionNote> SessionNotes { get; set; }
        public virtual DbSet<SettingsBak> SettingsBaks { get; set; }
        public virtual DbSet<SightCommunication> SightCommunications { get; set; }
        public virtual DbSet<Summary> Summaries { get; set; }
        public virtual DbSet<Summry2> Summry2s { get; set; }
        public virtual DbSet<T1> T1s { get; set; }
        public virtual DbSet<TAccountHistory> TAccountHistories { get; set; }
        public virtual DbSet<TActivity> TActivities { get; set; }
        public virtual DbSet<TAgentActivity> TAgentActivities { get; set; }
        public virtual DbSet<TAgentNote> TAgentNotes { get; set; }
        public virtual DbSet<TAgentSession> TAgentSessions { get; set; }
        public virtual DbSet<TAsteriskRef> TAsteriskRefs { get; set; }
        public virtual DbSet<TAsteriskRef07092021> TAsteriskRef07092021s { get; set; }
        public virtual DbSet<TBilledSession> TBilledSessions { get; set; }
        public virtual DbSet<TCall> TCalls { get; set; }
        public virtual DbSet<TCall30jan23> TCall30jan23s { get; set; }
        public virtual DbSet<TCall30jan232> TCall30jan232s { get; set; }
        public virtual DbSet<TCall31jan23> TCall31jan23s { get; set; }
        public virtual DbSet<TCallArchiveDataApril2018> TCallArchiveDataApril2018s { get; set; }
        public virtual DbSet<TCallArchiveDataCommonDatum> TCallArchiveDataCommonData { get; set; }
        public virtual DbSet<TCallArchiveDataJune> TCallArchiveDataJunes { get; set; }
        public virtual DbSet<TCallArchiveDatum> TCallArchiveData { get; set; }
        public virtual DbSet<TCallBackup24July> TCallBackup24Julies { get; set; }
        public virtual DbSet<TCallBkp> TCallBkps { get; set; }
        public virtual DbSet<TCallFirstqt> TCallFirstqts { get; set; }
        public virtual DbSet<TCallFuzzy> TCallFuzzies { get; set; }
        public virtual DbSet<TCallKry> TCallKrys { get; set; }
        public virtual DbSet<TCallNA> TCallNAs { get; set; }
        public virtual DbSet<TCallWrongDatum> TCallWrongData { get; set; }
        public virtual DbSet<TCallbckp> TCallbckps { get; set; }
        public virtual DbSet<TCallerId> TCallerIds { get; set; }
        public virtual DbSet<TCallerId20220629> TCallerId20220629s { get; set; }
        public virtual DbSet<TCallerIdBkp> TCallerIdBkps { get; set; }
        public virtual DbSet<TCallerIdMapping> TCallerIdMappings { get; set; }
        public virtual DbSet<TCallerIdUsBackup> TCallerIdUsBackups { get; set; }
        public virtual DbSet<TCallerIdbckup> TCallerIdbckups { get; set; }
        public virtual DbSet<TCampaign> TCampaigns { get; set; }
        public virtual DbSet<TCompany> TCompanies { get; set; }
        public virtual DbSet<TContact> TContacts { get; set; }
        public virtual DbSet<TContactPhoneNumber> TContactPhoneNumbers { get; set; }
        public virtual DbSet<TContactSummary> TContactSummaries { get; set; }
        public virtual DbSet<TContactSummaryMergedDatum> TContactSummaryMergedData { get; set; }
        public virtual DbSet<TContactSummaryNewDatum> TContactSummaryNewData { get; set; }
        public virtual DbSet<TContract> TContracts { get; set; }
        public virtual DbSet<TContractAppendix> TContractAppendices { get; set; }
        public virtual DbSet<TCountryInfo> TCountryInfos { get; set; }
        public virtual DbSet<TCrmParamSet> TCrmParamSets { get; set; }
        public virtual DbSet<TDisposition> TDispositions { get; set; }
        public virtual DbSet<TDispositionMap> TDispositionMaps { get; set; }
        public virtual DbSet<TDnc> TDncs { get; set; }
        public virtual DbSet<TDncArchive> TDncArchives { get; set; }
        public virtual DbSet<TDncCall> TDncCalls { get; set; }
        public virtual DbSet<TDncCall2> TDncCall2s { get; set; }
        public virtual DbSet<TDncCallF> TDncCallves { get; set; }
        public virtual DbSet<TDncCas20210107> TDncCas20210107s { get; set; }
        public virtual DbSet<TDncCasNg20210107> TDncCasNg20210107s { get; set; }
        public virtual DbSet<TDncPb> TDncPbs { get; set; }
        public virtual DbSet<TDncPb2> TDncPb2s { get; set; }
        public virtual DbSet<TDncPbF> TDncPbFs { get; set; }
        public virtual DbSet<TDstDate> TDstDates { get; set; }
        public virtual DbSet<TDxAppointment> TDxAppointments { get; set; }
        public virtual DbSet<TEngineAllocatedActivity> TEngineAllocatedActivities { get; set; }
        public virtual DbSet<TExecuteLogStg> TExecuteLogStgs { get; set; }
        public virtual DbSet<TLead> TLeads { get; set; }
        public virtual DbSet<TLeadAppStat> TLeadAppStats { get; set; }
        public virtual DbSet<TLeadHistory> TLeadHistories { get; set; }
        public virtual DbSet<TMultiTouchLog> TMultiTouchLogs { get; set; }
        public virtual DbSet<TName> TNames { get; set; }
        public virtual DbSet<TNote> TNotes { get; set; }
        public virtual DbSet<TPayment> TPayments { get; set; }
        public virtual DbSet<TPhoneCall> TPhoneCalls { get; set; }
        public virtual DbSet<TPhoneNumber> TPhoneNumbers { get; set; }
        public virtual DbSet<TPitcherSession> TPitcherSessions { get; set; }
        public virtual DbSet<TPitcherSessionDi> TPitcherSessionDis { get; set; }
        public virtual DbSet<TPitcherSessionKry> TPitcherSessionKrys { get; set; }
        public virtual DbSet<TQuery> TQueries { get; set; }
        public virtual DbSet<TQueryTerm> TQueryTerms { get; set; }
        public virtual DbSet<TRolesHistory> TRolesHistories { get; set; }
        public virtual DbSet<TScheduledSession> TScheduledSessions { get; set; }
        public virtual DbSet<TScript> TScripts { get; set; }
        public virtual DbSet<TSession> TSessions { get; set; }
        public virtual DbSet<TSpecialInstruction> TSpecialInstructions { get; set; }
        public virtual DbSet<TSys20210725> TSys20210725s { get; set; }
        public virtual DbSet<TSystemParameter> TSystemParameters { get; set; }
        public virtual DbSet<TTriggerLog> TTriggerLogs { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TUser20210711> TUser20210711s { get; set; }
        public virtual DbSet<TUser20222803> TUser20222803s { get; set; }
        public virtual DbSet<TUserBk> TUserBks { get; set; }
        public virtual DbSet<TableSize> TableSizes { get; set; }
        public virtual DbSet<Temp1> Temp1s { get; set; }
        public virtual DbSet<TempAttemptcount> TempAttemptcounts { get; set; }
        public virtual DbSet<TempPenalizedDnc> TempPenalizedDncs { get; set; }
        public virtual DbSet<TimeMetrix> TimeMetrixes { get; set; }
        public virtual DbSet<TitleDictionary> TitleDictionaries { get; set; }
        public virtual DbSet<TransitId> TransitIds { get; set; }
        public virtual DbSet<Typelkp> Typelkps { get; set; }
        public virtual DbSet<Used1> Used1s { get; set; }
        public virtual DbSet<WrapTimeReport> WrapTimeReports { get; set; }
        public virtual DbSet<WrongContactDatum> WrongContactData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AgentCallSendTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgentCallSendTime");

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTransitId).HasColumnName("LeadTransitID");

                entity.Property(e => e.PopUpTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttemptData2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttemptData_2");

                entity.Property(e => e.AttemptedByAutoAgent)
                    .HasMaxLength(255)
                    .HasColumnName("Attempted by Auto Agent");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(255)
                    .HasColumnName("Call Alert");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(255)
                    .HasColumnName("Caller ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("Campaign Name");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("Company Name");

                entity.Property(e => e.ConnectOnHello)
                    .HasMaxLength(255)
                    .HasColumnName("Connect On Hello");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(255)
                    .HasColumnName("Contact Name");

                entity.Property(e => e.DialingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Dialing Time");

                entity.Property(e => e.DirectNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Direct Number");

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Environment).HasMaxLength(255);

                entity.Property(e => e.FaxAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Fax Answered");

                entity.Property(e => e.GracefulExit).HasColumnName("Graceful Exit");

                entity.Property(e => e.IvrAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Answered");

                entity.Property(e => e.IvrPathBox1Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box1(Post)");

                entity.Property(e => e.IvrPathBox2Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box2(Post)");

                entity.Property(e => e.IvrPathBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box3(Post)");

                entity.Property(e => e.IvrPathNotesPostBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path Notes(Post)- Box3(Post)");

                entity.Property(e => e.IvrSuccess)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Success");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Job Title");

                entity.Property(e => e.LastAttemptedByAutoAgentOn)
                    .HasMaxLength(255)
                    .HasColumnName("Last Attempted by Auto Agent on");

                entity.Property(e => e.LastDirect)
                    .HasMaxLength(255)
                    .HasColumnName("Last Direct");

                entity.Property(e => e.LeadNumber).HasColumnName("Lead Number");

                entity.Property(e => e.LeadTime)
                    .HasMaxLength(255)
                    .HasColumnName("Lead Time");

                entity.Property(e => e.LeadTransitId).HasColumnName("Lead Transit ID");

                entity.Property(e => e.LeaveVoiceMail)
                    .HasMaxLength(255)
                    .HasColumnName("Leave VoiceMail");

                entity.Property(e => e.Notes).HasMaxLength(3999);

                entity.Property(e => e.NumberType)
                    .HasMaxLength(255)
                    .HasColumnName("Number Type");

                entity.Property(e => e.PersonAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Person Answered");

                entity.Property(e => e.SpecialInstruction)
                    .HasMaxLength(255)
                    .HasColumnName("Special Instruction");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(255)
                    .HasColumnName("Start Time");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(255)
                    .HasColumnName("Talk Time");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Telephone2).HasMaxLength(255);

                entity.Property(e => e.UserCompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("User Company Name");

                entity.Property(e => e.WrapTime)
                    .HasMaxLength(255)
                    .HasColumnName("Wrap Time");
            });

            modelBuilder.Entity<AttemptDataNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttemptData_New");

                entity.Property(e => e.AttemptedByAutoAgent)
                    .HasMaxLength(255)
                    .HasColumnName("Attempted by Auto Agent");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(255)
                    .HasColumnName("Call Alert");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(255)
                    .HasColumnName("Caller ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("Campaign Name");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("Company Name");

                entity.Property(e => e.ConnectOnHello)
                    .HasMaxLength(255)
                    .HasColumnName("Connect On Hello");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(255)
                    .HasColumnName("Contact Name");

                entity.Property(e => e.DialingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Dialing Time");

                entity.Property(e => e.DirectNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Direct Number");

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Environment).HasMaxLength(255);

                entity.Property(e => e.FaxAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Fax Answered");

                entity.Property(e => e.GracefulExit).HasColumnName("Graceful Exit");

                entity.Property(e => e.IvrAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Answered");

                entity.Property(e => e.IvrPathBox1Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box1(Post)");

                entity.Property(e => e.IvrPathBox2Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box2(Post)");

                entity.Property(e => e.IvrPathBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box3(Post)");

                entity.Property(e => e.IvrPathNotesPostBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path Notes(Post)- Box3(Post)");

                entity.Property(e => e.IvrSuccess)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Success");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Job Title");

                entity.Property(e => e.LastAttemptedByAutoAgentOn)
                    .HasMaxLength(255)
                    .HasColumnName("Last Attempted by Auto Agent on");

                entity.Property(e => e.LastDirect)
                    .HasMaxLength(255)
                    .HasColumnName("Last Direct");

                entity.Property(e => e.LeadNumber).HasColumnName("Lead Number");

                entity.Property(e => e.LeadTime)
                    .HasMaxLength(255)
                    .HasColumnName("Lead Time");

                entity.Property(e => e.LeadTransitId).HasColumnName("Lead Transit ID");

                entity.Property(e => e.LeaveVoiceMail)
                    .HasMaxLength(255)
                    .HasColumnName("Leave VoiceMail");

                entity.Property(e => e.NumberType)
                    .HasMaxLength(255)
                    .HasColumnName("Number Type");

                entity.Property(e => e.PersonAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Person Answered");

                entity.Property(e => e.SpecialInstruction)
                    .HasMaxLength(255)
                    .HasColumnName("Special Instruction");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(255)
                    .HasColumnName("Start Time");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(255)
                    .HasColumnName("Talk Time");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Telephone2).HasMaxLength(255);

                entity.Property(e => e.UserCompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("User Company Name");

                entity.Property(e => e.WrapTime)
                    .HasMaxLength(255)
                    .HasColumnName("Wrap Time");
            });

            modelBuilder.Entity<AttemptDateWithContactId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attemptDateWithContactID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.FirstAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");
            });

            modelBuilder.Entity<AttemptDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttemptedByAutoAgent)
                    .HasMaxLength(255)
                    .HasColumnName("Attempted by Auto Agent");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(255)
                    .HasColumnName("Call Alert");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(255)
                    .HasColumnName("Caller ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("Campaign Name");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("Company Name");

                entity.Property(e => e.ConnectOnHello)
                    .HasMaxLength(255)
                    .HasColumnName("Connect On Hello");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(255)
                    .HasColumnName("Contact Name");

                entity.Property(e => e.DialingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Dialing Time");

                entity.Property(e => e.DirectNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Direct Number");

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Environment).HasMaxLength(255);

                entity.Property(e => e.FaxAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Fax Answered");

                entity.Property(e => e.FirstAttemptDate).HasColumnType("date");

                entity.Property(e => e.GracefulExit).HasColumnName("Graceful Exit");

                entity.Property(e => e.IvrAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Answered");

                entity.Property(e => e.IvrPathBox1Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box1(Post)");

                entity.Property(e => e.IvrPathBox2Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box2(Post)");

                entity.Property(e => e.IvrPathBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path - Box3(Post)");

                entity.Property(e => e.IvrPathNotesPostBox3Post)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Path Notes(Post)- Box3(Post)");

                entity.Property(e => e.IvrSuccess)
                    .HasMaxLength(255)
                    .HasColumnName("IVR Success");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Job Title");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptedByAutoAgentOn)
                    .HasMaxLength(255)
                    .HasColumnName("Last Attempted by Auto Agent on");

                entity.Property(e => e.LastDirect)
                    .HasMaxLength(255)
                    .HasColumnName("Last Direct");

                entity.Property(e => e.LeadNumber).HasColumnName("Lead Number");

                entity.Property(e => e.LeadTime)
                    .HasMaxLength(255)
                    .HasColumnName("Lead Time");

                entity.Property(e => e.LeadTransitId).HasColumnName("Lead Transit ID");

                entity.Property(e => e.LeaveVoiceMail)
                    .HasMaxLength(255)
                    .HasColumnName("Leave VoiceMail");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.NumberType)
                    .HasMaxLength(255)
                    .HasColumnName("Number Type");

                entity.Property(e => e.PersonAnswered)
                    .HasMaxLength(255)
                    .HasColumnName("Person Answered");

                entity.Property(e => e.SpecialInstruction)
                    .HasMaxLength(255)
                    .HasColumnName("Special Instruction");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(255)
                    .HasColumnName("Start Time");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TalkTime)
                    .HasMaxLength(255)
                    .HasColumnName("Talk Time");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.Telephone2).HasMaxLength(255);

                entity.Property(e => e.UserCompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("User Company Name");

                entity.Property(e => e.WrapTime)
                    .HasMaxLength(255)
                    .HasColumnName("Wrap Time");
            });

            modelBuilder.Entity<AttemptedNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AttemptedNumber");

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoLeOnIeAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoLeOnIeAnalysis");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DialledNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Disposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumberType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutomaticTimeZoneMapper>(entity =>
            {
                entity.HasKey(e => e.UserFirendlyName)
                    .HasName("PK__Automati__7BF53D6C00C47266");

                entity.ToTable("AutomaticTimeZoneMapper");

                entity.Property(e => e.UserFirendlyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTimeZone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupCasListContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_cas_ListContact");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<BadRedisNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BadRedisNumber");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CallId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CallId");
            });

            modelBuilder.Entity<CallMapper>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CallMapper");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewContactId).HasColumnName("NewContactID");

                entity.Property(e => e.NewPhoneNumberId).HasColumnName("NewPhoneNumberID");

                entity.Property(e => e.OldContactId).HasColumnName("OldContactID");

                entity.Property(e => e.OldPhoneNumberId).HasColumnName("OldPhoneNumberID");
            });

            modelBuilder.Entity<CallerIdBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CallerID_backup");

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UserSettingId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CasActiveCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ActiveCompany");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Csm)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CSM");

                entity.Property(e => e.EnvId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SfdcName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SFDC_Name");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasAgentDispositionMap>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("cas_AgentDispositionMap");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasAgentDispositionMaps)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_AgentDispositionMap_t_Company");
            });

            modelBuilder.Entity<CasAgentDispositionMapDetail>(entity =>
            {
                entity.HasKey(e => e.MappingDetailId);

                entity.ToTable("cas_AgentDispositionMapDetails");

                entity.Property(e => e.AgentDispositionText)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CallOutcome).HasMaxLength(50);

                entity.Property(e => e.MappedCustomDispositionText).HasMaxLength(1000);

                entity.HasOne(d => d.Mapping)
                    .WithMany(p => p.CasAgentDispositionMapDetails)
                    .HasForeignKey(d => d.MappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_AgentDispositionMapDetails_cas_AgentDispositionMap");
            });

            modelBuilder.Entity<CasAllSfOpportunity>(entity =>
            {
                entity.ToTable("cas_AllSfOpportunities");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectResponsible)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveConnectDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasAttemptAndConversationSummary>(entity =>
            {
                entity.ToTable("cas_AttemptAndConversationSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<CasAttributionMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK__cas_Attr__8B57819D0B841076");

                entity.ToTable("cas_AttributionMapping");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasAttributionMappingBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_AttributionMapping_back");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.MappingId).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasBadNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_BadNumber");

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

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
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

            modelBuilder.Entity<CasCallLog>(entity =>
            {
                entity.HasKey(e => e.CallLogId);

                entity.ToTable("cas_CallLog");

                entity.Property(e => e.ClientName).HasMaxLength(100);
            });

            modelBuilder.Entity<CasCallPreference>(entity =>
            {
                entity.ToTable("cas_CallPreference");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsLeadPool).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasCasListTeam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_cas_ListTeam");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CasCategoryAndRating>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__cas_Cate__2D971CAC6AE2C65C");

                entity.ToTable("cas_CategoryAndRating");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.Category1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category1Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category2Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category3Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category4Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category5Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category6Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Category7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category7Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Score1Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Score2Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Score3Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Score4Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Score5Desc)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasCloneSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_Clone_Settings");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompanyDisposition>(entity =>
            {
                entity.HasKey(e => e.CompanyDispositionId)
                    .HasName("PK_CompanyDisposition");

                entity.ToTable("cas_CompanyDisposition");

                entity.Property(e => e.CallOutcome).HasMaxLength(50);

                entity.Property(e => e.ContactStatus).HasMaxLength(100);

                entity.Property(e => e.ContactSubStatus).HasMaxLength(100);

                entity.Property(e => e.CountAsConversion).HasColumnName("countAsConversion");

                entity.Property(e => e.Csvstatus)
                    .HasMaxLength(100)
                    .HasColumnName("CSVStatus");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DispositionMode).HasDefaultValueSql("((3))");

                entity.Property(e => e.DispositionText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DispositionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Futptemplate)
                    .HasMaxLength(2000)
                    .HasColumnName("FUTPTemplate");

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

            modelBuilder.Entity<CasCompanySetting050421>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompanySetting_050421");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.EnvId).HasColumnName("EnvID");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompanySettingBckp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompanySetting_bckp");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.EnvId).HasColumnName("EnvID");

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompanySettingConnectedNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompanySetting_connectedNumber");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompanySettingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompanySetting_Details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<CasCompanysettingSfdc0829>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_companysettingSFDC0829");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompanysettingbackup0912>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_companysettingbackup0912");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasCompiledCtr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CompiledCTR");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompiledCtrid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CompiledCTRID");

                entity.Property(e => e.ConnectTime).HasColumnType("date");

                entity.Property(e => e.ContactCity).HasMaxLength(1000);

                entity.Property(e => e.ContactName).HasMaxLength(1000);

                entity.Property(e => e.Crmid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CRMID");

                entity.Property(e => e.DispositionText).HasMaxLength(1000);

                entity.Property(e => e.DispositionType).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.JobTitle).HasMaxLength(500);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Problems).HasMaxLength(1000);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.Stat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<CasCompiledRtsr>(entity =>
            {
                entity.HasKey(e => e.CompiledRtsrid)
                    .HasName("PK__cas_Comp__FBD1E981B0364A0D");

                entity.ToTable("cas_CompiledRTSR");

                entity.Property(e => e.CompiledRtsrid).HasColumnName("CompiledRTSRID");

                entity.Property(e => e.ActualEndTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualStartTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName).HasMaxLength(500);

                entity.Property(e => e.OrderNo).HasMaxLength(255);

                entity.Property(e => e.PitcherName).HasMaxLength(500);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.SessionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasConnect>(entity =>
            {
                entity.HasKey(e => e.ConnectId);

                entity.ToTable("cas_Connect");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactFirstName).HasMaxLength(255);

                entity.Property(e => e.ContactJobTitle).HasMaxLength(255);

                entity.Property(e => e.ContactLastName).HasMaxLength(255);

                entity.Property(e => e.Crmid)
                    .HasMaxLength(500)
                    .HasColumnName("CRMId");

                entity.Property(e => e.DispositionText).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<CasConnectBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Connect_backup");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ConnectId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContactFirstName).HasMaxLength(255);

                entity.Property(e => e.ContactJobTitle).HasMaxLength(255);

                entity.Property(e => e.ContactLastName).HasMaxLength(255);

                entity.Property(e => e.Crmid)
                    .HasMaxLength(20)
                    .HasColumnName("CRMId");

                entity.Property(e => e.DispositionText).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<CasConnectLatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_connect_latest");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ConnectId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContactFirstName).HasMaxLength(255);

                entity.Property(e => e.ContactJobTitle).HasMaxLength(255);

                entity.Property(e => e.ContactLastName).HasMaxLength(255);

                entity.Property(e => e.Crmid)
                    .HasMaxLength(20)
                    .HasColumnName("CRMId");

                entity.Property(e => e.DispositionText).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(255);
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

                entity.Property(e => e.AllPhoneNumbers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

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

                entity.Property(e => e.CustomValueJson).HasColumnName("CustomValueJSON");

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

                entity.Property(e => e.FilteredCustomValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gmtoffset)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("GMTOffset");

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

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

                entity.Property(e => e.MappedTitle)
                    .HasMaxLength(100)
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

                entity.Property(e => e.Phone1AreaCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2AreaCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3AreaCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber1Only)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber1WithCountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber2Only)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber2WithCountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber3Only)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber3WithCountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostInjectedContactTime).HasColumnType("datetime");

                entity.Property(e => e.ReferralCustom).IsUnicode(false);

                entity.Property(e => e.SecondarySubStatus).HasMaxLength(1000);

                entity.Property(e => e.SfpbFlag).HasColumnName("SFPbFlag");

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

                entity.Property(e => e.ValidTimeZone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasContacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_Contact_t_User");
            });

            modelBuilder.Entity<CasContact20211111>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_cas_Contact1");

                entity.ToTable("cas_Contact20211111");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

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

            modelBuilder.Entity<CasContactDailyDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Contact_DailyData");

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

            modelBuilder.Entity<CasContactDemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Contact_Demo");

                entity.Property(e => e.AccountCity).HasMaxLength(1000);

                entity.Property(e => e.AccountState).HasMaxLength(1000);

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.MostRecentCampaign)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginListName).HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
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

            modelBuilder.Entity<CasContactSm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Contact_SM");

                entity.Property(e => e.AccountCity).HasMaxLength(1000);

                entity.Property(e => e.AccountState).HasMaxLength(1000);

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.MostRecentCampaign)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginListName).HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
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

            modelBuilder.Entity<CasConversationRatingOriginal>(entity =>
            {
                entity.HasKey(e => new { e.NoteId, e.CategoryName })
                    .HasName("PK_cas_ConversationRating");

                entity.ToTable("cas_ConversationRating_original");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RateNote)
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

            modelBuilder.Entity<CasCountryDialInNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CountryDialInNumber");

                entity.Property(e => e.AlternateDialInNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.DialInNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngineIdentifier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Isocode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISOCode");
            });

            modelBuilder.Entity<CasCrmfilter>(entity =>
            {
                entity.HasKey(e => e.CrmfilterId);

                entity.ToTable("cas_CRMFilter");

                entity.Property(e => e.CrmfilterId).HasColumnName("CRMFilterId");

                entity.Property(e => e.ContactListname).IsUnicode(false);

                entity.Property(e => e.ExtendedGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SecondaryFilter).IsUnicode(false);

                entity.Property(e => e.SecondaryFilterName).IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasCrmfilters)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_CRMFilter_cas_List");
            });

            modelBuilder.Entity<CasCrmfilter23740>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CRMFilter_23740");

                entity.Property(e => e.ContactListname).IsUnicode(false);

                entity.Property(e => e.CrmfilterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CRMFilterId");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SecondaryFilter).IsUnicode(false);

                entity.Property(e => e.SecondaryFilterName).IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<CasCrmfilter23741>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_CRMFilter_23741");

                entity.Property(e => e.ContactListname).IsUnicode(false);

                entity.Property(e => e.CrmfilterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CRMFilterId");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SecondaryFilter).IsUnicode(false);

                entity.Property(e => e.SecondaryFilterName).IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<CasDailyDialsRawDataAllGc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_DailyDialsRawDataAllGCS");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EnvId).HasDefaultValueSql("((13))");
            });

            modelBuilder.Entity<CasDailyDialsRawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_DailyDialsRawData");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EnvId).HasDefaultValueSql("((13))");
            });

            modelBuilder.Entity<CasDbversion>(entity =>
            {
                entity.HasKey(e => e.DbversionId)
                    .HasName("PK_DBVersion");

                entity.ToTable("cas_DBVersion");

                entity.Property(e => e.DbversionId)
                    .ValueGeneratedNever()
                    .HasColumnName("DBVersionId");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasDefaultCompanySetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_DefaultCompanySetting");

                entity.Property(e => e.CrmName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<CasDncBackUp>(entity =>
            {
                entity.HasKey(e => e.DncBackUpId)
                    .HasName("PK__cas_DncB__56A85923F0275A46");

                entity.ToTable("cas_DncBackUp");

                entity.Property(e => e.DncBackUpId).HasColumnName("DncBackUpID");

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DeleteContactDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasDuplicateContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_DuplicateContact");

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsInTcall).HasColumnName("IsInTCall");

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

                entity.Property(e => e.SfpbFlag).HasColumnName("SFPbFlag");

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

            modelBuilder.Entity<CasDuplicateContact2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_DuplicateContact_2");

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsInTcall).HasColumnName("IsInTCall");

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

                entity.Property(e => e.SfpbFlag).HasColumnName("SFPbFlag");

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

            modelBuilder.Entity<CasDuplicateContact23740>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_DuplicateContact_23740");

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsInTcall).HasColumnName("IsInTCall");

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

                entity.Property(e => e.SfpbFlag).HasColumnName("SFPbFlag");

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

            modelBuilder.Entity<CasDuplicateContact23741>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_DuplicateContact_23741");

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsInTcall).HasColumnName("IsInTCall");

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

                entity.Property(e => e.SfpbFlag).HasColumnName("SFPbFlag");

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

            modelBuilder.Entity<CasEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId)
                    .HasName("PK__cas_Emai__BC0A3855FC3C0740");

                entity.ToTable("cas_EmailTemplates");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.Crm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRM");

                entity.Property(e => e.EmailType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasEnvironmentInfo>(entity =>
            {
                entity.HasKey(e => e.EnvironmentId)
                    .HasName("PK__cas_Envi__4B909A49A9644A68");

                entity.ToTable("cas_EnvironmentInfo");

                entity.Property(e => e.EnvironmentLoginUrl).HasMaxLength(1000);

                entity.Property(e => e.EnvironmentName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CasErrorneousRecording>(entity =>
            {
                entity.HasKey(e => e.ErrorneousRecordingId);

                entity.ToTable("cas_ErrorneousRecording");

                entity.Property(e => e.ErrorneousRecordingId).HasColumnName("ErrorneousRecordingID");

                entity.Property(e => e.ErrorneousMsg).IsUnicode(false);

                entity.Property(e => e.LeadTransitId).HasColumnName("LeadTransitID");

                entity.Property(e => e.RecordingJobExcecutionId).HasColumnName("RecordingJobExcecutionID");

                entity.HasOne(d => d.RecordingJobExcecution)
                    .WithMany(p => p.CasErrorneousRecordings)
                    .HasForeignKey(d => d.RecordingJobExcecutionId)
                    .HasConstraintName("FK_cas_ErrorneousRecording_cas_RecordingDetails");
            });

            modelBuilder.Entity<CasEtllog>(entity =>
            {
                entity.HasKey(e => e.EtllogId);

                entity.ToTable("cas_ETLLog");

                entity.Property(e => e.EtllogId).HasColumnName("ETLLogId");

                entity.Property(e => e.LogEndDate).HasColumnType("datetime");

                entity.Property(e => e.LogStartDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.SendMryesRecordNew).HasColumnName("SendMRYesRecord_New");

                entity.Property(e => e.SendMryesRecordPrevious).HasColumnName("SendMRYesRecord_Previous");

                entity.Property(e => e.StatusOngoingRecordNew).HasColumnName("StatusOngoingRecord_New");

                entity.Property(e => e.StatusOngoingRecordPrevious).HasColumnName("StatusOngoingRecord_Previous");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TotalRecordNew).HasColumnName("TotalRecord_New");

                entity.Property(e => e.TotalRecordPrevious).HasColumnName("TotalRecord_Previous");

                entity.Property(e => e.TotalSendMrNew).HasColumnName("TotalSendMR_New");

                entity.Property(e => e.TotalSendMrPrevious).HasColumnName("TotalSendMR_Previous");
            });

            modelBuilder.Entity<CasFieldPriority>(entity =>
            {
                entity.HasKey(e => e.FieldPriorityId);

                entity.ToTable("cas_FieldPriority");

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasFieldPriorities)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_FieldPriority_t_Company");
            });

            modelBuilder.Entity<CasFutptemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_FUTPTemplates");

                entity.Property(e => e.Template)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasGdprcontact>(entity =>
            {
                entity.HasKey(e => e.GdprcontactId)
                    .HasName("PK__cas_GDPR__E26419E0BAC86C98");

                entity.ToTable("cas_GDPRContact");

                entity.Property(e => e.GdprcontactId).HasColumnName("GDPRContactID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(512);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(512);

                entity.Property(e => e.GdprrequestId).HasColumnName("GDPRRequestId");

                entity.Property(e => e.LastName).HasMaxLength(512);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone1).HasMaxLength(512);

                entity.Property(e => e.Phone2).HasMaxLength(512);

                entity.Property(e => e.RequestUserId).HasColumnName("RequestUserID");
            });

            modelBuilder.Entity<CasGdprrequest>(entity =>
            {
                entity.HasKey(e => e.GdprrequestId)
                    .HasName("PK__cas_GDPR__CC20B33BE9E6848C");

                entity.ToTable("cas_GDPRRequest");

                entity.Property(e => e.GdprrequestId).HasColumnName("GDPRRequestID");

                entity.Property(e => e.ContactCompanyName).HasMaxLength(512);

                entity.Property(e => e.ContactEmail).HasMaxLength(512);

                entity.Property(e => e.ContactFirstName).HasMaxLength(512);

                entity.Property(e => e.ContactId).IsUnicode(false);

                entity.Property(e => e.ContactLastName).HasMaxLength(512);

                entity.Property(e => e.ContactPhone).HasMaxLength(512);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.GdprrequestStaus).HasColumnName("GDPRRequestStaus");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestUserId).HasColumnName("RequestUserID");
            });

            modelBuilder.Entity<CasGoal>(entity =>
            {
                entity.HasKey(e => e.GoalId)
                    .HasName("PK__cas_Goal__8A4FFFD1B0C6C36D");

                entity.ToTable("cas_Goals");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailList)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EndLimitofGoal).HasColumnType("datetime");

                entity.Property(e => e.GoalAgainst)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.GoalAgainstType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoalConditionType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GoalIndividualTeam)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.GoalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoalTimeFrame)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoalType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.StartLimitofGoal).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasGoals)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cas_Goals__Compa__2E5BD364");
            });

            modelBuilder.Entity<CasGoalDataDailyDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_GoalDataDailyData");

                entity.Property(e => e.AttemptDaily).HasColumnName("Attempt_Daily");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConversationDaily).HasColumnName("Conversation_Daily");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpDaily).HasColumnName("FollowUp_Daily");

                entity.Property(e => e.GoalDuration)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDaily).HasColumnName("Meeting_Daily");

                entity.Property(e => e.PauseTimeDaily).HasColumnName("PauseTime_Daily");

                entity.Property(e => e.PitcherLeadTimeDaily).HasColumnName("PitcherLeadTime_Daily");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WaitTimeDaily).HasColumnName("WaitTime_Daily");
            });

            modelBuilder.Entity<CasGoalDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_GoalData");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalDuration)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasGoalTarhet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_GoalTarhet");

                entity.Property(e => e.GoalDuration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GoalType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasJobsTriggeredDetail>(entity =>
            {
                entity.ToTable("cas_jobsTriggeredDetails");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.InnerExceptionMessage)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jobstatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("jobstatus");

                entity.Property(e => e.StartTime).HasColumnName("startTime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.CasJobsTriggeredDetails)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__cas_jobsT__JobId__2F4FF79D");
            });

            modelBuilder.Entity<CasLeadCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAS_LeadCompanies");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("Company Name");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.ListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(255);
            });

            modelBuilder.Entity<CasLightningParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_LightningParameter");

                entity.Property(e => e.LightningParameterId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("cas_List");

                entity.Property(e => e.AcknowledgedBy).HasMaxLength(255);

                entity.Property(e => e.ActiveUser).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.LastUsed).HasColumnType("datetime");

                entity.Property(e => e.ListCampaignId)
                    .HasMaxLength(50)
                    .HasColumnName("ListCampaignID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutreachListRefreshDate).HasColumnType("datetime");

                entity.Property(e => e.SequenceId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SequenceID");

                entity.Property(e => e.SettingMetaData).IsUnicode(false);

                entity.Property(e => e.SfReportPath).HasMaxLength(1000);

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.HasOne(d => d.ListType)
                    .WithMany(p => p.CasLists)
                    .HasForeignKey(d => d.ListTypeId)
                    .HasConstraintName("FK_cas_List_cas_ListType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_List_t_User");
            });

            modelBuilder.Entity<CasList14may>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_List_14May");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ListId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CasListCalendar>(entity =>
            {
                entity.ToTable("cas_ListCalendar");

                entity.Property(e => e.Days)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasListContact>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.ContactId });

                entity.ToTable("cas_ListContact");

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

            modelBuilder.Entity<CasListContact23740>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListContact_23740");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<CasListContact23741>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListContact_23741");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<CasListContactBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListContact_Backup");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<CasListContactCustom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListContactCustoms");

                entity.Property(e => e.Custom).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CasListContactSetting>(entity =>
            {
                entity.ToTable("cas_ListContactSetting");
            });

            modelBuilder.Entity<CasListEnrichSummary>(entity =>
            {
                entity.HasKey(e => e.ListId)
                    .HasName("PK_cas_ListEnrichSummary_1");

                entity.ToTable("cas_ListEnrichSummary");

                entity.Property(e => e.ListId).ValueGeneratedNever();

                entity.HasOne(d => d.List)
                    .WithOne(p => p.CasListEnrichSummary)
                    .HasForeignKey<CasListEnrichSummary>(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_ListEnrichSummary_cas_List");
            });

            modelBuilder.Entity<CasListRule>(entity =>
            {
                entity.ToTable("cas_ListRule");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DaysFlag).HasColumnName("daysFlag");

                entity.Property(e => e.DeactivateFlag).HasColumnName("deactivateFlag");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.Rules)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<CasListRuleBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListRuleBackup");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DaysFlag).HasColumnName("daysFlag");

                entity.Property(e => e.DeactivateFlag).HasColumnName("deactivateFlag");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.Rules)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<CasListScore>(entity =>
            {
                entity.ToTable("cas_ListScore");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasListScores)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_cas_ListScore_cas_List");
            });

            modelBuilder.Entity<CasListTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK__cas_List__657CF9ACD83A0CCF");

                entity.ToTable("cas_ListTag");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasListTeam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListTeam");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CasListType>(entity =>
            {
                entity.HasKey(e => e.ListTypeId);

                entity.ToTable("cas_ListType");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasListTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_ListType_t_Company");
            });

            modelBuilder.Entity<CasListUser>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.UserId });

                entity.ToTable("cas_ListUser");

                entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsArchived).HasColumnName("isArchived");

                entity.HasOne(d => d.Greeting)
                    .WithMany(p => p.CasListUsers)
                    .HasForeignKey(d => d.GreetingId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_cas_ListUser_cas_UserGreeting");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasListUsers)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_ListUser_cas_List");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_ListUser_t_User");

                entity.HasOne(d => d.Voicemail)
                    .WithMany(p => p.CasListUsers)
                    .HasForeignKey(d => d.VoicemailId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_cas_ListUser_cas_UserVoicemail");
            });

            modelBuilder.Entity<CasListUserBackup4Feb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ListUserBackup4Feb");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasLog>(entity =>
            {
                entity.ToTable("cas_Logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasManagementObjectDataHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ManagementObjectData_History");

                entity.Property(e => e.AnticipatedBalanceUnitCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FirstUsageDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedById).HasMaxLength(500);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ManagementReportId).HasColumnName("ManagementReportID");

                entity.Property(e => e.ManagementReportName).HasMaxLength(500);

                entity.Property(e => e.Mrnotes)
                    .HasMaxLength(1000)
                    .HasColumnName("MRNotes");

                entity.Property(e => e.MrreportingId)
                    .HasMaxLength(2000)
                    .HasColumnName("MRReportingID");

                entity.Property(e => e.OrderName).HasMaxLength(1000);

                entity.Property(e => e.OwnerId).HasMaxLength(500);

                entity.Property(e => e.Product).HasMaxLength(500);

                entity.Property(e => e.RelatedOpportunityName).HasMaxLength(500);

                entity.Property(e => e.SendMr)
                    .HasMaxLength(500)
                    .HasColumnName("SendMR");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.SystemModstamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasManagementObjectDatum>(entity =>
            {
                entity.HasKey(e => e.ManagementReportId);

                entity.ToTable("cas_ManagementObjectData");

                entity.Property(e => e.ManagementReportId).HasColumnName("ManagementReportID");

                entity.Property(e => e.AnticipatedBalanceUnitCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FirstUsageDate).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedById).HasMaxLength(500);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ManagementReportName).HasMaxLength(500);

                entity.Property(e => e.Mrnotes)
                    .HasMaxLength(1000)
                    .HasColumnName("MRNotes");

                entity.Property(e => e.MrreportingId)
                    .HasMaxLength(2000)
                    .HasColumnName("MRReportingID");

                entity.Property(e => e.OrderName).HasMaxLength(1000);

                entity.Property(e => e.OwnerId).HasMaxLength(500);

                entity.Property(e => e.Product).HasMaxLength(500);

                entity.Property(e => e.RelatedOpportunityName).HasMaxLength(500);

                entity.Property(e => e.SendMr)
                    .HasMaxLength(500)
                    .HasColumnName("SendMR");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.SystemModstamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasManagementReportDl>(entity =>
            {
                entity.ToTable("cas_ManagementReportDls");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BccEmail)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("BCC_Email");

                entity.Property(e => e.CcEmail)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("CC_Email");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("To_Email");
            });

            modelBuilder.Entity<CasMandatoryList>(entity =>
            {
                entity.HasKey(e => e.MandatoryId)
                    .HasName("PK__cas_Mand__0B409C02A36BFB32");

                entity.ToTable("cas_MandatoryLists");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsMandatory)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasMandatoryLists)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK__cas_Manda__ListI__56CB4E1F");
            });

            modelBuilder.Entity<CasMandatoryListsBackUp20201027>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_MandatoryLists_BackUp_20201027");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MandatoryId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CasMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("cas_Mapping");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Primary)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasMappings)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_Mapping_t_Company");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasMappings)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_cas_Mapping_cas_List");

                entity.HasOne(d => d.ParentMapping)
                    .WithMany(p => p.InverseParentMapping)
                    .HasForeignKey(d => d.ParentMappingId)
                    .HasConstraintName("FK_cas_Mapping_cas_Mapping");
            });

            modelBuilder.Entity<CasMapping1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Mapping1");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CasMappingBackUp20200528>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Mapping_BackUp_20200528");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.MappingId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<CasMappingField>(entity =>
            {
                entity.HasKey(e => e.MappingFieldId);

                entity.ToTable("cas_MappingField");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");

                entity.HasOne(d => d.Mapping)
                    .WithMany(p => p.CasMappingFields)
                    .HasForeignKey(d => d.MappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_MappingField_cas_Mapping");
            });

            modelBuilder.Entity<CasMappingField1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_MappingField1");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");
            });

            modelBuilder.Entity<CasMappingFieldBackUp20200528>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_MappingField_BackUp_20200528");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.MappingFieldId).ValueGeneratedOnAdd();

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");
            });

            modelBuilder.Entity<CasMappingbackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_mappingbackup");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.MappingId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<CasMappingfieldbackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_mappingfieldbackup");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.MappingFieldId).ValueGeneratedOnAdd();

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");
            });

            modelBuilder.Entity<CasMasterJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__cas_mast__056690C24E342F8A");

                entity.ToTable("cas_masterJobs");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasMatching>(entity =>
            {
                entity.HasKey(e => e.MatchingId);

                entity.ToTable("cas_Matching");

                entity.Property(e => e.MatchedByName).HasMaxLength(500);
            });

            modelBuilder.Entity<CasMatchingDetail>(entity =>
            {
                entity.HasKey(e => e.MatchingDetailsId);

                entity.ToTable("cas_MatchingDetails");

                entity.Property(e => e.CascompanyName)
                    .HasMaxLength(500)
                    .HasColumnName("CASCompanyName");

                entity.Property(e => e.MatchingStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.SfaccountName)
                    .HasMaxLength(500)
                    .HasColumnName("SFAccountName");
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

            modelBuilder.Entity<CasMultiTouchListContact>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.ContactId });

                entity.ToTable("cas_MultiTouchListContact");

                entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CasMultiTouchListContacts)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_cas_MultiTouchListContact_cas_Contact");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasMultiTouchListContacts)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_cas_MultiTouchListContact_cas_List");
            });

            modelBuilder.Entity<CasMultitouchAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("cas_MultitouchAction");

                entity.Property(e => e.Data).HasMaxLength(500);

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasMultitouchActions)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_MultitouchAction_cas_MultitouchRule");
            });

            modelBuilder.Entity<CasMultitouchContactEffect>(entity =>
            {
                entity.HasKey(e => e.MultitouchEffectId);

                entity.ToTable("cas_MultitouchContactEffects");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.CasMultitouchContactEffects)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_cas_MultitouchContactEffects_cas_MultitouchAction");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasMultitouchContactEffects)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK_cas_MultitouchContactEffects_cas_MultitouchRule");
            });

            modelBuilder.Entity<CasMultitouchRule>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK_MultitouchRule");

                entity.ToTable("cas_MultitouchRule");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasMultitouchRules)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_MultitouchRule_cas_List");
            });

            modelBuilder.Entity<CasNextGenTaskInfo>(entity =>
            {
                entity.ToTable("cas_NextGenTaskInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PrimaryCrmid).HasColumnName("PrimaryCRMID");

                entity.Property(e => e.SecondaryCrmid).HasColumnName("SecondaryCRMID");

                entity.Property(e => e.TaskDeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaskSyncedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasNextGenTaskInfos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_NextGenTaskInfo_t_User");
            });

            modelBuilder.Entity<CasNextGenTaskInfo5174>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_NextGenTaskInfo5174");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PrimaryCrmid).HasColumnName("PrimaryCRMID");

                entity.Property(e => e.SecondaryCrmid).HasColumnName("SecondaryCRMID");

                entity.Property(e => e.TaskDeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaskSyncedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasNonBaseMappingField>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("cas_NonBaseMappingField");

                entity.Property(e => e.ContactFieldName).HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.Crmvalue)
                    .HasMaxLength(500)
                    .HasColumnName("CRMValue");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasNonBaseMappingFields)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_NonBaseMappingField_t_Company");
            });

            modelBuilder.Entity<CasNotAttempted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_NotAttempted");

                entity.Property(e => e.CampaignListName)
                    .IsRequired()
                    .HasColumnName("Campaign_List_Name");

                entity.Property(e => e.Company).IsRequired();

                entity.Property(e => e.ContactStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Status");

                entity.Property(e => e.DirectPhone).HasColumnName("Direct_Phone");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastAttemptDateCas)
                    .HasColumnType("datetime")
                    .HasColumnName("LastAttemptDate_CAS");

                entity.Property(e => e.LastAttemptedDateAttemptsHistory).HasColumnName("Last_Attempted_Date_Attempts_History");

                entity.Property(e => e.LastAttemptedDateSfdc)
                    .HasColumnType("date")
                    .HasColumnName("Last_Attempted_Date_SFDC");

                entity.Property(e => e.LastInvalidDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name");

                entity.Property(e => e.LeadId)
                    .IsRequired()
                    .HasColumnName("Lead_ID");

                entity.Property(e => e.LightningListStatus)
                    .IsRequired()
                    .HasColumnName("Lightning_List_Status");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("cas_Note");

                entity.Property(e => e.CallSentiment).HasMaxLength(1000);

                entity.Property(e => e.Disposition)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.IsBlindLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCheckedForReview).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.IsConversation)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextSteps).HasMaxLength(2000);

                entity.Property(e => e.RecordCall).HasDefaultValueSql("((1))");

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

            modelBuilder.Entity<CasNote30jan23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Note_30Jan23");

                entity.Property(e => e.LeadTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.TalkTime).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CasNote31jan23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Note_31Jan23");

                entity.Property(e => e.LeadTime).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CasOutreachSfSync>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_OutreachSfSync");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastSyncDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_OutreachSfSync_t_User");
            });

            modelBuilder.Entity<CasPbdispositionConfiguration>(entity =>
            {
                entity.HasKey(e => e.DispositionId);

                entity.ToTable("cas_PBDispositionConfiguration");

                entity.Property(e => e.ContactAction).HasMaxLength(500);

                entity.Property(e => e.Disposition).HasMaxLength(500);
            });

            modelBuilder.Entity<CasPbrule>(entity =>
            {
                entity.HasKey(e => e.PbruleId);

                entity.ToTable("cas_PBRule");

                entity.Property(e => e.PbruleId).HasColumnName("PBRuleID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasPbrules)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_cas_PBRule_t_Company");
            });

            modelBuilder.Entity<CasPbruleAction>(entity =>
            {
                entity.HasKey(e => e.PbruleAction);

                entity.ToTable("cas_PBRuleAction");

                entity.Property(e => e.PbruleAction).HasColumnName("PBRuleAction");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.Pbtype).HasColumnName("PBType");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasPbruleActions)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK_cas_PBRuleAction_cas_PBRule");
            });

            modelBuilder.Entity<CasPbruleGroup>(entity =>
            {
                entity.HasKey(e => e.PbruleGroupId);

                entity.ToTable("cas_PBRuleGroup");

                entity.Property(e => e.PbruleGroupId).HasColumnName("PBRuleGroupID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasPbruleGroups)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK_cas_PBRuleGroup_cas_PBRule");
            });

            modelBuilder.Entity<CasPbruleGroupValueMapping>(entity =>
            {
                entity.HasKey(e => e.PbruleGroupValueMappingId);

                entity.ToTable("cas_PBRuleGroupValueMapping");

                entity.Property(e => e.PbruleGroupValueMappingId).HasColumnName("PBRuleGroupValueMappingID");

                entity.Property(e => e.RuleGroupId).HasColumnName("RuleGroupID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.RuleParentGroupId).HasColumnName("RuleParentGroupID");

                entity.Property(e => e.RuleValueId).HasColumnName("RuleValueID");

                entity.HasOne(d => d.RuleGroup)
                    .WithMany(p => p.CasPbruleGroupValueMappingRuleGroups)
                    .HasForeignKey(d => d.RuleGroupId)
                    .HasConstraintName("FK_cas_PBRuleGroupValueMapping_cas_PBRuleGroup");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasPbruleGroupValueMappings)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK_cas_PBRuleGroupValueMapping_cas_PBRule");

                entity.HasOne(d => d.RuleParentGroup)
                    .WithMany(p => p.CasPbruleGroupValueMappingRuleParentGroups)
                    .HasForeignKey(d => d.RuleParentGroupId)
                    .HasConstraintName("FK_cas_PBRuleGroupValueMapping_cas_PBRuleParentGroup");

                entity.HasOne(d => d.RuleValue)
                    .WithMany(p => p.CasPbruleGroupValueMappings)
                    .HasForeignKey(d => d.RuleValueId)
                    .HasConstraintName("FK_cas_PBRuleGroupValueMapping_cas_PBRuleValue");
            });

            modelBuilder.Entity<CasPbruleReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBRuleReport");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EntityAction).IsUnicode(false);

                entity.Property(e => e.ReportId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ReportID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");
            });

            modelBuilder.Entity<CasPbruleValue>(entity =>
            {
                entity.HasKey(e => e.PbruleValueId);

                entity.ToTable("cas_PBRuleValue");

                entity.Property(e => e.PbruleValueId).HasColumnName("PBRuleValueId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.CasPbruleValues)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK_cas_PBRuleValue_cas_PBRule");
            });

            modelBuilder.Entity<CasPbtemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBTemp");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasPbtemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBTemp_2");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasPbtempF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBTemp_F");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasPbwrong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBwrong");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CallClientId).HasColumnName("CallClientID");

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClientName_C");

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

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyInfo).IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CompanyNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompanyName_C");

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

                entity.Property(e => e.ContactIdC).HasColumnName("ContactID_C");

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

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.LastName).HasMaxLength(100);

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

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserName_C");
            });

            modelBuilder.Entity<CasPbwrong2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBwrong_2");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_CampaignName");

                entity.Property(e => e.CCampaignUserId).HasColumnName("C_CampaignUserId");

                entity.Property(e => e.CClientId).HasColumnName("C_ClientID");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClientName_C");

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

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyInfo).IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CompanyNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompanyName_C");

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

                entity.Property(e => e.ContactIdC).HasColumnName("ContactID_C");

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

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.LastName).HasMaxLength(100);

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

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserName_C");
            });

            modelBuilder.Entity<CasPbwrongF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PBwrong_f");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClientName_C");

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

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyInfo).IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CompanyNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompanyName_C");

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

                entity.Property(e => e.ContactIdC).HasColumnName("ContactID_C");

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

                entity.Property(e => e.CrmObject).HasMaxLength(100);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallConnectTime).HasColumnType("datetime");

                entity.Property(e => e.EngineCallSignalTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.Ienumbers)
                    .HasMaxLength(1000)
                    .HasColumnName("IENumbers");

                entity.Property(e => e.IsColv).HasColumnName("IsCOLV");

                entity.Property(e => e.LastName).HasMaxLength(100);

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

                entity.Property(e => e.PCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pCampaignName");

                entity.Property(e => e.PCampaignUserId).HasColumnName("pCampaignUserId");

                entity.Property(e => e.PClientId).HasColumnName("pClientId");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserName_C");
            });

            modelBuilder.Entity<CasPenalizedPhoneNumber>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__cas_Pena__FBDF78E97534FA31");

                entity.ToTable("cas_PenalizedPhoneNumber");

                entity.Property(e => e.Agent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition).HasMaxLength(500);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Disposition).HasMaxLength(500);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPenalizedDate).HasColumnType("datetime");

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasPenalizedPhoneNumberFisher>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__cas_Pena__FBDF78E9DE1659D8");

                entity.ToTable("cas_PenalizedPhoneNumber_Fisher");

                entity.Property(e => e.Agent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition).HasMaxLength(500);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Disposition).HasMaxLength(500);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPenalizedDate).HasColumnType("datetime");

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasPenaltyBoxAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__cas_Pena__A17F2398FEA21B0E");

                entity.ToTable("cas_PenaltyBoxAudit");

                entity.Property(e => e.AgentDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientFacingDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Crmobject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMObject");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pbdisposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBDisposition");

                entity.Property(e => e.Pbphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBPhone");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemovalDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.StatusPhone1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasPenaltyBoxAuditFisher>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__cas_Pena__A17F2398F8B6BC6F");

                entity.ToTable("cas_PenaltyBoxAudit_Fisher");

                entity.Property(e => e.AgentDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientFacingDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Crmobject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMObject");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pbdisposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBDisposition");

                entity.Property(e => e.Pbphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBPhone");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemovalDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.StatusPhone1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<CasPitcherSessiondatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_PitcherSessiondata");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalDuration)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasPriorityMapping>(entity =>
            {
                entity.HasKey(e => e.PriorityId);

                entity.ToTable("cas_PriorityMappings");

                entity.Property(e => e.Caspriority)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CASPriority");

                entity.Property(e => e.Crmpriority)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMPriority");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasPriorityMappings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_PriorityMappings_t_Company");
            });

            modelBuilder.Entity<CasProblemDispositionsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ProblemDispositionsDetails");

                entity.Property(e => e.ProblemDispositionId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProblemDispositionText)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("ProblemDisposition Text");
            });

            modelBuilder.Entity<CasRealTimeAlertForTeamSetting>(entity =>
            {
                entity.ToTable("cas_RealTimeAlertForTeamSettings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CasRecordingDetail>(entity =>
            {
                entity.HasKey(e => e.RecordingJobExcecutionId);

                entity.ToTable("cas_RecordingDetails");

                entity.Property(e => e.RecordingJobExcecutionId).HasColumnName("RecordingJobExcecutionID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutionEndDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutionStartDate).HasColumnType("datetime");

                entity.Property(e => e.LastSucessfullRecordingId).HasColumnName("LastSucessfullRecordingID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasSamlMapping>(entity =>
            {
                entity.ToTable("cas_SamlMappings");

                entity.Property(e => e.AssignCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OktaParentCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasScoreCard>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RepId });

                entity.ToTable("cas_ScoreCard");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<CasSessionScheduling>(entity =>
            {
                entity.ToTable("cas_SessionScheduling");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.InviteId)
                    .IsUnicode(false)
                    .HasColumnName("InviteID");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasSessionSchedulings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_SessionScheduling_t_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasSessionSchedulings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_SessionScheduling_t_User");
            });

            modelBuilder.Entity<CasSfOpportunity>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OpportunityCrmId });

                entity.ToTable("cas_SfOpportunity");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OpportunityCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectResponsible)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityRecordUrl).HasColumnName("OpportunityRecordURL");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveConnectDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasSfOpportunity0419>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunity_04_19");

                entity.Property(e => e.AccountCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectResponsible)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveConnectDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasSfOpportunityHistory>(entity =>
            {
                entity.ToTable("cas_SfOpportunityHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custom)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<CasSfOpportunityHistory0419>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunityHistory_04_19");

                entity.Property(e => e.Amount)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custom)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<CasSfOpportunityHistoryLatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunityHistory_latest");

                entity.Property(e => e.Amount)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custom)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<CasSfOpportunityHistoryRc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunityHistory_RC");

                entity.Property(e => e.Amount)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custom)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Probability)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<CasSfOpportunityLatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunity_latest");

                entity.Property(e => e.AccountCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectResponsible)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveConnectDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasSfOpportunityRc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_SfOpportunity_RC");

                entity.Property(e => e.AccountCrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectResponsible)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PositiveConnectDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasShareRecordingHash>(entity =>
            {
                entity.ToTable("cas_ShareRecordingHash");

                entity.Property(e => e.Id).HasColumnName("ID");
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

            modelBuilder.Entity<CasTaskDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_TaskDetails");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NextTaskDetailId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaskId)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasTeam>(entity =>
            {
                entity.ToTable("cas_Team");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Users)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasTeams)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cas_Team__Compan__54817C4C");
            });

            modelBuilder.Entity<CasTrigger>(entity =>
            {
                entity.HasKey(e => e.TriggerId);

                entity.ToTable("cas_Trigger");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TriggerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasTriggers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_Trigger_t_Company");
            });

            modelBuilder.Entity<CasTriggerAction>(entity =>
            {
                entity.HasKey(e => e.TriggerActionId);

                entity.ToTable("cas_TriggerAction");

                entity.Property(e => e.ActionKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ActionValue).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FieldName).HasMaxLength(100);

                entity.Property(e => e.FieldValue).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerActions)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerAction_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerCondition>(entity =>
            {
                entity.HasKey(e => e.TriggerConditionId);

                entity.ToTable("cas_TriggerCondition");

                entity.Property(e => e.ComparisonValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConditionEvaluationType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TriggerConditionVariable)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerConditions)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerCondition_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerContactEffect>(entity =>
            {
                entity.HasKey(e => e.TriggerContactEffectsId);

                entity.ToTable("cas_TriggerContactEffects");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CasTriggerContactEffects)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerContactEffects_cas_Contact");

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.CasTriggerContactEffects)
                    .HasForeignKey(d => d.TriggerActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerContactEffects_cas_TriggerAction");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerContactEffects)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerContactEffects_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerError>(entity =>
            {
                entity.ToTable("cas_TriggerError");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CasTriggerGroup>(entity =>
            {
                entity.HasKey(e => e.TriggerGroupId);

                entity.ToTable("cas_TriggerGroup");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupCondition).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerGroups)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerGroup_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerGroupConditionMapping>(entity =>
            {
                entity.HasKey(e => e.TriggerGroupConditionMappingId);

                entity.ToTable("cas_TriggerGroupConditionMapping");

                entity.Property(e => e.MappingType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TriggerCondition)
                    .WithMany(p => p.CasTriggerGroupConditionMappings)
                    .HasForeignKey(d => d.TriggerConditionId)
                    .HasConstraintName("FK_cas_TriggerGroupConditionMapping_cas_TriggerCondition");

                entity.HasOne(d => d.TriggerGroup)
                    .WithMany(p => p.CasTriggerGroupConditionMappingTriggerGroups)
                    .HasForeignKey(d => d.TriggerGroupId)
                    .HasConstraintName("FK_cas_TriggerGroupConditionMapping_cas_TriggerGroup");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerGroupConditionMappings)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerGroupConditionMapping_cas_Trigger");

                entity.HasOne(d => d.TriggerParentGroup)
                    .WithMany(p => p.CasTriggerGroupConditionMappingTriggerParentGroups)
                    .HasForeignKey(d => d.TriggerParentGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerGroupConditionMapping_cas_TriggerParentGroup");
            });

            modelBuilder.Entity<CasTriggerList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_TriggerLists");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.List)
                    .WithMany()
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerLists_cas_List");

                entity.HasOne(d => d.Trigger)
                    .WithMany()
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerLists_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerProspectRemovedFromList>(entity =>
            {
                entity.HasKey(e => e.TriggerProspectRemovedFromListId);

                entity.ToTable("cas_TriggerProspectRemovedFromList");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerExecutionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CasTriggerProspectRemovedFromLists)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerProspectRemovedFromList_cas_Contact");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasTriggerProspectRemovedFromLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerProspectRemovedFromList_cas_List");

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.CasTriggerProspectRemovedFromLists)
                    .HasForeignKey(d => d.TriggerActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerProspectRemovedFromList_cas_TriggerAction");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerProspectRemovedFromLists)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerProspectRemovedFromList_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerTaskConfig>(entity =>
            {
                entity.HasKey(e => e.TriggerTaskConfigId)
                    .HasName("PK__cas_Trig__D5CC23C7E526623D");

                entity.ToTable("cas_TriggerTaskConfig");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaskComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TaskStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaskSubject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.CasTriggerTaskConfigs)
                    .HasForeignKey(d => d.TriggerActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerTaskConfig_cas_TriggerAction");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerTaskConfigs)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerTaskConfig_cas_Trigger");
            });

            modelBuilder.Entity<CasTriggerVoicemail>(entity =>
            {
                entity.HasKey(e => e.TriggerVoicemailId)
                    .HasName("PK_cas_TriggersVoicemail");

                entity.ToTable("cas_TriggerVoicemail");

                entity.Property(e => e.VoicemailName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.List)
                    .WithMany(p => p.CasTriggerVoicemails)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerVoicemail_cas_List");

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.CasTriggerVoicemails)
                    .HasForeignKey(d => d.TriggerActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerVoicemail_cas_TriggerAction");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CasTriggerVoicemails)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerVoicemail_cas_Trigger");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasTriggerVoicemails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_TriggerVoicemail_t_User");
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

            modelBuilder.Entity<CasUserArticleViewMapping>(entity =>
            {
                entity.HasKey(e => e.UserArticleViewMappingId)
                    .HasName("PK__cas_User__0B5C2DE48F9410E4");

                entity.ToTable("cas_UserArticleViewMapping");

                entity.Property(e => e.UserArticleViewMappingId).HasColumnName("UserArticleViewMappingID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ViewedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.CasUserArticleViewMappings)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK__cas_UserA__Artic__6C5905DD");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasUserArticleViewMappings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__cas_UserA__UserI__6D4D2A16");
            });

            modelBuilder.Entity<CasUserContactAolist>(entity =>
            {
                entity.ToTable("cas_UserContactAOList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActOnListId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactActOnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasUserEnvironmentMapper>(entity =>
            {
                entity.HasKey(e => e.MapperId)
                    .HasName("PK__cas_User__49305D26124F6B0C");

                entity.ToTable("cas_UserEnvironmentMapper");

                entity.Property(e => e.EnvCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnvImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("EnvImageURL");

                entity.Property(e => e.EnvLoginEmailId).IsUnicode(false);

                entity.Property(e => e.EnvLoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSsoenabled).HasColumnName("IsSSOEnabled");

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdentifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Environment)
                    .WithMany(p => p.CasUserEnvironmentMappers)
                    .HasForeignKey(d => d.EnvironmentId)
                    .HasConstraintName("FK__cas_UserE__Envir__6E414E4F");
            });

            modelBuilder.Entity<CasUserGreeting>(entity =>
            {
                entity.HasKey(e => e.GreetingId);

                entity.ToTable("cas_UserGreeting");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<CasUserInvitation>(entity =>
            {
                entity.HasKey(e => e.UserInvitationId)
                    .HasName("PK__cas_User__5D3FD9F8DE69B8CE");

                entity.ToTable("cas_UserInvitation");

                entity.Property(e => e.UserInvitationId).HasColumnName("UserInvitationID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.EmailKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.InvitationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CasUserInvitations)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__cas_UserI__Compa__6F357288");

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.CasUserInvitationCreatedByUsers)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .HasConstraintName("FK__cas_UserI__Creat__702996C1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasUserInvitationUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__cas_UserI__UserI__711DBAFA");
            });

            modelBuilder.Entity<CasUserSession>(entity =>
            {
                entity.HasKey(e => e.UserSessionId);

                entity.ToTable("cas_UserSession");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_IP");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasUserSessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_UserSession_t_User");
            });

            modelBuilder.Entity<CasUserSetting>(entity =>
            {
                entity.HasKey(e => e.UserSettingId);

                entity.ToTable("cas_UserSetting");

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CasUserSettings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cas_UserSetting_t_User");
            });

            modelBuilder.Entity<CasUserVoicemail>(entity =>
            {
                entity.HasKey(e => e.VoicemailId);

                entity.ToTable("cas_UserVoicemail");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<CasValvalTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_ValvalTemp");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.PwdUserName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Pwd_UserName");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VarVal)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("var_val");
            });

            modelBuilder.Entity<CasVarval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cas_Varval");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.LoginUserName)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Login_UserName");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VarVal)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("var_val");
            });

            modelBuilder.Entity<CasWriteback>(entity =>
            {
                entity.ToTable("cas_Writeback");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiCallType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmObjectType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CrmUserId)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LeadContactFieldValue)
                    .IsUnicode(false)
                    .HasColumnName("leadContactFieldValue");

                entity.Property(e => e.LeadContactUrl).HasColumnName("LeadContactURL");

                entity.Property(e => e.ListName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodType).HasMaxLength(10);

                entity.Property(e => e.PreferredCrm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaskFieldValue)
                    .IsUnicode(false)
                    .HasColumnName("taskFieldValue");

                entity.Property(e => e.TaskUrl).HasColumnName("TaskURL");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasZendeskArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK__cas_Zend__9C6270C8513237FA");

                entity.ToTable("cas_ZendeskArticles");

                entity.Property(e => e.ArticleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ArticleID");

                entity.Property(e => e.ArticleCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ArticleName).HasMaxLength(512);

                entity.Property(e => e.ArticleSnippet).HasMaxLength(512);

                entity.Property(e => e.ArticleTitle).HasMaxLength(512);

                entity.Property(e => e.ArticleUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<CgAttribute>(entity =>
            {
                entity.ToTable("cgAttribute");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangePwd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangePwd");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName).HasMaxLength(4000);

                entity.Property(e => e.AgentNumber).HasMaxLength(128);

                entity.Property(e => e.AgentPassword).HasMaxLength(128);

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

                entity.Property(e => e.FullName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginBridge).HasMaxLength(130);

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

                entity.Property(e => e.NewLoginId)
                    .HasMaxLength(52)
                    .IsUnicode(false)
                    .HasColumnName("NewLoginID");

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

                entity.Property(e => e.VarValNew)
                    .HasMaxLength(360)
                    .HasColumnName("Var_Val_New");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiCastIronTLead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CI_CastIron_t_Lead");

                entity.Property(e => e.CompanyAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
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

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastPitcherNote).IsUnicode(false);

                entity.Property(e => e.PitcherDisposition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesForceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesForceID");

                entity.Property(e => e.Seq).ValueGeneratedOnAdd();

                entity.Property(e => e.WaitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClosedFacility>(entity =>
            {
                entity.HasNoKey();

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<CompanyCompare>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CompanyCompare");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TCompanyId).HasColumnName("tCompanyID");
            });

            modelBuilder.Entity<CompanyNameMismatchDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CallCompanyname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.TcallId).HasColumnName("tcallId");
            });

            modelBuilder.Entity<ConnectCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConnectCount");
            });

            modelBuilder.Entity<ContactNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactNumber");

                entity.Property(e => e.CallConnectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CallConnected Time");

                entity.Property(e => e.CallDisconnectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Call Disconnected time");

                entity.Property(e => e.CallPlacedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContactSightCommunication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contact_SightCommunications");

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

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.HashValue)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

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

            modelBuilder.Entity<ContactbckpSandlerSharper>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONTACTBCKP_Sandler_sharper");

                entity.Property(e => e.Contactcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTCOUNTRY");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Newphone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEWPHONE1");

                entity.Property(e => e.Newphone2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NEWPHONE2");

                entity.Property(e => e.Oldphone1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OLDPHONE1");

                entity.Property(e => e.Oldphone2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OLDPHONE2");
            });

            modelBuilder.Entity<CrmidAttempt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRMID_Attempt");

                entity.Property(e => e.CompanyAccount).HasMaxLength(255);

                entity.Property(e => e.DirectPhone).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastInitialName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LeadId)
                    .HasMaxLength(255)
                    .HasColumnName("LeadID");

                entity.Property(e => e.LeadStatus).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<CrmtypeMaster>(entity =>
            {
                entity.ToTable("CRMTypeMaster");

                entity.HasIndex(e => e.CrmtypeName, "CRMTypeMaster_UQ")
                    .IsUnique();

                entity.HasIndex(e => e.Crmsystem, "CRMTypeMaster_UQ1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CRMSystem")
                    .HasComputedColumnSql("(CONVERT([varchar](3),[ID]))", true);

                entity.Property(e => e.CrmtypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMTypeName");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SQLStress")
                    .IsClustered(false);

                entity.ToTable("Data", "SQLStress");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccessCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Document).HasColumnType("image");

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Username)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<DbaLoadStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dba_LoadStatus");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<DeletedContactId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deletedContactId");

                entity.Property(e => e.ContactId).HasColumnName("contactId");
            });

            modelBuilder.Entity<DirectNumber0821>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DirectNumber_0821");

                entity.Property(e => e.ActualAttemptedNumber).HasColumnName("Actual Attempted Number");

                entity.Property(e => e.AttemptDate).HasColumnType("datetime");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CrmId).HasMaxLength(255);

                entity.Property(e => e.CrmUrl).HasMaxLength(255);

                entity.Property(e => e.Disposition).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.ListName).HasMaxLength(255);

                entity.Property(e => e.OriginListName).HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(255)
                    .HasColumnName("Phone 1");

                entity.Property(e => e.Phone2).HasColumnName("Phone 2");

                entity.Property(e => e.Phone2New)
                    .HasMaxLength(255)
                    .HasColumnName("Phone2_New");

                entity.Property(e => e.TeamName).HasMaxLength(255);

                entity.Property(e => e.TimeZone).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.User).HasMaxLength(255);
            });

            modelBuilder.Entity<DncAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DncAll");

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DncFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DNC_Final");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

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

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
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

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
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

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DncContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNC_ContactCountry");

                entity.Property(e => e.DncCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DNC_CreateDate");

                entity.Property(e => e.DncDeleted).HasColumnName("DNC_Deleted");

                entity.Property(e => e.DncId).HasColumnName("Dnc_ID");

                entity.Property(e => e.DncModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DNC_ModUser");

                entity.Property(e => e.DncModdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DNC_Moddate");

                entity.Property(e => e.DncUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DNC_User");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

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

                entity.Property(e => e.Match).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameCatchTime).HasColumnType("datetime");

                entity.Property(e => e.NoteText).IsUnicode(false);

                entity.Property(e => e.PhoneSysConnectTime).HasColumnType("datetime");

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

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

            modelBuilder.Entity<DncFinal2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DNC_Final_2");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_CampaignName");

                entity.Property(e => e.CCampaignUserId).HasColumnName("C_CampaignUserId");

                entity.Property(e => e.CContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_ContactCountry");

                entity.Property(e => e.CCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_CreateDate");

                entity.Property(e => e.CCreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_CreateUser");

                entity.Property(e => e.CId).HasColumnName("C_ID");

                entity.Property(e => e.CIsDeleted).HasColumnName("C_IsDeleted");

                entity.Property(e => e.CModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_ModDate");

                entity.Property(e => e.CModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_ModUser");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

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

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
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

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
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

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DialedProbableDirectNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispositionText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

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

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

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

            modelBuilder.Entity<DncFinalF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DNC_Final_F");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CallAlert)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CallSendTime).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

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

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
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

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(100)
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

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
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

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

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

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.ProblemComments).IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

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

            modelBuilder.Entity<DncP1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DncP1");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DncP2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DncP2");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel2)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DncRem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DncRem");

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DncRemaining>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DncRemaining");

                entity.Property(e => e.ContactTel1)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DuplicateWrongDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition).HasMaxLength(500);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Disposition).HasMaxLength(500);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPenalizedDate).HasColumnType("datetime");

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<FisherBadDuplicate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FisherBadDuplicate");

                entity.Property(e => e.AgentDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AuditId).ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientFacingDisposition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Crmobject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMObject");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Listname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pbdisposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBDisposition");

                entity.Property(e => e.Pbphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBPhone");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemovalDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.StatusPhone1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPhone3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<FuzzyCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_Company");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Company_Id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Company_Name");
            });

            modelBuilder.Entity<FuzzyCompany2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_Company2");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Company_Id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Company_Name");
            });

            modelBuilder.Entity<FuzzyCompanyFinalMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_company_final_match");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCompanyId).HasColumnName("first_company_id");

                entity.Property(e => e.FirstCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_company_name");

                entity.Property(e => e.MatchScore).HasColumnName("match_score");

                entity.Property(e => e.SecondCompanyId).HasColumnName("second_company_id");

                entity.Property(e => e.SecondCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("second_company_name");
            });

            modelBuilder.Entity<FuzzyCompanyFinalMatchAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_company_final_match_all");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCompanyId).HasColumnName("first_company_id");

                entity.Property(e => e.FirstCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_company_name");

                entity.Property(e => e.SecondCompanyId).HasColumnName("second_company_id");

                entity.Property(e => e.SecondCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("second_company_name");
            });

            modelBuilder.Entity<FuzzyCompanyFinalMatchBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_company_final_match_backup");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCompanyId).HasColumnName("first_company_id");

                entity.Property(e => e.FirstCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_company_name");

                entity.Property(e => e.SecondCompanyId).HasColumnName("second_company_id");

                entity.Property(e => e.SecondCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("second_company_name");
            });

            modelBuilder.Entity<FuzzyCompanyTempMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_company_temp_match");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCompanyId).HasColumnName("first_company_id");

                entity.Property(e => e.FirstCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_company_name");

                entity.Property(e => e.MatchScore).HasColumnName("match_score");

                entity.Property(e => e.SecondCompanyId).HasColumnName("second_company_id");

                entity.Property(e => e.SecondCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("second_company_name");
            });

            modelBuilder.Entity<FuzzyMatchedCompanyName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fuzzy_MatchedCompanyNames");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCompanyId).HasColumnName("first_company_id");

                entity.Property(e => e.FirstCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_company_name");

                entity.Property(e => e.MatchScore).HasColumnName("match_score");

                entity.Property(e => e.SecondCompanyId).HasColumnName("second_company_id");

                entity.Property(e => e.SecondCompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("second_company_name");
            });

            modelBuilder.Entity<HubspotObjectRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("HubspotObjectRecords", "Sync");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Comments).HasMaxLength(550);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CompanyUrl).HasMaxLength(1000);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).IsUnicode(false);

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

                entity.Property(e => e.CrmownerId)
                    .IsUnicode(false)
                    .HasColumnName("CRMOwnerId");

                entity.Property(e => e.CrmtimeZone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRMTimeZone");

                entity.Property(e => e.Custom).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LeadSource).HasMaxLength(200);

                entity.Property(e => e.LinkedInUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralCustom).IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<JobHistoryByCompany>(entity =>
            {
                entity.HasKey(e => e.JobParamId)
                    .HasName("PK__JobHisto__EBD0CAA8EB7AA0C7");

                entity.ToTable("JobHistoryByCompany");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jsontemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jsontemp");

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Statename)
                    .IsUnicode(false)
                    .HasColumnName("statename");
            });

            modelBuilder.Entity<LatestDataNoAttempt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LatestData_NoAttempt");

                entity.Property(e => e.CampaignListName).HasMaxLength(255);

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.DirectPhone).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastAttemptDate).HasColumnType("datetime");

                entity.Property(e => e.LastAttemptedDateCas)
                    .HasColumnType("datetime")
                    .HasColumnName("LastAttemptedDate_CAS");

                entity.Property(e => e.LastAttemptedDateSfdc)
                    .HasColumnType("datetime")
                    .HasColumnName("LastAttemptedDate_SFDC");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LeadId)
                    .HasMaxLength(255)
                    .HasColumnName("LeadID");

                entity.Property(e => e.LightningListStatus).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SessionLeads");
            });

            modelBuilder.Entity<LeadTime30jan23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LeadTime_30Jan23");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<ListContactSightCommunication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListContact_SightCommunications");

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<ListTypeDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("listTypeData");

                entity.Property(e => e.ListName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogTable");

                entity.Property(e => e.Executed).HasColumnType("datetime");

                entity.Property(e => e.ExecutedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fragmentation).HasColumnName("FRAGMENTATION");

                entity.Property(e => e.Tsqlstatement)
                    .IsUnicode(false)
                    .HasColumnName("TSQLStatement");
            });

            modelBuilder.Entity<MappingBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mappingBak");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");

                entity.Property(e => e.Crmsystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMSystem");

                entity.Property(e => e.MappingId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<MappingDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmobjectType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CRMObjectType");
            });

            modelBuilder.Entity<MappingFieldBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mappingFieldBak");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.MappingFieldId).ValueGeneratedOnAdd();

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");
            });

            modelBuilder.Entity<MlAreaCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ml_AreaCode");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TimeZone).HasMaxLength(255);

                entity.Property(e => e.Zip).HasMaxLength(255);
            });

            modelBuilder.Entity<MlCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ml_Company");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.CompanyTel1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Industry).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NameN).HasMaxLength(255);

                entity.Property(e => e.SecondaryIndustry).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(255);

                entity.Property(e => e.Zip)
                    .HasMaxLength(255)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<MlCompanyNormalizationMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ml_CompanyNormalizationMapping");

                entity.HasIndex(e => e.Name, "ml_CompanyNormalizationMapping_name_unq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameN)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<MlTitle>(entity =>
            {
                entity.ToTable("ml_Title");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.JobFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleN)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlTitleLookup>(entity =>
            {
                entity.HasKey(e => e.Title);

                entity.ToTable("ml_TitleLookup");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NegativeTalkTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NegativeTalkTime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<NodeFollowUpDeletedContact>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<NodeLeadPoolDeletedContact>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IsConnected).HasColumnName("isConnected");
            });

            modelBuilder.Entity<NotAttempted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NotAttempted");

                entity.Property(e => e.CampaignListName)
                    .HasMaxLength(255)
                    .HasColumnName("Campaign List Name");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Direct Phone");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptedDateAttemptsHistory)
                    .HasColumnType("datetime")
                    .HasColumnName("Last Attempted Date _(Attempts History)");

                entity.Property(e => e.LastAttemptedDateSfdc)
                    .HasColumnType("datetime")
                    .HasColumnName("Last Attempted Date (SFDC)");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.LeadId)
                    .HasMaxLength(255)
                    .HasColumnName("Lead ID");

                entity.Property(e => e.LightningListStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Lightning List Status");

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<Opportunitiesfq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("opportunitiesfq");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityCreatedate).HasColumnType("datetime");

                entity.Property(e => e.OpportunityCrmId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhoneId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PhoneId");
            });

            modelBuilder.Entity<PitcherSessionBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PitcherSession_Backup");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<PreviewRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__PreviewR__33A8519ADF5B23C5");

                entity.ToTable("PreviewRequest");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.PreviewRequestBody).IsRequired();

                entity.Property(e => e.PreviewRequestDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.PreviewRequestKey)
                    .WithMany(p => p.PreviewRequests)
                    .HasPrincipalKey(p => new { p.RequestKey, p.RequestUserId })
                    .HasForeignKey(d => new { d.RequestKey, d.UserId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PreviewRequestPreviewRequestKeyFK1");
            });

            modelBuilder.Entity<PreviewRequestKey>(entity =>
            {
                entity.HasKey(e => e.RequestKey)
                    .HasName("PK__PreviewR__F6AC419C7CB6BC77");

                entity.ToTable("PreviewRequestKey");

                entity.HasIndex(e => new { e.RequestKey, e.RequestUserId }, "PreviewRequestKeyRequestKeyRequestUserIDUK1")
                    .IsUnique();

                entity.Property(e => e.RequestKey).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestUserId).HasColumnName("RequestUserID");

                entity.Property(e => e.RequestedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PreviewRequestResult>(entity =>
            {
                entity.HasKey(e => e.ResultId)
                    .HasName("PK__PreviewR__9769022863020CCA");

                entity.ToTable("PreviewRequestResult");

                entity.Property(e => e.ResultId).HasColumnName("ResultID");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.ResultGenerationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.PreviewRequestResults)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PreviewRequestResultPreviewRequestFK1");
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Query");

                entity.Property(e => e.ContactFieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmfieldName)
                    .HasMaxLength(100)
                    .HasColumnName("CRMFieldName");

                entity.Property(e => e.CrmfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRMFieldType");

                entity.Property(e => e.ValidateInCrm).HasColumnName("ValidateInCRM");
            });

            modelBuilder.Entity<ResourceLock>(entity =>
            {
                entity.HasKey(e => e.ResourceKey)
                    .HasName("PK__Resource__3B5BC9BF8BC537DA");

                entity.ToTable("ResourceLOCK");

                entity.Property(e => e.ResourceKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoldReleaseUserContext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Spid).HasColumnName("SPID");
            });

            modelBuilder.Entity<ResourceLockHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK__Resource__4D7B4ADDE75BA732");

                entity.ToTable("ResourceLockHistory");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.HoldReleaseUserContext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LockAcquiredOn).HasColumnName("LockAcquiredON");

                entity.Property(e => e.LockReleasedOn).HasColumnName("LockReleasedON");

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spid).HasColumnName("SPID");
            });

            modelBuilder.Entity<SAttemptHistorySummary>(entity =>
            {
                entity.ToTable("s_AttemptHistorySummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaCode).HasMaxLength(7);

                entity.Property(e => e.CallDate).HasColumnType("date");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DialedNumber).HasMaxLength(40);

                entity.Property(e => e.IsIvr).HasColumnName("IsIVR");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.PreviousAgent).HasMaxLength(100);

                entity.Property(e => e.PreviousAgentCompanyName).HasMaxLength(100);

                entity.Property(e => e.PreviousAgentLocationCode).HasMaxLength(50);

                entity.Property(e => e.PreviousDisposition).HasMaxLength(50);
            });

            modelBuilder.Entity<SAttemptSummary>(entity =>
            {
                entity.HasKey(e => e.AttemptSummaryId);

                entity.ToTable("s_AttemptSummary");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SAttemptSummaries)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_AttemptSummary_cas_Contact");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.SAttemptSummaries)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_s_AttemptSummary_cas_List");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SAttemptSummaries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_AttemptSummary_t_User");
            });

            modelBuilder.Entity<SCallsSummary>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Month, e.Day });

                entity.ToTable("s_CallsSummary");
            });

            modelBuilder.Entity<SConnectsSummary>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Month, e.Day, e.ClientId, e.UserId, e.SessionType });

                entity.ToTable("s_ConnectsSummary");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SLeaderBoardSummary>(entity =>
            {
                entity.ToTable("s_LeaderBoardSummary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.CampaignName).IsRequired();

                entity.Property(e => e.ClientName).IsRequired();

                entity.Property(e => e.ClientSvcManager).IsRequired();

                entity.Property(e => e.ScheduledEnd).IsRequired();

                entity.Property(e => e.ScheduledStart).IsRequired();

                entity.Property(e => e.SessionType).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            modelBuilder.Entity<SessionActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.SessionActivities)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SessionSessionActivity");
            });

            modelBuilder.Entity<SessionNote>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.NoteId, e.NoteType })
                    .HasName("PK_dbo_SessionNotes_1");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.NoteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NoteID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NoteTypeNavigation)
                    .WithMany(p => p.SessionNotes)
                    .HasForeignKey(d => d.NoteType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_SessionNotes_2");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.SessionNotes)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SessionSessionNotes");
            });

            modelBuilder.Entity<SettingsBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Settings_Bak");

                entity.Property(e => e.CompanySettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModDate).HasColumnType("datetime");

                entity.Property(e => e.LastModUser).HasMaxLength(100);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<SightCommunication>(entity =>
            {
                entity.HasNoKey();

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<Summary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Summary");

                entity.Property(e => e.Datediff).HasColumnName("DATEDIFF");

                entity.Property(e => e.Maxdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MAXDate");

                entity.Property(e => e.Mindate)
                    .HasColumnType("datetime")
                    .HasColumnName("MINDATE");
            });

            modelBuilder.Entity<Summry2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Summry_2");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<T1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t1");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Throwtime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TAccountHistory>(entity =>
            {
                entity.ToTable("t_AccountHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Description)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EntryType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

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

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TAccountHistories)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_AccountHistory_t_Company");
            });

            modelBuilder.Entity<TActivity>(entity =>
            {
                entity.ToTable("t_Activity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAgentActivity>(entity =>
            {
                entity.ToTable("t_AgentActivity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Tsguid).HasColumnName("TSGuid");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAgentNote>(entity =>
            {
                entity.ToTable("t_AgentNotes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentDisposition)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TAgentSession>(entity =>
            {
                entity.ToTable("t_AgentSession");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentIdentifier)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.HourlyRate).HasDefaultValueSql("((900))");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

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
            });

            modelBuilder.Entity<TAsteriskRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_AsteriskRef");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Configuration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IaxFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SipFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAsteriskRef07092021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_AsteriskRef_07092021");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Configuration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IaxFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SipFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBilledSession>(entity =>
            {
                entity.ToTable("t_BilledSession");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentHours).HasColumnType("money");

                entity.Property(e => e.BilledHours).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.PauseMinutes).HasColumnType("money");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");

                entity.Property(e => e.ScheduledSessionId).HasColumnName("ScheduledSessionID");

                entity.Property(e => e.ScheduledStart).HasColumnType("datetime");

                entity.Property(e => e.SessionHours).HasColumnType("money");

                entity.Property(e => e.SessionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TalkMinutes).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TBilledSessions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_BilledSession_t_Company");

                entity.HasOne(d => d.ScheduledSession)
                    .WithMany(p => p.TBilledSessions)
                    .HasForeignKey(d => d.ScheduledSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_BilledSession_t_ScheduledSession");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TBilledSessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_BilledSession_t_User");
            });

            modelBuilder.Entity<TCall>(entity =>
            {
                entity.ToTable("t_Call");

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
                    .HasMaxLength(100)
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

            modelBuilder.Entity<TCall30jan23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_30Jan23");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCall31jan23>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_31Jan23");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallArchiveDataApril2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_ArchiveDataApril2018");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

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

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCallArchiveDataCommonDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_ArchiveData_CommonData");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

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

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
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

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCallArchiveDataJune>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_ArchiveData_June");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

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

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCallArchiveDatum>(entity =>
            {
                entity.ToTable("t_Call_ArchiveData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualLeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.CachedLeadDisplayTime).HasColumnType("datetime");

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

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
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

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCallBackup24July>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_call_backup_24_July");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_Bkp");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallFirstqt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_call_firstqt");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallFuzzy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_fuzzy");

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

            modelBuilder.Entity<TCallKry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_Krys");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallNA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_N/A");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallWrongDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Call_WrongData");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TCallbckp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_callbckp");

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

            modelBuilder.Entity<TCallerId>(entity =>
            {
                entity.ToTable("t_CallerId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Iso2countryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode")
                    .HasDefaultValueSql("('US')");

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
            });

            modelBuilder.Entity<TCallerId20220629>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_CallerId_20220629");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iso2countryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TCallerIdBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_CallerId_Bkp");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iso2countryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TCallerIdMapping>(entity =>
            {
                entity.ToTable("t_CallerIdMapping");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCountryIso2code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DefaultCountryISO2Code");

                entity.Property(e => e.Iso2countryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode");
            });

            modelBuilder.Entity<TCallerIdUsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_CallerID_US_Backup");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iso2countryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TCallerIdbckup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_CallerIdbckup");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iso2countryCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO2CountryCode");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TCampaign>(entity =>
            {
                entity.ToTable("t_Campaign");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageRequirements).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.PitcherId).HasColumnName("PitcherID");

                entity.Property(e => e.PitcherIdentifier)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001-01-01')");

                entity.Property(e => e.ScheduledStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001-01-01')");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructions)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserIdentifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TCampaigns)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Campaign_CompanyID");
            });

            modelBuilder.Entity<TCompany>(entity =>
            {
                entity.ToTable("t_Company");

                entity.Property(e => e.Id).HasColumnName("ID");

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

            modelBuilder.Entity<TContact>(entity =>
            {
                entity.ToTable("t_Contact");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HashKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastKnownValid).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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
            });

            modelBuilder.Entity<TContactPhoneNumber>(entity =>
            {
                entity.ToTable("t_ContactPhoneNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionalIvrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AdditionalIVRPath");

                entity.Property(e => e.AdditionalIvrpathCount).HasColumnName("AdditionalIVRPathCount");

                entity.Property(e => e.AdditionalIvrpathTime).HasColumnName("AdditionalIVRPathTime");

                entity.Property(e => e.AdditionalIvrpathTimeStdDev).HasColumnName("AdditionalIVRPathTimeStdDev");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DispositionText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDirectModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.IsIvrpathValidated).HasColumnName("IsIVRPathValidated");

                entity.Property(e => e.Ivrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IVRPath");

                entity.Property(e => e.IvrpathCount).HasColumnName("IVRPathCount");

                entity.Property(e => e.IvrpathNote)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IVRPathNote");

                entity.Property(e => e.IvrpathScore).HasColumnName("IVRPathScore");

                entity.Property(e => e.IvrpathTime).HasColumnName("IVRPathTime");

                entity.Property(e => e.IvrpathTimeStdDev).HasColumnName("IVRPathTimeStdDev");

                entity.Property(e => e.LastAutoAgentAttemptDate).HasColumnType("datetime");

                entity.Property(e => e.LastConnectDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TContactPhoneNumbers)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ContacPhoneNumber_t_Contact");

                entity.HasOne(d => d.PhoneNumber)
                    .WithMany(p => p.TContactPhoneNumbers)
                    .HasForeignKey(d => d.PhoneNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ContacPhoneNumber_t_PhoneNumber");
            });

            modelBuilder.Entity<TContactSummary>(entity =>
            {
                entity.HasKey(e => e.ContactSummaryId)
                    .HasName("PK_t_ContactSummary_1");

                entity.ToTable("t_ContactSummary");

                entity.Property(e => e.FirstConnectTime).HasColumnType("datetime");

                entity.Property(e => e.FirstDialTime).HasColumnType("datetime");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptDisposition).HasMaxLength(50);

                entity.Property(e => e.LastConnectDate).HasColumnType("date");

                entity.Property(e => e.LastConnectDisposition)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TContactSummaries)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ContactSummary_cas_contact");
            });

            modelBuilder.Entity<TContactSummaryMergedDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_ContactSummary_MergedData");

                entity.Property(e => e.ContactSummaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstConnectTime).HasColumnType("datetime");

                entity.Property(e => e.FirstDialTime).HasColumnType("datetime");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptDisposition).HasMaxLength(50);

                entity.Property(e => e.LastConnectDate).HasColumnType("date");

                entity.Property(e => e.LastConnectDisposition).HasMaxLength(50);
            });

            modelBuilder.Entity<TContactSummaryNewDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_contactSummary_NewData");

                entity.Property(e => e.ContactSummaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstConnectTime).HasColumnType("datetime");

                entity.Property(e => e.FirstDialTime).HasColumnType("datetime");

                entity.Property(e => e.LastAttemptDate).HasColumnType("date");

                entity.Property(e => e.LastAttemptDisposition).HasMaxLength(50);

                entity.Property(e => e.LastConnectDate).HasColumnType("date");

                entity.Property(e => e.LastConnectDisposition).HasMaxLength(50);
            });

            modelBuilder.Entity<TContract>(entity =>
            {
                entity.ToTable("t_Contract");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TContracts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Contract_t_Company");
            });

            modelBuilder.Entity<TContractAppendix>(entity =>
            {
                entity.ToTable("t_ContractAppendix");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.EngagementEnd).HasColumnType("datetime");

                entity.Property(e => e.EngagementName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EngagementStart).HasColumnType("datetime");

                entity.Property(e => e.GrandTotal).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ProservTotal).HasColumnType("money");

                entity.Property(e => e.RatePerConnect).HasColumnType("money");

                entity.Property(e => e.RatePerHour).HasColumnType("money");

                entity.Property(e => e.RecurrenceType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueRecognitionType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesTotal).HasColumnType("money");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.TContractAppendices)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ContractAppendix_t_Contract");
            });

            modelBuilder.Entity<TCountryInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_CountryInfo");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DomesticFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IddCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntlFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iso2Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Iso3Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NddCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RootName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TCrmParamSet>(entity =>
            {
                entity.ToTable("t_CrmParamSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DataSourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ParamA)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ParamB)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ParamC)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamD)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamE)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamF)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserIdentifier)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDisposition>(entity =>
            {
                entity.ToTable("t_Disposition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignIdentifier)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Text)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.TDispositions)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Disposition_CampaignID");
            });

            modelBuilder.Entity<TDispositionMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_DispositionMap");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromDisposition)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ToDisposition)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
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

            modelBuilder.Entity<TDncCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_Call");

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

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
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

            modelBuilder.Entity<TDncCall2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_Call_2");

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

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
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

            modelBuilder.Entity<TDncCallF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_Call_F");

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

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(100)
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

            modelBuilder.Entity<TDncCas20210107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_DNC_CAS_20210107");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDncCasNg20210107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_DNC_CAS_NG_20210107");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDncPb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_PB");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LeadtrasitId).HasColumnName("LeadtrasitID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDncPb2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_PB_2");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDncPbF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Dnc_PB_F");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompanyId).HasColumnName("ClientCompanyID");

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle).HasMaxLength(1000);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
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

            modelBuilder.Entity<TDxAppointment>(entity =>
            {
                entity.ToTable("t_DxAppointment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ListName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.RecurrenceEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.RecurrenceInfo).HasColumnType("ntext");

                entity.Property(e => e.RecurrenceStart).HasColumnType("smalldatetime");

                entity.Property(e => e.ReminderInfo).HasColumnType("ntext");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("ntext")
                    .HasColumnName("ResourceID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TEngineAllocatedActivity>(entity =>
            {
                entity.ToTable("t_EngineAllocatedActivity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EngineIdentifier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TExecuteLogStg>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_ExecuteLog_stg");

                entity.ToTable("t_execute_log_stg");

                entity.Property(e => e.LogId).HasColumnName("Log_Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Execution_Time");

                entity.Property(e => e.ParameterString)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Parameter_string");

                entity.Property(e => e.ParameterValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Parameter_value");

                entity.Property(e => e.SprocName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SProcName");
            });

            modelBuilder.Entity<TLead>(entity =>
            {
                entity.ToTable("t_Lead");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgentComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDispositionStamp).HasColumnType("datetime");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentNotes)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr1)
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(80)
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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CrmUrlFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DescA)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescB)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescC)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescD)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescE)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescF)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescG)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescH)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescJ)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeletedInCrm).HasColumnName("IsDeletedInCRM");

                entity.Property(e => e.LastPitcherNote).IsUnicode(false);

                entity.Property(e => e.LastVoicemail).HasColumnType("datetime");

                entity.Property(e => e.LeadSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListName)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.OwnerIdentifier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherDisposition)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherDispositionStamp).HasColumnType("datetime");

                entity.Property(e => e.PitcherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherNotes).IsUnicode(false);

                entity.Property(e => e.ReasonText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResearcherDate).HasColumnType("datetime");

                entity.Property(e => e.ResearcherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransitStamp).HasColumnType("datetime");

                entity.Property(e => e.UniqueIdentifier)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.VoicemailFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WaitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TLeadAppStat>(entity =>
            {
                entity.ToTable("t_LeadAppStat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DisposeTime).HasColumnType("datetime");

                entity.Property(e => e.LeadCatchTime).HasColumnType("datetime");

                entity.Property(e => e.LeadDisplayTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTransferTime).HasColumnType("datetime");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.PopupTime).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TLeadHistory>(entity =>
            {
                entity.HasKey(e => e.Xid);

                entity.ToTable("t_LeadHistory");

                entity.Property(e => e.Xid).HasColumnName("XID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgentComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDispositionStamp).HasColumnType("datetime");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentNotes)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CallerId)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddr1)
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(80)
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

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CrmUrlFormat)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DescA)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescB)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescC)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescD)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescE)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescF)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescG)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescH)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescI)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DescJ)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPitcherNote).IsUnicode(false);

                entity.Property(e => e.LastVoicemail).HasColumnType("datetime");

                entity.Property(e => e.LeadSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListName)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.OwnerIdentifier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherDisposition)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherDispositionStamp).HasColumnType("datetime");

                entity.Property(e => e.PitcherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PitcherNotes).IsUnicode(false);

                entity.Property(e => e.ReasonText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referrer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResearcherDate).HasColumnType("datetime");

                entity.Property(e => e.ResearcherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransitStamp).HasColumnType("datetime");

                entity.Property(e => e.UniqueIdentifier)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.VoicemailFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WaitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TMultiTouchLog>(entity =>
            {
                entity.ToTable("t_MultiTouchLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TName>(entity =>
            {
                entity.ToTable("t_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignIdentifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.NameType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Text)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.TNames)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Name_CampaignID");
            });

            modelBuilder.Entity<TNote>(entity =>
            {
                entity.ToTable("t_Note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ParentIdentifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPayment>(entity =>
            {
                entity.ToTable("t_Payment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractAppendixId).HasColumnName("ContractAppendixID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DueAmount).HasColumnType("money");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ReceivedAmount).HasColumnType("money");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Terms)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContractAppendix)
                    .WithMany(p => p.TPayments)
                    .HasForeignKey(d => d.ContractAppendixId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Payment_t_ContractAppendix");
            });

            modelBuilder.Entity<TPhoneCall>(entity =>
            {
                entity.ToTable("t_PhoneCall");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionalIvrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("AdditionalIVRPath");

                entity.Property(e => e.Amdresult)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AMDResult")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AutoNavigateIvr).HasColumnName("AutoNavigateIVR");

                entity.Property(e => e.CallConnectedTime).HasColumnType("datetime");

                entity.Property(e => e.CallDisconnectedTime).HasColumnType("datetime");

                entity.Property(e => e.CallPlacedTime).HasColumnType("datetime");

                entity.Property(e => e.CallerId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.DialedNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsAmd).HasColumnName("IsAMD");

                entity.Property(e => e.IsIvr).HasColumnName("IsIVR");

                entity.Property(e => e.IsIvrpathValidated).HasColumnName("IsIVRPathValidated");

                entity.Property(e => e.Ivrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IVRPath");

                entity.Property(e => e.IvrpathNote)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IVRPathNote");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");

                entity.Property(e => e.PhoneNumberIvrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PhoneNumberIVRPath");

                entity.Property(e => e.ReportComments).IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartNavAdditionalDbnivrtime)
                    .HasColumnType("datetime")
                    .HasColumnName("StartNavAdditionalDBNIVRTime")
                    .HasDefaultValueSql("('2001/01/01')");

                entity.Property(e => e.StartNavCompanyIvrtime)
                    .HasColumnType("datetime")
                    .HasColumnName("StartNavCompanyIVRTime");

                entity.Property(e => e.StartNavDbnivrtime)
                    .HasColumnType("datetime")
                    .HasColumnName("StartNavDBNIVRTime");

                entity.Property(e => e.TerminationCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAttachTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001/01/01')");

                entity.Property(e => e.UserBridgeTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001/01/01')");

                entity.Property(e => e.WasAnsweredByIvr).HasColumnName("WasAnsweredByIVR");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TPhoneCalls)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_PhoneCall_t_Contact");

                entity.HasOne(d => d.PhoneNumber)
                    .WithMany(p => p.TPhoneCalls)
                    .HasForeignKey(d => d.PhoneNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_PhoneCall_t_PhoneNumber");
            });

            modelBuilder.Entity<TPhoneNumber>(entity =>
            {
                entity.ToTable("t_PhoneNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallerIdString)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
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

                entity.Property(e => e.IsIvr).HasColumnName("IsIVR");

                entity.Property(e => e.IsIvrpathValidated).HasColumnName("IsIVRPathValidated");

                entity.Property(e => e.Ivrpath)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IVRPath");

                entity.Property(e => e.IvrpathCount).HasColumnName("IVRPathCount");

                entity.Property(e => e.IvrpathScore)
                    .HasColumnName("IVRPathScore")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IvrpathTime).HasColumnName("IVRPathTime");

                entity.Property(e => e.IvrpathTimeStdDev).HasColumnName("IVRPathTimeStdDev");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.NormalizedNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPitcherSession>(entity =>
            {
                entity.ToTable("t_PitcherSession");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.NumValidConnects).HasDefaultValueSql("((0))");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SessionEnd).HasColumnType("datetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionStart).HasColumnType("datetime");

                entity.Property(e => e.TotalSessionDialTime).HasDefaultValueSql("('0')");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.TPitcherSessions)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_PitcherSession_t_Session");
            });

            modelBuilder.Entity<TPitcherSessionDi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_PitcherSession_Dis");

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

                entity.Property(e => e.SessionEnd).HasColumnType("datetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionStart).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPitcherSessionKry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_PitcherSession_Krys");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TQuery>(entity =>
            {
                entity.ToTable("t_Query");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TQueryTerm>(entity =>
            {
                entity.ToTable("t_QueryTerm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QueryId).HasColumnName("QueryID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Query)
                    .WithMany(p => p.TQueryTerms)
                    .HasForeignKey(d => d.QueryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_QueryTerm_t_Query");
            });

            modelBuilder.Entity<TRolesHistory>(entity =>
            {
                entity.ToTable("t_RolesHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Colv).HasColumnName("COLV");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Crmadministrator).HasColumnName("CRMAdministrator");

                entity.Property(e => e.Elm).HasColumnName("ELM");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NativeSfdc).HasColumnName("NativeSFDC");

                entity.Property(e => e.Ood).HasColumnName("OOD");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TRolesHistories)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__t_RolesHi__Compa__0FA2421A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TRolesHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__t_RolesHi__UserI__10966653");
            });

            modelBuilder.Entity<TScheduledSession>(entity =>
            {
                entity.ToTable("t_ScheduledSession");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStart).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TScheduledSessions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ScheduledSession_t_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TScheduledSessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ScheduledSession_t_User");
            });

            modelBuilder.Entity<TScript>(entity =>
            {
                entity.ToTable("t_Script");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.Identifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsUnicode(false);
            });

            modelBuilder.Entity<TSession>(entity =>
            {
                entity.ToTable("t_Session");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualEnd).HasColumnType("datetime");

                entity.Property(e => e.ActualStart).HasColumnType("datetime");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.FirstGoTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001/01/01')");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastAgentCallTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2001/01/01')");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Administrator')");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ScheduledEnd).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStart).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TSessions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Session_t_Company");
            });

            modelBuilder.Entity<TSpecialInstruction>(entity =>
            {
                entity.ToTable("t_SpecialInstructions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TSpecialInstructions)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__t_Special__Compa__1466F737");
            });

            modelBuilder.Entity<TSys20210725>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_Sys_20210725");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSystemParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_SystemParameter");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTriggerLog>(entity =>
            {
                entity.ToTable("t_TriggerLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.TTriggerLogs)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_TriggerLog_cas_Contact");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.TTriggerLogs)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_TriggerLog_cas_List");

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.TTriggerLogs)
                    .HasForeignKey(d => d.TriggerActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_TriggerLog_cas_TriggerAction");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.TTriggerLogs)
                    .HasForeignKey(d => d.TriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_TriggerLog_cas_Trigger");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("t_User");

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

            modelBuilder.Entity<TUser20210711>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_User_20210711");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TUser20222803>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_User_2022_28_03");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TUserBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_User_BK");

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<TableSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableSize");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp1");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TempAttemptcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempAttemptcount");

                entity.Property(e => e.FirstConnectTime).HasColumnType("datetime");

                entity.Property(e => e.FirstDialDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TempPenalizedDnc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_PenalizedDNC");

                entity.Property(e => e.Agent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentDisposition).HasMaxLength(500);

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUserId).HasColumnName("CampaignUserID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Disposition).HasMaxLength(500);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dncexpires)
                    .HasColumnType("datetime")
                    .HasColumnName("DNCExpires");

                entity.Property(e => e.Dnctype).HasColumnName("DNCType");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPenalizedDate).HasColumnType("datetime");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pitcher)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Title).HasMaxLength(1000);
            });

            modelBuilder.Entity<TimeMetrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TimeMetrix");

                entity.Property(e => e.MaxDate).HasColumnType("datetime");

                entity.Property(e => e.MinDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TitleDictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TitleDictionary");

                entity.Property(e => e.GroupIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<TransitId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransitId");
            });

            modelBuilder.Entity<Typelkp>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__Typelkp__516F03953C581A5C");

                entity.ToTable("Typelkp");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeGrp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Used1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("used1");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Throwtime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WrapTimeReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WrapTimeReport");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.ThrowTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WrongContactDatum>(entity =>
            {
                entity.HasNoKey();

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

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
