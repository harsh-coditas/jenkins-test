namespace ConnectAndSellSupport.Services.Models.Response.User
{
    public class RefreshTokenServiceResponse : BaseServiceResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserName { get; set; }
        public bool InvalidRefreshToken { get; set; }
    }
}