using ConnectAndSellSupport.Domain.Models.Custom.Call;

namespace ConnectAndSellSupport.Services.Models.Response.Call
{
    public class PitcherCallRecordUpdateServiceResponse : BaseServiceResponse
    {
        public CallDetailsResponse CallDetails { get; set; }
        public NoteDetailsResponse NoteDetails { get; set; }
        public CallType CallType { get; set; }

        public bool InvalidLeadTransitId { get; set; }
        public bool InvalidNextCallDate { get; set; }
        public bool InvalidDispositionId { get; set; }
    }
}
