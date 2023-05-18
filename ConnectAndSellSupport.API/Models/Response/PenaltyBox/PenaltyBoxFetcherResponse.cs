using System.Collections.Generic;

namespace ConnectAndSellSupport.API.Models.Response.PenaltyBox
{
    public class PenaltyBoxFetcherResponse
    {
        public List<CasPenalisedPhoneNumberResponse> penalisedPhoneNumberResponse { get; set; }
        public List<CasPenaltyBoxResponse> penaltyBoxResponses { get; set; }
    }
}
