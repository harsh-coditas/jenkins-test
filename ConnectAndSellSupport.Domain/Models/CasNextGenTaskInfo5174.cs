using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasNextGenTaskInfo5174
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PrimaryTaskId { get; set; }
        public string SecondaryTaskId { get; set; }
        public string QuickListId { get; set; }
        public string SecondaryTaskType { get; set; }
        public bool? IsTaskSynced { get; set; }
        public bool? IsTaskDeleted { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? TaskSyncedDateTime { get; set; }
        public DateTime? TaskDeletedDateTime { get; set; }
        public string SubjectName { get; set; }
        public string PrimaryCrmid { get; set; }
        public string SecondaryCrmid { get; set; }
        public bool? IsNewTask { get; set; }
    }
}
