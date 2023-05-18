using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.PenaltyBox
{
    public class RemovePenaltyBoxEntityServiceResponse : BaseServiceResponse
    {
        public int UpdatedCount { get; set; }
        public bool ContactsNotFound { get; set; }
        public IEnumerable<string> NumbersNotFound { get; set; }
    }
}
