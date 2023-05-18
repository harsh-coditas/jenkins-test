using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class TMultiTouchLog
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ListId { get; set; }
        public DateTime CreateDate { get; set; }
        public string ActionType { get; set; }
        public string Template { get; set; }
        public string UserName { get; set; }
        public string ClientName { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime ModDate { get; set; }
        public int RuleId { get; set; }
        public int? SessionId { get; set; }
        public int? StepCount { get; set; }
    }
}
