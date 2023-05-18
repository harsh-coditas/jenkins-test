namespace ConnectAndSellSupport.Services.Helpers.Password
{
    public interface IPasswordHelper
    {
        bool ValidatePassword(string password, string currentPasswordHash);
    }
}
