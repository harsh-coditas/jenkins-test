using ConnectAndSellSupport.Domain.Models.Custom.Call;

namespace ConnectAndSellSupport.Services.Models.Response.Call
{
    public class CallRecordServiceResponse : BaseServiceResponse
    {
        public CallDetailsResponse CallDetails { get; set; }
        public NoteDetailsResponse NoteDetails { get; set; }
        public CallType CallType { get; set; }

        public bool InvalidLeadTransitId { get; set; }
        public bool PitcherRecordNotFound { get; set; }
        public bool CasNoteNotFound { get; set; }
    }
}
