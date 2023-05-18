using ConnectAndSellSupport.Domain.Models.Custom.Company;

namespace ConnectAndSellSupport.Services.Models.Response.Company
{
    public class CompanyDisposition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DispositionType Type { get; set; }
        public DispositionMode Mode { get; set; }
        public int SortOrder { get; set; }
        public bool IsConversation { get; set; }
        public bool IsConversion { get; set; }
        public bool IsFollowUpMandatory { get; set; }
    }
}
