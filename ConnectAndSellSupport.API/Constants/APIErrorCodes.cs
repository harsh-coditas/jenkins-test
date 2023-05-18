namespace ConnectAndSellSupport.API.Constants.Response
{
    public static class APIErrorCodes
    {
        #region Generic error codes
        public const string ValidationFailed = "VALIDATION_FAILED";
        public const string SystemUnstable = "SYSTEM_UNSTABLE";
        public const string InvalidEnvironment = "INV_ENV";
        public const string InternalServerException = "IN_SER_EXP";
        #endregion

        #region User login error codes
        public const string InvalidUserName = "INV_USR";
        public const string InvalidPassword = "INV_PASSWORD";
        public const string InvalidCredentials = "INV_CRED";
        public const string UserInactive = "USER_INACTIVE";
        public const string UserUnauthorized = "USER_UNAUTH";
        public const string UserNotApproved = "USER_NOT_APPROVED";
        public const string UserLockedOut = "USER_LOCKED_OUT";
        public const string InvalidRefreshToken = "INV_REFRESH_TOKEN";
        public const string UsersNotFound = "USERS_NOT_FOUND";
        #endregion

        #region Call record error codes
        public const string InvalidLeadTransitId = "INV_LEAD_TRANSIT_ID";
        public const string ConversationNotFound = "CONVERSATION_NOT_FOUND";
        public const string ConversationIncomplete = "CONVERSATION_INCP";
        public const string CasNoteNotFound = "CAS_NOTE_NOT_FOUND";
        public const string InvalidDispositionId = "INV_DISPOSITION_ID";
        public const string InvalidTalktime = "INV_TALKTIME";
        public const string InvalidNextCallDate = "INV_NXT_CALL_DATE";
        #endregion

        #region Company error codes
        public const string DispositionsNotFound = "DISPOSITION_NOT_FOUND";
        public const string CompaniesNotFound = "COMPANIES_NOT_FOUND";
        public const string JobsNotFound = "Jobs_NOT_FOUND";
        public const string InvalidCompanyId = "COMPANY_NOT_FOUND";
        #endregion

        #region List error codes
        public const string ListsNotFound = "LISTS_NOT_FOUND";
        #endregion

        #region Contacts error codes
        public const string ContactsNotFound = "CONTACTS_NOT_FOUND";
        #endregion

        #region Penalty box error codes
        public const string InvalidFileFormat = "INV_FILE";
        public const string EmptyFileFormat = "EMP_FILE";
        #endregion
        #region Replenishment error codes
        public const string ReplenishmentDataNotFound = "REPLENISHMENT_DATA_NOT_FOUND";
        #endregion

        #region
        public const string ContactNotFound = "Contact Not Found";
        public const string PenalizedPhoneNumberNotFound = "Penalized Phone Number Not Found";
        #endregion
    }
}
