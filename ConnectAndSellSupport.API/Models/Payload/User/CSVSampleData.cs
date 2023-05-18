using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Models.Payload.User
{
    public class CSVSampleData
    {
        public List<UserBulkUpload> UserCsvData { get; set; }
        public CSVSampleData()
        {
            UserCsvData = new List<UserBulkUpload>();
            UserCsvData.Add(new UserBulkUpload("User1", "user1.email@officeemail.com", "User1@123"));
            UserCsvData.Add(new UserBulkUpload("User2", "user2.email@officeemail.com", "User2@123"));
            UserCsvData.Add(new UserBulkUpload("User3", "user3.email@officeemail.com", "User3@123"));
            UserCsvData.Add(new UserBulkUpload("User4", "user4.email@officeemail.com", "User4@123"));
            UserCsvData.Add(new UserBulkUpload("User5", "user5.email@officeemail.com", "User5@123"));
        }
    }
}
