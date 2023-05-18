using ConnectAndSellSupport.Domain.Models.Custom.Call;
using System;

namespace ConnectAndSellSupport.Services.Models.Response.Call
{
    public class CallDetailsResponse
    {
        public int Id { get; set; }
        public int? LeadId { get; set; }
        public int? LeadTransitId { get; set; }
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public int? TalkTime { get; set; }
        public string CompanyName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string ContactTel1 { get; set; }
        public string ContactTel2 { get; set; }
        public string ContactEmail { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ClientId { get; set; }
        public int? DispositionId { get; set; }
    }
}
