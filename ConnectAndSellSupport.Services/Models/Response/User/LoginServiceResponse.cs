namespace ConnectAndSellSupport.Services.Models.Response.User
{
    public class LoginServiceResponse : BaseServiceResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool InvalidUserName { get; set; }
        public bool PasswordMisMatch { get; set; }
        public bool UserInactive { get; set; }
        public bool UserUnauthorized { get; set; }
        public bool UserNotApproved { get; set; }
        public bool UserLockedOut { get; set; }
        public bool HasError
        {
            get
            {
                return InvalidUserName || PasswordMisMatch || UserInactive || UserUnauthorized || UserNotApproved | UserLockedOut;
            }
        }
    }
}
