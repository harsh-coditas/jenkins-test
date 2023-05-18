using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Models.Payload.User
{
    public class UserBulkUpload
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserBulkUpload(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }   
    }

    
}
