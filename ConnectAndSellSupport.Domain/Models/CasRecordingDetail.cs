using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasRecordingDetail
    {
        public CasRecordingDetail()
        {
            CasErrorneousRecordings = new HashSet<CasErrorneousRecording>();
        }

        public int RecordingJobExcecutionId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ToBeProcessed { get; set; }
        public int? RecordingsExecuted { get; set; }
        public int? ErrorneousRecording { get; set; }
        public long? LastSucessfullRecordingId { get; set; }
        public DateTime? ExecutionStartDate { get; set; }
        public DateTime? ExecutionEndDate { get; set; }

        public virtual ICollection<CasErrorneousRecording> CasErrorneousRecordings { get; set; }
    }
}
