using ConnectAndSellSupport.Domain.ViewModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Response.User
{
    public class UserResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
    }
    public class UserBulkUploadResponse
    {
        public bool status { get; set; }
        public List<UserUploadError> ErrorDetails { get; set; }
        public string message { get; set; }
    }

    public class UserErrorDetails
    {
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }
    }
}
