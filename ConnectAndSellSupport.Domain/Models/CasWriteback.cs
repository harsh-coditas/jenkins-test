using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasWriteback
    {
        public string CrmObjectType { get; set; }
        public string Status { get; set; }
        public DateTime? Time { get; set; }
        public string Reason { get; set; }
        public string ErrorCode { get; set; }
        public string CrmId { get; set; }
        public string PreferredCrm { get; set; }
        public int? ContactId { get; set; }
        public int Id { get; set; }
        public string LeadContactFieldValue { get; set; }
        public string TaskFieldValue { get; set; }
        public int? UserId { get; set; }
        public string Company { get; set; }
        public string CrmUserId { get; set; }
        public string ApiCallType { get; set; }
        public string UpdateId { get; set; }
        public string ListName { get; set; }
        public string SessionId { get; set; }
        public int? AttemptDiff { get; set; }
        public int? ConnectDiff { get; set; }
        public string FollowUpTaskPayload { get; set; }
        public string LeadContactUrl { get; set; }
        public string TaskUrl { get; set; }
        public string MethodType { get; set; }
    }
}
