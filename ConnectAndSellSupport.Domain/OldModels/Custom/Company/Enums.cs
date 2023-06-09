﻿namespace ConnectAndSellSupport.Domain.Models.Custom.Company
{
    public enum DispositionType : short
    {
        Negative = -1,
        Neutral = 0,
        Positive = 1
    }

    public enum DispositionMode : byte
    {
        Lightning = 1,
        Dialer = 2,
        COLV = 4
    }

    public enum CompanySettingType
    {
        Default,
        CrmApiUsername,
        CrmApiPassword,
        PortalId,
        CrmApiToken,
        CrmApiSalt,
        CrmApiCredentialsVerifiedDate,
        CrmUrlOverride,
        CrmOAuthEndpointRootOverride,
        CrmBaseUrl,
        CrmAuthToken,
        DynamicsViewPrefixFilter,
        ReferralsEnabled,
        RestrictNoteSyncinSalesloft,
        BaltoIntegrationEnable,
        LeadPoolSize,
        DialerDispositionsAdded,
        CreateNewListsEnabled,
        CsvListLoadingEnabled,
        UsePhoneNumberPriorityOptimization,
        CrmListReportFolders,
        SalesforceReportListsEnabled,
        ManagerCanDownloadLists,
        PitcherCanDownloadLists,
        UserAdminEnabled,
        BlindLeadPoolEnabled,
        LeadSourceAndStateFieldCheckEnabled,
        TimeZoneCheckEnabled,
        CountryCheckEnabled,
        TitlesCheckEnabled,
        ListFatigueCheck,
        AutoEnrichEnabled,
        NotificationSettingsEnabled,
        TimeZone,
        FollowUpCallsCheck,
        LeadInjectionEnabled,
        LeadInjectionTime,
        ConnectTaskFieldsEnabled,
        SubStatusEnabled,
        CrmShowAllReportFolders,
        NotificationSettings,
        MultiTouchEnabled,
        SmartListEnabled,
        CallFutureCallBackContacts,
        GracefulExitEnabled,
        BadNumberFiltering,
        WrongNumberFiltering,
        DncFiltering,
        CallRecordingFieldEnabled,
        AllowRepsToRateTheirOwnRecordings,
        RepsManagersExecSponsorsEmailGoalSettings,
        LoginNotificationSettings,
        LoginNotificationSettingsEnabled,
        EnrichOnIEEnabled,
        UpdateTaskStatusOnAttempt,
        LogoUrl,
        ActivityType,
        VSFEnabled,
        CsvLeadPoolEnabled,
        TaskAttemptsSyncEnabled,
        SecondarySubStatusEnabled,
        UpdateDialerTaskStatusOnAttempt,
        DualConsentRecordingsEnabled,
        ShowCountryNameOnConnectPopUp,
        HotTransferEnabled,
        EnableExtendedFilter,
        SalesforcePersonAccountEnabled,
        AppointmentInviteEmail,
        AppointmentInvitePassword,
        AppointmentInviteBody,
        FeedbackEmailBody,
        AppointmentInviteSubject,
        AppointmentInviteLocation,
        Accountobject,
        Prospectobject,
        TurnOffUpdateDueDate,
        TurnOffTemplateListValidation,
        WeeklyEmailAlert,
        OODEnabled,
        GoalSettings,
        ActOnEmail,
        HotTransferCallerID,
        RCLeadEmail,
        RepEmailIds,
        ReminderFromEmail,
        SendInvitationToProspect,
        SyncAgentDispositionEnabled,
        SessionScheduling,
        AttemptsThreshold,
        ConversationsThreshold,
        AppointmentInviteServiceProvider,
        CASLogs,
        WebsyncWebsocketEnabled,
        UseProbableDirectNumberEnabled,
        ConnectOnHelloEnabled,
        CallAfterTimeEnabled,
        CallOnDaysEnabled,
        PBRuleEnabled,
        MaxAttemptsRestricted,
        SchedulerInviteEmail,
        SchedulerInvitePassword,
        ActivityReportEmailAlert,
        VaronisStatusFieldSettings,
        ContactDisqualifiedStatus,
        LeadDisqualifiedStatus,
        ContactDisqualifiedSubStatus,
        LeadDisqualifiedSubStatus,
        AsteriskQueuesEnabled,
        OODNotificationEnabled,
        AttemptCounterSyncEnabled,
        AttemptDetailsSyncEnabled,
        ActivitySummaryReps,
        ActivitySummaryManagers,
        ConversionAlertManagersEmail,
        FollowUpCallListsCrm,
        PreferredAgentEnabled,
        AutoDetectVoiceMailForDirectNumber,
        PostRequestEnabled,
        ClickToDialSetting,
        ScoreCardReportManagers,
        IsTeamsEnabled,
        GateKeeperBlock,
        NegativeDispositionFiltering,
        LocalTouch,
        BhRestToken,
        BhRestUrl,
        CrmLinkOpenEnabled,
        TaskTypeSyncOnAttemptEnabled,
        SyncTaskReminderEnabled,
        TaskTypeEnabled,
        MostRecentCampaignFilter,
        EnableAutoRefreshListForCompany,
        DisableListRefresh,
        IsScorecardEnabled,
        ProductListEnabled,
        SyncTaskRelatedToFieldEnabled,
        CSVCompanyOnly,
        BlockPastDatedContacts,
        SendEmailOnCallPopupEnabled,
        TaskRecordingsUrlSyncEnabled,
        OpportunityWonStage,
        EnableHomeDashboard,
        IsPersonAccountEnabled,
        RepLockerEnabled,
        IsFollowUpDateOptional,
        EnableFollowUpEmail,
        TransferFollowUpContact,
        AutoLogOffSettingEnabled,
        AutoLogOffTime,
        AutoLogOffTimeAndExcludedRepIds,
        AgentCallAutoDisposeOnCallFailure,
        ZeroTalkTimeCallAutomation,
        DisableAutomation,
        PrioritizeTransferPredictedLeads,
        AttemptThrottlingUsingMl,
        SyncCampaignNameForCompletedTask,
        AllowMultipleVM,
        CloseOpenTasks,
        RealTimeConversationEnabled,
        RealTimeAlertReps,
        RealTimeDispositions,
        RealTimeAlertManagers,
        RealTimeProblemDispositions,
        SyncCampaignIdToTask,
        ActOnEmailEnabledForMultiTouch,
        CompanyIVRAutomationEnabled,
        DisableRecording,
        EnableDialerCallForLeadInjection,
        StopRecordingsAtHotTransfer,
        AllowPPforReps,
        PositiveConversationsThreshold,
        HourlyBreakdownActivityReportEnabled,
        NoPositiveConversationNotificationEnabled,
        MaxRatingScale,
        ShowTimeZoneInGMT,
        ShowGracefulExitInActivityReport,
        FTPCredentials,
        RestrictedAttemptsEnabled,
        MaxCallPerContact,
        NoOfDaysRecordingAvailable,
        DisqualifyDuplicateContactsEnabled,
        LeadCustomValue,
        ContactCustomValue,
        ShowLastConnectDispositionForCSV,
        DoNotUpdateLeadOwnerEnable,
        KNLeadEmail,
        BusinessStartHours,
        BusinessEndhours,
        LunchTimeZoneDetectionEnabled,
        BusinessLunchStartHours,
        BusinessLunchEndhours,
        EnableAutoClearingDNC,
        AutomaticTimeZoneDetectionEnabled,
        SelectStatusOnDispositionEnabled,
        UseDefaultStatusesWhenStatusNotMappedDisabled,
        PreserveLocalTouch,
        SearchLinkOnPopUp,
        LeadPoolCheck,
        DisableDownloadRecordingUsers,
        DisableStreamingRecordingUsers,
        DisableRecordingUsers,
        DownloadListAsSingleFile,
        ManagerCanEditLeadPoolSize,
        AllowCSVImportOnEditList,
        SfTaskTitlesEnabled,
        CompanyUrlDisplayLabel,
        AllowMultipleCSVFollowUpList,
        AllowCustomFieldsForCSV,
        MandatoryLeadSourceEnabled,
        DefaultLeadSourceForLead,
        DefaultLeadSourceForContact,
        UseOptmizedCodeForCallLists,
        DisableTaskCreationForProspectInSugar,
        callOnDaysEnabled,
        ArchiveListEnabled,
        FollowUpSequenceEnabledForOutreach,
        DisableVoicemail,
        AgentDispostitionSyncEnabledForOutreach,
        ConditionlFormattingEnabled,
        JoyIntegrationEnable,
        EnableMassEditCallLists,
        SyncUserFacingDisposition,
        EnhanceWriteBackEnabled,
        EnhanceWriteBackInterval,
        EnableCSVDataLoader,
        DisableStageForOutreach,
        CustomAgentDispositionsEnabled,
        TargetSessionDialTime,
        TargetConversations,
        IsDailyAutoScoreCard,
        IsWeeklyAutoScoreCard,
        IsMonthlyAutoScoreCard,
        CSVLeadFeedEmail,
        CSVLeadFeedEnabled,
        CSVLeadFeedListId,
        ValidPhoneNumbersEnabledForOutreach,
        TimeZoneForOutreachTasks,
        RealTimeConversationTeamEnabled,
        TeamId,
        DispositionsId,
        EmailId,
        TaskOutreachNotesEnabled,
        ContactInformationCustomField,
        RemoveCallMeFeature,
        ShowMultipleCustoms,
        AllowAnonymousDownloadRecording,
        EnableZIPImports,
        HearComLeadPoolCheckOut,
        ExecutiveSummaryAlertEnabled,
        ExecutiveSummaryManagers,
        EnableUpdateDisposition,
        EnableCompanytoRestrictCallingonEmergencyAreas,
        CompanyStateofEmergency,
        ExtendedCallPopUpEnabled,
        EnableSentimentForSalesloft,
        EnableSentimentForSalesloftAttempts,
        DisableStatusForSalesloft,
        FollowUpCadenceEnabledForSalesloft,
        AttemptSetting,
        ConversationSetting,
        MeetingSetting,
        SessionDialTimeSetting,
        ShowZerosageUserForScorCardUser,
        EnableEmailFlowinPP,
        UserManagementSettingCount,
        ShowOnlyLightingSessionDataInScorecard,
        EditContactOnPopupEnabled,
        CustomDispStatusEnabledForBH,
        ScorecardCompanyAccountOwner,
        ScorecardAccountOwnerMailList,
        ScorecardCSM,
        EnableDefaultLeadContactStatusforreferral,
        DefaultReferralLeadStatus,
        DefaultReferralContactStatus,
        ExcludeRepsFromAutoLogOff,
        ProdsHoursStartTime,
        ProdsHoursEndTime,
        ProdsHoursStartAndEndTime,
        AgentRingingEnabledForClient,
        Enableringingforagents,
        StepNotesEnabled,
        CollectionEnabledForOutreach,
        PenaltyBoxReportSettingsEnabled,
        PenaltyBoxReportManagers,
        DailyPenaltyBoxReportSettingsEnabled,
        WeeklyPenaltyBoxReportSettingsEnabled,
        MaxCallAttemptsPerDay,
        GlobalDailyJobTriggerSetting,
        GlobalDailyJobStatusSetting,
        ProspectNotesEnabledForOutreach,
        ShowRepGoalFunctionalitySetting,
        MandatoryListPriority,
        ConversationHistoryReportSettingsEnabled,
        ConversationHistoryReportManagers,
        EnableCallPreferenceForLeadPool,
        TriggersEnabled,
        ReferralPhoneFieldOptionalForSalesloft,
        ReferralPhoneFieldValueSalesloft,
        CompanyLevelDualConsentSetting,
        EnableAutoRefresh,
        AutoRefreshSec,
        EnablePollingForFollowUps,
        EnableUserManagement,
        OutreachFlowEnabled,
        ConnectedNumberSyncEnabled,
        PollingForOutreachEnabled,
        SalesloftFlowEnabled,
        NumberOfAttempts,
        NumberOfConversations,
        NoAttemptsNotificationEnabled,
        NoConversationsNotificationEnabled,
        AttemptRepLocker,
        ConversationsRepLocker,
        ConversationsWithoutConversionRepLocker,
        AttemptsWithoutConversionRepLocker,
        ConversationsWithoutPositiveDispositionRepLocker,
        NoAttemptWithoutConversionNotificationEnabled,
        NoConversationWithoutConversionNotificationEnable,
        IdpName,
        SignInURL,
        Issuer,
        X509Certificate,
        OktaIDPEnabled,
        DisableSignInForAllUsers,
        CallPopupVersion,
        FollowUpQuickListCollection,
        DisableSFAttemptsForNextGen,
        DisableUserNotAvailableAttemptsForNextGen,
        DisableRecordingDownloadFromJob,
        DefaultSalesloftAttemptSentiment,
        DefaultSalesloftAttemptDisposition,
        EnhancedCallDocumentationUsers,
        DisableInsightsWritebackForNextGen,
        EnableEnhancedCallPopUp,
        SFConsumerKey,
        SFConsumerSecret,
        EnableMobileCalendarInvite,
        StandardSFAttemptsNextGenEnabled,
        BaltoToken
    }
}
