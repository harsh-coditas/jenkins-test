using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;

namespace ConnectAndSellSupport.API.Helpers.ReponseGenerator.ErrorResponse
{
    public static class ErrorDescriptionCreator
    {
        public static string GetDescription(string errorCode)
        {
            // To do : Create auto-mapping 
            return errorCode switch
            {
                #region Generic errors
                APIErrorCodes.InternalServerException => Messages.InternalServerException,
                #endregion

                #region User login errors
                APIErrorCodes.InvalidUserName => Messages.InvalidUserName,
                APIErrorCodes.InvalidPassword => Messages.InvalidPassword,
                APIErrorCodes.UserInactive => Messages.UserInactive,
                APIErrorCodes.UserUnauthorized => Messages.UserUnauthorized,
                APIErrorCodes.UserNotApproved => Messages.UserNotApproved,
                APIErrorCodes.UserLockedOut => Messages.UserLockedOut,
                APIErrorCodes.InvalidRefreshToken => Messages.AuthenticationFailure,
                APIErrorCodes.UsersNotFound => Messages.UsersNotFound,
                #endregion

                #region Call record errors
                APIErrorCodes.InvalidLeadTransitId => Messages.InvalidLeadTransitId,
                APIErrorCodes.ConversationNotFound => Messages.ConversationNotFound,
                APIErrorCodes.ConversationIncomplete => Messages.ConversationIncomplete,
                APIErrorCodes.CasNoteNotFound => Messages.CasNoteNotFound,
                APIErrorCodes.InvalidDispositionId => Messages.InvalidDispositionId,
                APIErrorCodes.InvalidTalktime => Messages.InvalidTalktime,
                APIErrorCodes.InvalidNextCallDate => Messages.InvalidNextCallDate,
                #endregion

                #region Company errors
                APIErrorCodes.DispositionsNotFound => Messages.DispositionsNotFound,
                APIErrorCodes.CompaniesNotFound => Messages.CasNoteNotFound,
                #endregion

                #region List errors
                APIErrorCodes.ListsNotFound => Messages.ListsNotFound,
                #endregion

                #region Contact errors
                APIErrorCodes.ContactsNotFound => Messages.ContactsNotFound,
                #endregion

                #region Penalty box errors
                APIErrorCodes.InvalidFileFormat => Messages.InvalidFileFormat,
                #endregion

                _ => string.Empty
            };
        }
    }
}
