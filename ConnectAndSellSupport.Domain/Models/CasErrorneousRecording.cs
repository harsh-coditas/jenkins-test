using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasErrorneousRecording
    {
        public int ErrorneousRecordingId { get; set; }
        public long? LeadTransitId { get; set; }
        public string ErrorneousMsg { get; set; }
        public int? RecordingJobExcecutionId { get; set; }

        public virtual CasRecordingDetail RecordingJobExcecution { get; set; }
    }
}
