namespace ConnectAndSellSupport.API.Constants
{
    public static class Messages
    {
        #region Generic messages
        public const string SuccessMessage = "Success";
        public const string ErrorMessage = "Error";
        public const string InternalServerException = "Internal server exception";
        #endregion

        #region User login messages
        public const string InvalidUserName = "Invalid username";
        public const string InvalidPassword = "Invalid password";
        public const string InvalidCredentials = "Username or password entered is incorrect. Please try again.";
        public const string UserInactive = "User is inactive";
        public const string UserUnauthorized = "This user does not have access to the feature";
        public const string UserNotApproved = "User is not approved";
        public const string UserLockedOut = "User account is locked out";
        public const string AuthenticationFailure = "Failed to authenticate user";
        public const string UsersNotFound = "Users not found";
        #endregion

        #region Call record messages
        public const string InvalidLeadTransitId = "Invalid lead transit id";
        public const string ConversationIncomplete = "Conversation incomplete";
        public const string InvalidDispositionId = "Invalid disposition";
        public const string InvalidTalktime = "Invalid talktime";
        public const string InvalidNextCallDate = "Next call date must be greater than the call date";
        public const string CasNoteNotFound = "Conversation note details not found";
        public const string ConversationNotFound = "Conversation not found";
        #endregion

        #region Company messages
        public const string DispositionsNotFound = "Dispositions not found";
        public const string CompaniesNotFound = "Companies not found";
        public const string InvalidCompanyId = "Invalid company id";
        #endregion

        #region List messages
        public const string ListsNotFound = "Lists not found";
        #endregion

        #region Contacts messages
        public const string ContactsNotFound = "No contacts found for given filters";
        #endregion

        #region Penalty box messages
        public const string InvalidFromDate = "Invalid from date";
        public const string InvalidToDate = "Invalid to date";
        public const string FromDateLessThanCurrentDate = "The From Date should be less than Current Date";
        public const string ToDateLessThanFromDate = "The To Date should be greater than From Date";
        public const string ToDateLessThanCurrentDate = "The To Date should be less than Current Date";
        public const string InvalidDateRange = "Date range should not be more than {0} days";
        public const string InvalidFileFormat = "Please upload a file in .csv format";
        public const string EmptyFileFormat = "The file uploaded has no valid rows";
        #endregion

        #region Replenishment messages
        public const string ReplenishmentDataNotFound = "Replenishment Data Not Found";
        #endregion
    }
}
