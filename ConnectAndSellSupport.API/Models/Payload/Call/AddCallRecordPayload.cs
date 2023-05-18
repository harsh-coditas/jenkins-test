using System;
using System.Text.Json.Serialization;

namespace ConnectAndSellSupport.API.Models.Payload.Call
{
    public class AddCallRecordPayload : BasePayload
    {
        [JsonPropertyName("talktime_seconds")]
        public int TalktimeInSeconds { get; set; }

        [JsonPropertyName("disposition_id")]
        public int DispositionId { get; set; }

        //[JsonPropertyName("status")]
        //public string Status { get; set; }

        [JsonPropertyName("note_text")]
        public string NoteText { get; set; }

        [JsonPropertyName("next_steps")]
        public string NextSteps { get; set; }

        [JsonPropertyName("next_call_date")]
        public DateTime? NextCallDate { get; set; }
    }
}
