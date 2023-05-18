using System;

namespace ConnectAndSellSupport.Services.Models.Request.Call
{
    public class NoteDetailsRequest
    {
        //public string Status { get; set; }
        public int? TalkTime { get; set; }
        public string NoteText { get; set; }
        public string NextSteps { get; set; }
        public DateTime? NextCallDate { get; set; }
    }
}
