using System;

namespace ConnectAndSellSupport.Services.Models.Response.Call
{
    public class NoteDetailsResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Disposition { get; set; }
        public string NextSteps { get; set; }
        public string Status { get; set; }
        public int? TalkTime { get; set; }
        public int? LeadTransitId { get; set; }
        public DateTime? NextCallDate { get; set; }
    }
}
