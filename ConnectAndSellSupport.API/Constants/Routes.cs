namespace ConnectAndSellSupport.API.Constants
{
    public static class Routes
    {
        #region Generic API routes
        public const string GenericV1 = "/api/v1";
        public const string GenericControllerV1 = GenericV1 + "/[controller]";
        #endregion

        #region User API routes
        public const string SignIn = "signIn";
        public const string RefreshToken = "refreshToken";
        public const string UsersByCompanyId = "{companyId}";
        #endregion

        #region Call API routes
        public const string AgentCallRecord = "agentRecord/{leadTransitId}";
        public const string PitcherCallRecord = "pitcherRecord/{leadTransitId}";
        public const string AddPitcherCallRecord = "pitcherRecord/add/{leadTransitId}";
        public const string UpdatePitcherCallRecord = "pitcherRecord/update/{leadTransitId}";
        #endregion

        #region Company API routes
        public const string DispositionsByCompanyId = "dispositions/{companyId}";
        #endregion

        #region List API routes
        public const string ListsByCompanyId = "";
        public const string ListsForAutoRefreshByCompanyId = "autoRefresh/{companyId}";
        public const string ListsForAutoRefreshRemovalByCompanyId = "autoRefreshRemoval/{companyId}";
        public const string EnableAutoRefresh = "enableAutoRefresh";
        public const string DisableAutoRefresh = "disableAutoRefresh";
        #endregion

        #region PenaltyBox API routes
        public const string EntityRemoval = "entityRemoval";
        public const string ImportEntityRemoval = "entityRemoval/import/{companyId}";
        public const string SampleCsv = "samplecsv";
        #endregion
        #region Replenishment Data API routes
        public const string ReplenishmentData = "replenishmentData";
        #endregion
        #region Jobs Api routes
        public const string ListsForJobsByStartDateAndEndDate = "{startTime}&{endTime}";
        #endregion
        #region User Bulk Upload Api routes
        public const string ReadUserBulkCsv = "read-user-csv";
        public const string GetSampleCsvData = "GetSampleCsvData";
        #endregion

        public const string penaltyBoxUpdate = "entityRemoval";
        public const string GetPenaltyBoxDetails = "GetPenaltyBoxDetails/{phoneNumber}";
        public const string RemovePhoneNumberFromPenaltyBox = "RemovePhoneNumberFromPenaltyBox";
        public const string RemovePerticularDataFromPenaltyBox = "RemovePerticularDataFromPenaltyBox";

        #region Roles Route
        public const string Roles = "Roles";
        #endregion
    }
}
