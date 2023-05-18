using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.User
{
    public class UserServiceResponse : BaseServiceResponse
    {
        public List<UserDetails> Users { get; set; }

        public bool UsersNotFound { get; set; }
    }
}
